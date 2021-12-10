using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop
{
    public static class NickCenter
    {
        const string HostStartsWith = "HOST";
        const string AudienceStartsWith = "SPECTRATOR";

        public static string ToHostNick(string nick)
        {
            return $"{HostStartsWith}_{nick}";
        }
        public static bool IsHost(string nick) 
        {
            return nick.StartsWith(HostStartsWith);
        }
        public static bool IsAudience(string nick)
        {
            return nick.StartsWith(AudienceStartsWith);
        }
        public static bool IsInterpreter(string nick)
        {
            return nick.Split(' ')[0].Contains('(') &&
                   nick.Split(' ')[0].Contains(')');
        }
    }
}
