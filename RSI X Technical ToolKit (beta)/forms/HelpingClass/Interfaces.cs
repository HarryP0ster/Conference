using System;

namespace RSI_X_Desktop
{
    public interface IFormHostHolder
    {
        public void RefreshLocalWnd();
        public void SetLocalVideoPreview();
        public void DevicesClosed(System.Windows.Forms.Form Wnd);
        public void SetTrackBarVolume(int volume);
        public void NewBroadcaster(uint uid, agorartc.UserInfo info);
        public void BroadcasterUpdateInfo(uint uid, agorartc.UserInfo info);
        public void BroadcasterLeave(uint uid);
    }
    public enum EBroadcasterRoles
    {
        ROLE_DEFAULT = 0,
        ROLE_SECRETARY = 1,
        ROLE_HEAD = 2
    }
}
