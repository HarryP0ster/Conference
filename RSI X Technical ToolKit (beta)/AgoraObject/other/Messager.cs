using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSI_X_Desktop.other
{
    public enum PERMISSIONS
    {
        NO_ACCES = 0,
        GLOBAL = 1,
        INTERPRETER = 2,
        CONFERENCE = 4,
    }
    public class Messager
    {
        const int LenCodeBlock = 2;
        const char ZERO = (char)0;

        static byte permission = 0;
        public static readonly System.Text.UTF8Encoding utf8enc = new();

        static public void SetPermission(byte perm) 
        {
            permission = perm;
        }
        static public byte[] PrepareTo(string msg, byte perm) 
        {
            byte[] buffer = utf8enc.GetBytes(msg);
            int size = buffer.Length;

            byte[] result = new byte[size + LenCodeBlock];

            for (int i = 0; i < size; i++)
                result[i] = buffer[i];
            result[^LenCodeBlock] = (byte)ZERO;
            result[^1] = perm;

            return result;
        }
        static public byte[] PrepareToGlobal(string msg) 
        {
            return PrepareTo(msg, (byte)PERMISSIONS.GLOBAL);
        }
        static public byte[] PrepareToConference(string msg)
        {
            return PrepareTo(msg, (byte)PERMISSIONS.CONFERENCE);
        }

        static public byte CheckMsgPerm(string msg)
        {
            if (msg.Length == 0)
                return (byte)PERMISSIONS.NO_ACCES;

            if (msg.Length >= LenCodeBlock && msg[^LenCodeBlock] == ZERO)
                return (byte)(msg.Last() & permission);

            return (byte)PERMISSIONS.GLOBAL;
        }
        static public string GetMessage(string msg) 
        {
            DebugWriter.WriteTime($"MsgFilter. Receive msg {msg}");
            if (msg.Length == LenCodeBlock && msg[^LenCodeBlock] == ZERO) 
            {
                DebugWriter.WriteTime($"MsgFilter. msg has no text");
                return "";
            }
            if (msg[LenCodeBlock - 1] != ZERO) 
            {
                DebugWriter.WriteTime($"MsgFilter. msg has no code");
                return msg;
            }

            DebugWriter.WriteTime($"MsgFilter. msg has code {msg.Last()}");
            return msg.Substring(LenCodeBlock);
        }

    }
}
