using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agorartc;

namespace ConsoleAppIn
{
    internal class AEngineEventHandler : IRtcEngineEventHandlerBase
    {
        public override void OnJoinChannelSuccess(string channel, uint uid, int elapsed)
        {
            Console.WriteLine(string.Format("uid:{0}", uid));
        }
    }
}
