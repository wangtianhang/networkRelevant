using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PingTest
{
    static void Main(string[] args)
    {
        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
        System.Net.NetworkInformation.PingReply reply = ping.Send("baidu.com", 3000, new byte[1473]);
        Console.WriteLine(reply.Status.ToString());
        Console.ReadLine();
    }
}
