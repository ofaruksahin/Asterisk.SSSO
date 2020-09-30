﻿using AsterNet.Standard.ARI_1_0.Models;

namespace Asterisk.SSSO.EventArgs
{
    public class OnAuthenticationFailedAfterArgs
    {
        public Channel channel{ get; set; }
        public string cause { get; set; }
        public OnAuthenticationFailedAfterArgs(Channel _channel,string _cause)             
        {
            channel = _channel;
            cause = _cause;
        }
    }
}
