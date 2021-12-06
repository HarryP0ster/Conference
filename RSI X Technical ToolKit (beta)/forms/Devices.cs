using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        static private AgoraAudioRecordingDeviceManager RecordersManager;
        static private AgoraAudioPlaybackDeviceManager SpeakersManager;
        static private AgoraVideoDeviceManager videoDeviceManager;
        static List<string> Recorders;
        static List<string> VideoOut;
        static List<string> Speakers;

        public static int oldVolumeIn {get; private set;}
        public static int oldVolumeOut { get; private set; } = 100;
        public static string oldSpeaker { get; private set; }
        public static string oldRecorder {get; private set;}
        public static string oldVideoOut { get; private set; }

        bool IsAudioTest = false;
        int output;
        int input;
        long prebuf;
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

        }
        public Devices()
        {
            InitializeComponent();

            Recorders = getListAudioInputDevices();
            Speakers = getListAudioOutDevices();
            VideoOut = getListVideoDevices();
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

        private void getComputerDescription()
        {
            dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;

            if (Is64BitOperatingSystem == true)
            {
                dungeonLabel2.Text = "64 Bit операционная система";
            }
            else
            {
                dungeonLabel2.Text = "32 Bit операционная система";
            }

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

        #region ComboBoxEventHandlers
        private void comboBoxAudioInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            RecordersManager.GetDeviceInfoByIndex(ind, out name, out id);
            RecordersManager.SetCurrentDevice(id);
        }

        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            SpeakersManager.GetDeviceInfoByIndex(ind, out name, out id);
            SpeakersManager.SetCurrentDevice(id);
        }

        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            videoDeviceManager.GetDeviceInfoByIndex(ind, out name, out id);
            videoDeviceManager.SetCurrentDevice(id);

            workForm.RefreshLocalWnd();
        }


        #endregion

        private void NewDevices_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AgoraObject.Rtc.EnableLocalVideo(false);
            workForm?.SetLocalVideoPreview();
            ReleaseBass();
            Dispose();
        }

        private void trackBarSoundIn_ValueChanged()
        {
            var ret = RecordersManager.SetDeviceVolume(
                trackBarSoundIn.Value);
        }

        private void trackBarSoundOut_ValueChanged()
        {
            SetVolume(trackBarSoundOut.Value);
            //workForm?.SetTrackBarVolume(trackBarSoundOut.Value);
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

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            oldRecorder = Recorders[comboBoxAudioInput.SelectedIndex];
            oldSpeaker = Speakers[comboBoxAudioOutput.SelectedIndex];
            oldVideoOut = VideoOut[comboBoxVideo.SelectedIndex];
            oldVolumeIn = trackBarSoundIn.Value;
            oldVolumeOut = trackBarSoundOut.Value;

            CloseButton_Click(sender, e);
        }
        public static void AcceptAllOldDevices() 
        {
            try
            {
                AcceptNewRecordDevice();
                AcceptNewSpeakerDevice();
                AcceptNewVideoRecDevice();
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
                out string _, out string videoID);
            videoDeviceManager.SetCurrentDevice(videoID);
        }

        private static void AcceptNewSpeakerDevice()
        {
            SpeakersManager.GetDeviceInfoByIndex(
                Speakers.FindLastIndex((s) => s == oldSpeaker),
                out string _, out string speakID);
            SpeakersManager.SetCurrentDevice(speakID);
        }

        private static void AcceptNewRecordDevice()
        {
            RecordersManager.GetDeviceInfoByIndex(
                                Recorders.FindLastIndex((s) => s == oldRecorder),
                                out string _, out string recID);
            RecordersManager.SetCurrentDevice(recID);
        }

        internal void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundIn_ValueChanged();
            
            AcceptAllOldDevices();
            AgoraObject.GetWorkForm?.DevicesClosed(this);
            Close();
        }
        public void typeOfAlligment(bool sign)
        {
            if (sign == true)
                materialShowTabControl1.Alignment = TabAlignment.Left;
            else
                materialShowTabControl1.Alignment = TabAlignment.Right;
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

        public static void ClearOldDevices()
        {
            //oldRecorder = null;
            //oldVideoOut = null;
            Recorders?.Clear();
            VideoOut?.Clear();
        }
        public void UpdateSoundTrackBar()
        {
            trackBarSoundOut.Value = oldVolumeOut;
        }

        private void MicTestClicked(object sender, EventArgs e)
        {
            IsAudioTest = !IsAudioTest;
            if (IsAudioTest)
            {
                ReleaseBass();
                var devices = Bass.BASS_RecordGetDeviceInfos();
                AgoraObject.Rtc.DisableAudio();
                Bass.BASS_RecordInit(comboBoxAudioInput.SelectedIndex);
                Bass.BASS_Init(comboBoxAudioOutput.SelectedIndex + 2, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
                //STREAMPROC stream = new STREAMPROC(BASSStreamProc.STREAMPROC_PUSH, null);
                output = Bass.BASS_StreamCreate(44100, 1, BASSFlag.BASS_DEFAULT, BASSStreamProc.STREAMPROC_PUSH);
                Bass.BASS_ChannelSetDevice(output, comboBoxAudioOutput.SelectedIndex + 2);
                BASS_INFO info = Bass.BASS_GetInfo();
                prebuf = Bass.BASS_ChannelSeconds2Bytes(output, info.minbuf / 1000.0);
                Bass.BASS_ChannelSetDevice(input, comboBoxAudioInput.SelectedIndex);
                input = Bass.BASS_RecordStart(44100, 1, BASSFlag.BASS_STREAM_DECODE, RECORDPROC, IntPtr.Zero);
                
                MicTestBtn.Text = "Stop";
            }
            else
            {
                ReleaseBass();
                AgoraObject.Rtc.EnableAudio();
            }
            
        }


        bool RECORDPROC(int handle, IntPtr buffer, int length, IntPtr user)
        {
            Bass.BASS_StreamPutData(output, buffer, length);
            if (prebuf > 0)
            { // still prebuffering
                prebuf -= length;
                if (prebuf <= 0) Bass.BASS_ChannelPlay(output, false); // got enough, start the output
            }
            return true;
        }

        private void SpeakerTestBtn_Click(object sender, EventArgs e)
        {
            ReleaseBass();
            var devices = Bass.BASS_GetDeviceInfos();
            Bass.BASS_Init(comboBoxAudioOutput.SelectedIndex + 2, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
            Bass.BASS_SetDevice(comboBoxAudioOutput.SelectedIndex + 2);
            string File = "OutputBeep.wav";
            int stream = Bass.BASS_StreamCreateFile(File, 0, Properties.Resources.OutputBeep.Length, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            Bass.BASS_ChannelSetDevice(stream, comboBoxAudioOutput.SelectedIndex + 2);
            if (stream != 0)
                Bass.BASS_ChannelPlay(stream, true);
        }

        private void ReleaseBass()
        {
            Bass.BASS_ChannelStop(output);
            Bass.BASS_RecordFree();
            Bass.BASS_Free();
            IsAudioTest = false;
            MicTestBtn.Text = "Test";
        }
    }
}
