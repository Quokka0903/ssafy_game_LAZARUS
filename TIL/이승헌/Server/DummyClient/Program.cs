﻿using System.Net;
using System.Net.Sockets;
using System.Text;
using ServerCore;

namespace DummyClient // Note: actual namespace depends on the project name.
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            PacketManager.Instance.Register();
            //DNS (Domain Name System)
            string host = Dns.GetHostName();
            var ipHost = Dns.GetHostEntry(host);
            var ipAddr = ipHost.AddressList[0];
            var endPoint = new IPEndPoint(ipAddr, 7777);

            Connector connector = new Connector();
            
            connector.Connect(endPoint, () => { return new ServerSession();});

            while (true)
            {
                
                try
                {
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                Thread.Sleep(100);
            }

        }
    }
}