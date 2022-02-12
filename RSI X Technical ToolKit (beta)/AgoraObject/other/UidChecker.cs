using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop
{
    internal class UidChecker
    {
        private static HashSet<uint> uidsToMute = new();

        public static void MuteUid(uint uid) 
        {
            if (uidsToMute.Contains(uid))
                return;
            uidsToMute.Add(uid);
        }
        public static void UnMuteUid(uint uid)
        {
            if (uidsToMute.Contains(uid))
                uidsToMute.Remove(uid);
        }
        public static void ClearMuteUids()
        {
            uidsToMute.Clear();
        }
        public static bool IsMutedUid(uint uid) 
        { 
            return uidsToMute.Contains(uid); 
        }


    }
}
