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

namespace RSI_X_Desktop.forms
{
    public partial class Devices : Form
    {
        //[DllImport("winmm.dll")]
        //public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости
        //private static int volume = 100;
        //public int Volume { get => volume; }

        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        static private AgoraAudioRecordingDeviceManager RecordersManager;
        static private AgoraAudioPlaybackDeviceManager audioOutDeviceManager;
        static private AgoraVideoDeviceManager videoDeviceManager;
        static List<string> Recorders;
        static List<string> VideoOut;

        public static int oldVolumeIn {get; private set;}
        public static string oldRecorder {get; private set;}
        public static string oldVideoOut { get; private set; }

        public static void InitManager()
        {
            RecordersManager = AgoraObject.Rtc.CreateAudioRecordingDeviceManager();
            audioOutDeviceManager = AgoraObject.Rtc.CreateAudioPlaybackDeviceManager();
            videoDeviceManager = AgoraObject.Rtc.CreateVideoDeviceManager();

            Recorders = getListAudioInputDevices();
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
            VideoOut = getListVideoDevices();
        }
        private void NewDevices_Load(object sender, EventArgs e)
        {
            oldVolumeIn = RecordersManager.GetDeviceVolume();
            trackBarSoundIn.Value = oldVolumeIn;

            UpdateComboBoxRecorder();
            UpdateComboBoxVideoOut();
            
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

            audioOutDeviceManager.GetCurrentDeviceInfo(out string idAcvite, out string nameAcitve);

            for (int i = 0; i < audioOutDeviceManager.GetDeviceCount(); i++)
            {
                var ret = audioOutDeviceManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
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

            for (int i = 0; i < audioOutDeviceManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = audioOutDeviceManager.GetDeviceInfoByIndex(i, out device, out id);

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
            //audioInDeviceManager.SetCurrentDevice(id);
        }

        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            audioOutDeviceManager.GetDeviceInfoByIndex(ind, out name, out id);
            //audioOutDeviceManager.SetCurrentDevice(id);
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
            Dispose();
        }

        private void trackBarSoundIn_ValueChanged()
        {
            var ret = RecordersManager.SetDeviceVolume(
                trackBarSoundIn.Value);
        }

        //private void trackBarSoundOut_ValueChanged(object sender, EventArgs e)
        //{
        //    SetVolume(trackBarSoundOut.Value);
        //    workForm?.SetTrackBarVolume(trackBarSoundOut.Value);
        //}

        public void SetAudienceSettings()
        {
            materialShowTabControl1.SelectTab(1);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            oldRecorder = Recorders[comboBoxAudioInput.SelectedIndex];
            oldVideoOut = VideoOut[comboBoxVideo.SelectedIndex];
            oldVolumeIn = trackBarSoundIn.Value;

            CloseButton_Click(sender, e);
        }
        public static void AcceptAllOldDevices() 
        {
            try
            {
                if (oldRecorder != null)
                    RecordersManager.SetCurrentDevice(oldRecorder);
                if (oldVideoOut != null)
                    videoDeviceManager.SetCurrentDevice(oldVideoOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
