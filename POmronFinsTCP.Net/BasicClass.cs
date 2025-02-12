using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace POmronFinsTCP.Net
{
    partial class BasicClass
    {
        //检查PLC链接状况
        internal static bool PingCheck(string ip, int timeOut)
        {
            Ping ping = new Ping();
            PingReply pr = ping.Send(ip, timeOut);
            if (pr.Status == IPStatus.Success)
                return true;
            else
                return false;
        }
    }
}
