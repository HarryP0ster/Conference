using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop
{
    public static class NickCenter
    {
        const string HostStartsWith = "HOST_BROADCASTER";
        const string ConferenceStartsWith = "HOST_";
        const string PresidentStartsWith = "HOST_PRESIDENT";
        const string SecretaryStartsWith = "HOST_SECRETARY";

        const string PRESIDENT = "PRESIDENT";
        const string SECRETARY = "SECRETARY";
        const string BROADCASTER = "BROADCASTER";
        const string CONFERENCE = "CONFERENCE";
        const string AudienceStartsWith = "SPECTRATOR";

        public static string ToHostNick(string nick)
        {
            return $"{HostStartsWith}_{nick}";
        }
        public static string ToConferenceNick(string nick)
        {
            return $"{ConferenceStartsWith}{nick}";
        }
        public static string ToPresidentNick(string nick)
        {
            return $"{PresidentStartsWith}_{nick}";
        }
        public static string ToSecretaryNick(string nick)
        {
            return $"{SecretaryStartsWith}_{nick}";
        }
        public static bool IsHost(string nick) 
        {
            return nick.StartsWith(ConferenceStartsWith);
        }
        public static bool IsAudience(string nick)
        {
            return nick.StartsWith(AudienceStartsWith);
        }

        //public static bool IsInterpreter(string nick)
        //{
        //    return nick.Split(' ')[0].Contains('(') &&
        //           nick.Split(' ')[0].Contains(')');
        //}

        public static string GetNickHostFromMsg(string msg) 
        {
            if (msg.StartsWith(PresidentStartsWith))
                return PRESIDENT;
            if (msg.StartsWith(SecretaryStartsWith))
                return SECRETARY;
            if (msg.StartsWith(HostStartsWith))
                return BROADCASTER;
            if (msg.StartsWith(ConferenceStartsWith))
                return $"{CONFERENCE} {msg.Replace(ConferenceStartsWith, "")}";

            return msg;
        }
    }
}
