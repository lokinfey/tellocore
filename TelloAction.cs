using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace tellocore
{
    public  class TelloAction : IDisposable
    {
        string telloIP = "192.168.10.1";

        UdpClient udpClient;

        public TelloAction()
        {
            this.udpClient = new UdpClient();

        }
        public void Connect(int port)
        {
            this.udpClient.Connect(telloIP,port);
        }

        public  void Command(string cmd)
        {

            Byte[] sendCmdBytes = null;
            
            sendCmdBytes = Encoding.UTF8.GetBytes(cmd);
      
            this.udpClient.Send(sendCmdBytes, sendCmdBytes.Length);

            var start = DateTime.Now;

            if(cmd!="command" && cmd!="land" && cmd!="streamon")
            {

                bool status =true;

                while(status)
                {
                    var current = DateTime.Now;

                    if((current-start).Seconds>3)
                    {

                        status =false;
                        Console.WriteLine("please wait 5 seconds");
                    }

                }
            }
        }

        public void Close()
        {
            this.udpClient.Close();
            this.udpClient.Dispose();
        }

        public void Dispose()
        {
        }
    }
}