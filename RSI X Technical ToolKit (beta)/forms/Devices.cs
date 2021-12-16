using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ReaLTaiizor;
using agorartc;
using RSI_X_Desktop.forms;
using static System.Environment;
using Un4seen.Bass;


namespace RSI_X_Desktop.forms
{
    public partial class Devices : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости

        private static readonly Color InactiveColor = Color.White;
        private static readonly Color PushColor = Color.BurlyWood;

        #region Resolutions
        public static readonly Dictionary<string, VIDEO_PROFILE_TYPE> resolutions = new()
        {
            [" 120 * 120 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_PORTRAIT_120P_3,
            [" 180 * 180 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_PORTRAIT_180P_3,
            [" 240 * 240 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_PORTRAIT_240P_3, 
            [" 360 * 360 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_PORTRAIT_360P_3,
            [" 480 * 480 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_PORTRAIT_480P_3,
            [" 960 * 720 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_720P_5,
            ["1920 * 1080"] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_1080P,
        };
        public static readonly Dictionary<string, ScreenCaptureParameters> resolutionsSize = new()
        {
            [" 120 * 120 "] = new(120, 120) { bitrate = 50, frameRate = 15 },
            [" 180 * 180 "] = new(180, 180) { bitrate = 100, frameRate = 15 },
            [" 240 * 240 "] = new(240, 240) { bitrate = 140, frameRate = 15 },
            [" 360 * 360 "] = new(360, 360) { bitrate = 260, frameRate = 15 },
            [" 480 * 480 "] = new(480, 480) { bitrate = 400, frameRate = 15 },
            [" 960 * 720 "] = new(960, 720) { bitrate = 910, frameRate = 15 },
            ["1920 * 1080"] = new(1920, 1080) { bitrate = 2080, frameRate = 15 },
        };
        #endregion

        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        private static Devices _instance;

        private static AgoraAudioRecordingDeviceManager RecordersManager;
        private static AgoraAudioPlaybackDeviceManager SpeakersManager;
        private static AgoraVideoDeviceManager videoDeviceManager;
        private static List<string> Recorders;
        private static List<string> VideoOut;
        private static List<string> Speakers;

        #region oldDevices
        public static int oldVolumeIn {get; private set;}
        public static int oldVolumeOut { get; private set; } = 100;
        public static string oldSpeaker { get; private set; }
        public static string oldRecorder {get; private set;}
        public static string oldVideoOut { get; private set; }
        public static string oldResolution { get; private set; }
        private static int oldIndexResolution = 3; //360p
        #endregion

        private int frames = 0;
        private string playback_device = "";
        private string recording_device = "";

        private bool IsAudioTest = false;
        private int output;
        private int input;
        private long prebuf;

        public Devices()
        {
            InitializeComponent();

            Recorders = getListAudioInputDevices();
            Speakers = getListAudioOutDevices();
            VideoOut = getListVideoDevices();

            resComboBox.DataSource = new List<string>(resolutions.Keys);
            resComboBox.SelectedIndex = oldIndexResolution;
        }
        private void NewDevices_Load(object sender, EventArgs e)
        {
            oldVolumeIn = RecordersManager.GetDeviceVolume();
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundOut.Value = oldVolumeOut;

            UpdateComboBoxRecorder();
            UpdateComboBoxVideoOut();
            UpdateComboBoxSpeakers();

            getComputerDescription();
        }

        public static void InitManager()
        {
            RecordersManager = AgoraObject.Rtc.CreateAudioRecordingDeviceManager();
            SpeakersManager = AgoraObject.Rtc.CreateAudioPlaybackDeviceManager();
            videoDeviceManager = AgoraObject.Rtc.CreateVideoDeviceManager();

            Recorders = getListAudioInputDevices();
            Speakers = getListAudioOutDevices();
            VideoOut = getListVideoDevices();

            bool hasOldRecorder = Recorders.Any((s) => s == oldRecorder);

            int index = (oldRecorder != null) ?
                Recorders.FindLastIndex((s) => s == oldRecorder) :
                index = getActiveAudioInputDevice();

            oldRecorder = Recorders[index];

            oldResolution = resolutions.Keys.ToArray()[oldIndexResolution];
            UpdateResolution(oldResolution);
        }

        private void getComputerDescription()
        {
            dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;
            dungeonLabel2.Text = Is64BitOperatingSystem ?
                "64 Bit операционная система" :
                "32 Bit операционная система";
            dungeonLabel3.Text = "Пользователь - " + UserName;
        }
        private static int getActiveAudioInputDevice()
        {
            int id = -1;

            RecordersManager.GetCurrentDeviceInfo(out string idAcvite, out string nameAcitve);

            for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
            {
                var ret = RecordersManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idAcvite == deviceid)
                {
                    id = i;
                    break;
                }

            }

            return id;
        }
        private static int getActiveAudioOutputDevice()
        {
            int id = -1;

            SpeakersManager.GetCurrentDeviceInfo(out string idAcvite, out string nameAcitve);

            for (int i = 0; i < SpeakersManager.GetDeviceCount(); i++)
            {
                var ret = SpeakersManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idAcvite == deviceid)
                {
                    id = i;
                    break;
                }

            }
            return id;
        }
        private static int getActiveVideoDevice()
        {
            int id = -1;

            string idActive = videoDeviceManager.GetCurrentDevice();

            for (int i = 0; i < videoDeviceManager.GetDeviceCount(); i++)
            {
                var ret = videoDeviceManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idActive == deviceid)
                {
                    id = i;
                    break;
                }

            }
            return id;
        }

        #region getDevicesList
        private static List<string> getListAudioInputDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = RecordersManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }
            return devicesOut;
        }
        private static List<string> getListAudioOutDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < SpeakersManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = SpeakersManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }

            return devicesOut;
        }
        private static List<string> getListVideoDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < videoDeviceManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = videoDeviceManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }

            return devicesOut;
        }
        #endregion

        #region UpdateComboBox
        private void UpdateComboBoxRecorder()
        {
            Recorders = getListAudioInputDevices();
            bool hasOldRecorder = Recorders.Any((s) => s == oldRecorder);

            int index = (oldRecorder != null && hasOldRecorder) ?
                Recorders.FindLastIndex((s) => s == oldRecorder) :
                getActiveAudioInputDevice();

            if (index == -1) 
                index = Recorders.Count > 0 ? 0 : - 1;

            if (index == -1 || Recorders.Count == 0) 
            {
                comboBoxAudioInput.DataSource = new List<string> { "Record Devices Error" };
                return;
            }

            oldRecorder = Recorders[index];

            comboBoxAudioInput.DataSource = Recorders;
            comboBoxAudioInput.SelectedIndex = index;
        }
        private void UpdateComboBoxVideoOut()
        {
            VideoOut = getListVideoDevices();
            bool hasoldVideoOut = VideoOut.Any((s) => s == oldVideoOut);

            int index = (oldVideoOut != null) ?
                VideoOut.FindLastIndex((s) => s == oldVideoOut) :
                getActiveVideoDevice();

            if (index == -1)
                index = VideoOut.Count > 0 ? 0 : -1;

            if (index == -1 || VideoOut.Count == 0)
            {
                comboBoxVideo.DataSource = new List<string> { "Video Devices Error" };
                return;
            }


            oldVideoOut = VideoOut[index];
            comboBoxVideo.DataSource = VideoOut;
            comboBoxVideo.SelectedIndex = index;
        }
        private void UpdateComboBoxSpeakers()
        {
            Speakers = getListAudioOutDevices();
            bool hasoldSpeaker = Speakers.Any((s) => s == oldSpeaker);

            int index = (oldSpeaker != null) ?
                Speakers.FindLastIndex((s) => s == oldSpeaker) :
                getActiveAudioOutputDevice();

            if (index == -1)
                index = Speakers.Count > 0 ? 0 : -1;

            if (index == -1 || Speakers.Count == 0)
            {
                comboBoxAudioOutput.DataSource = new List<string> { "Playback Devices Error" };
                return;
            }


            oldSpeaker = Speakers[index];
            comboBoxAudioOutput.DataSource = Speakers;
            comboBoxAudioOutput.SelectedIndex = index;
        }
        #endregion

        #region ComboBoxEventHandlers
        private void comboBoxAudioInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            recording_device = comboBoxAudioInput.Text;
            if (IsAudioTest) frames = 1000; //Force restart of the recording process

            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            RecordersManager.GetDeviceInfoByIndex(ind, out name, out id);
            RecordersManager.SetCurrentDevice(id);
        }
        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            playback_device = comboBoxAudioOutput.Text;
            if (IsAudioTest) frames = 1000; //Force restart of the recording process

            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            SpeakersManager.GetDeviceInfoByIndex(ind, out name, out id);
            SpeakersManager.SetCurrentDevice(id);
        }
        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            if (false == AgoraObject.IsScreenCapture) 
            {
                videoDeviceManager.GetDeviceInfoByIndex(ind, out name, out id);
                videoDeviceManager.SetCurrentDevice(id);
            }
            workForm.RefreshLocalWnd();
        }
        private void resComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = resComboBox.SelectedValue;
            UpdateResolution(res.ToString());

            pictureBoxLocalVideoTest.Refresh();
        }
        #endregion

        #region TrackBarEvents
        private void trackBarSoundIn_ValueChanged()
        {
            var ret = RecordersManager.SetDeviceVolume(
                trackBarSoundIn.Value);
        }
        private void trackBarSoundOut_ValueChanged()
        {
            Bass.BASS_ChannelSetAttribute(output, BASSAttribute.BASS_ATTRIB_VOL, (float)trackBarSoundOut.Value / 100);
        }
        #endregion

        #region ButtonEvents
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            oldRecorder = Recorders[comboBoxAudioInput.SelectedIndex];
            oldSpeaker = Speakers[comboBoxAudioOutput.SelectedIndex];
            oldVideoOut = VideoOut[comboBoxVideo.SelectedIndex];
            oldVolumeIn = trackBarSoundIn.Value;
            oldVolumeOut = trackBarSoundOut.Value;
            oldResolution = resComboBox.SelectedValue.ToString();
            oldIndexResolution = resComboBox.SelectedIndex;
            SetVolume(trackBarSoundOut.Value);

            CloseButton_Click(sender, e);
        }
        internal void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundIn_ValueChanged();
            
            AcceptAllOldDevices();
            AgoraObject.GetWorkForm?.DevicesClosed(this);
            Close();
        }
        private void buttonImgSend_Click(object sender, EventArgs e)
        {
            if (ImageSender.IsEnable)
            {
                ImageSender.configImageToSend(null);
                ImageSender.EnableImageSender(false);

                // wtf?
                AgoraObject.StopScreenCapture();
                ResetVideoDevice();
                button2.ForeColor = InactiveColor;
            }
            else
            {
                var fd = new OpenFileDialog();
                fd.ShowDialog();

                if (fd.FileName != String.Empty)
                {
                    try
                    {
                        SetImageSend(false);
                        ImageSender.configImageToSend(new Bitmap(fd.FileName), 5);
                        ImageSender.EnableImageSender(true);
                        button2.ForeColor = PushColor;
                    }
                    catch (Exception ex)
                    {
                        SetImageSend(true);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region TabControl Events
        private void materialShowTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MicTestBtn.Text = "Test";
            ReleaseBass();
            IsAudioTest = false;
        }
        private void materialShowTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Video)
            {
                workForm?.RefreshLocalWnd();
                VideoCanvas vc = new((ulong)pictureBoxLocalVideoTest.Handle, 0);
                vc.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);
                AgoraObject.Rtc.StartPreview();
                AgoraObject.Rtc.SetupLocalVideo(vc);
            }
        }
        private void materialShowTabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Video)
            {
                workForm?.SetLocalVideoPreview();
            }
        }
        #endregion

        #region AudioTests snd BASS
        private void MicTestClicked(object sender, EventArgs e) //Playback button click
        {
            IsAudioTest = !IsAudioTest;
            if (IsAudioTest)
            {
                ReleaseBass();
                MicTestBtn.Text = "Stop";
                AgoraObject.Rtc.DisableAudio();
                Bass.LoadMe();
                InitPlayback();
            }
            else
            {
                MicTestBtn.Text = "Test";
                ReleaseBass();
                AgoraObject.Rtc.EnableAudio();
            }

        }
        bool RECORDPROC(int handle, IntPtr buffer, int length, IntPtr user) //This functions is called every time recorder sends stream to the speaker
        {
            
            Bass.BASS_StreamPutData(output, buffer, length);
            if (prebuf > 0)
            { // still prebuffering
                prebuf -= length;
            }
            else
            {
                Bass.BASS_ChannelPlay(output, false);
                BASS_INFO info = Bass.BASS_GetInfo();
                prebuf = Bass.BASS_ChannelSeconds2Bytes(output, (float)info.minbuf / 1000);
                /*
                 Simply the most important part of the code is coming next, delete this and you will face 
                your death from ManagedBass NullReference exception
                 */
                if (++frames > 750) //every 7.5 seconds
                {
                    frames = 0;
                    InitPlayback();
                    return false;
                }
            }
            return true;
        }
        private void InitPlayback() //Takes input from mic and pushes it to the speaker
        {
            int speaker_index = GetDeviceIndex(playback_device);
            int microphone_index = GetRecordIndex(recording_device);

            Bass.BASS_RecordInit(microphone_index);
            Bass.BASS_Init(speaker_index, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
            output = Bass.BASS_StreamCreate(44100, 1, BASSFlag.BASS_STREAM_AUTOFREE, BASSStreamProc.STREAMPROC_PUSH);
            Bass.BASS_ChannelSetDevice(output, speaker_index);
            Bass.BASS_ChannelSetDevice(input, microphone_index);

            input = Bass.BASS_RecordStart(44100, 1, BASSFlag.BASS_STREAM_AUTOFREE, RECORDPROC, IntPtr.Zero);
            GC.Collect();
        }
        private void SpeakerTestBtn_Click(object sender, EventArgs e) //Plays a simple beep sound to indicate selected speaker
        {
            MicTestBtn.Text = "Test";
            ReleaseBass();
            IsAudioTest = false;
            int device_index = GetDeviceIndex(comboBoxAudioOutput.Text);

            Bass.BASS_Init(device_index, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
            Bass.BASS_SetDevice(device_index);
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string File = projectDirectory + "\\Resources\\OutputBeep.wav";
            int stream = Bass.BASS_StreamCreateFile(File, 0, Properties.Resources.OutputBeep.Length, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            Bass.BASS_ChannelSetDevice(stream, comboBoxAudioOutput.SelectedIndex + 2);
            if (stream != 0)
                Bass.BASS_ChannelPlay(stream, true);
        }
        private int GetDeviceIndex(string devicename)
        {
            var devices = Bass.BASS_GetDeviceInfos();
            int device_index = 0;
            foreach (BASS_DEVICEINFO device in devices)
            {
                if (device.name == devicename)
                    return device_index;
                else
                    device_index++;
            }
            return -1;
        }
        private int GetRecordIndex(string devicename)
        {
            var devices = Bass.BASS_RecordGetDeviceInfos();
            int device_index = 0;
            foreach (BASS_DEVICEINFO device in devices)
            {
                if (device.name == devicename)
                    return device_index;
                else
                    device_index++;
            }
            return -1;
        }
        private void ReleaseBass() //Completely releases ManagedBass streams and channels
        {
            Bass.BASS_StreamFree(output);
            Bass.BASS_ChannelStop(input);
            Bass.BASS_RecordFree();
            Bass.BASS_Free();
            Bass.BASS_Stop();
            Bass.FreeMe();
            GC.Collect();
        }
        #endregion

        public static void SetImageSend(bool block)
        {
            if (_instance == null) return;

            if (_instance.InvokeRequired)
                _instance.Invoke((MethodInvoker)delegate
                {
                    _instance.button2.Enabled = block;
                });
            else { _instance.button2.Enabled = block; }
        }
        public static void SetVolume(int value)
        {
            int NewVolume = ((ushort.MaxValue / 100) * value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
        public void SetAudienceSettings()
        {
            materialShowTabControl1.SelectTab(1);
        }
        public static void ResetVideoDevice()
        {
            try
            {
                VideoOut = getListVideoDevices();
                int index = VideoOut.FindLastIndex((s) => s == oldVideoOut);
                index = index == -1 ? 0 : index;

                videoDeviceManager.GetDeviceInfoByIndex(
                    index,
                    out string devName, out string videoID);
                DebugWriter.WriteTime("update video device");
                videoDeviceManager.SetCurrentDevice(videoID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void tryReAcceptVideoDevice() 
        {
            try
            {
                AcceptNewVideoRecDevice();
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.Message);
            }
        }
        private static void UpdateResolution(string res)
        {
            AgoraObject.Rtc.SetVideoProfile(resolutions[res], false);
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select resolution: {res}");

            if (AgoraObject.IsScreenCapture)
                AgoraObject.EnableScreenCapture(resolutionsSize[res]);

        }

        public static void AcceptAllOldDevices() 
        {
            try
            {
                AcceptNewRecordDevice();
                AcceptNewSpeakerDevice();
                AcceptNewVideoRecDevice();
                AcceptNewResolution();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void AcceptNewVideoRecDevice()
        {
            videoDeviceManager.GetDeviceInfoByIndex(
                VideoOut.FindLastIndex((s) => s == oldVideoOut),
                out string devName, out string videoID);
            videoDeviceManager.SetCurrentDevice(videoID);

            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select video: {devName}");
        }
        private static void AcceptNewSpeakerDevice()
        {
            SpeakersManager.GetDeviceInfoByIndex(
                Speakers.FindLastIndex((s) => s == oldSpeaker),
                out string devName, out string speakID);
            SpeakersManager.SetCurrentDevice(speakID);

            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select speaker: {devName}");
        }
        private static void AcceptNewRecordDevice()
        {
            RecordersManager.GetDeviceInfoByIndex(
                                Recorders.FindLastIndex((s) => s == oldRecorder),
                                out string devName, out string recID);
            RecordersManager.SetCurrentDevice(recID);

            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select recorder: {devName}");
        }
        private static void AcceptNewResolution()
        {
            UpdateResolution(oldResolution);
        }

        public void typeOfAlligment(bool sign)
        {
            if (sign == true)
                materialShowTabControl1.Alignment = TabAlignment.Left;
            else
                materialShowTabControl1.Alignment = TabAlignment.Right;
        }
        private void NewDevices_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AgoraObject.Rtc.EnableLocalVideo(false);
            workForm?.SetLocalVideoPreview();
            ReleaseBass();
            Dispose();
        }
        public static void ClearOldDevices()
        {
            //oldRecorder = null;
            //oldVideoOut = null;
            Recorders?.Clear();
            VideoOut?.Clear();
        }
        public static void Clear() 
        {
            oldVolumeIn = 100;
            oldVolumeOut = 100;
            oldSpeaker = null;
            oldRecorder = null;
            oldVideoOut = null;
            oldResolution = null;
            oldIndexResolution = 3; //360p
        }
    }
}
