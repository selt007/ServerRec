using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServerRec
{
    class SetupSocket
    {
        public static Socket listenSocket;
        string file = "temp\\temp.wav";
        VoskInit voskInit;
        ErrorLoging errLog;
        RichTextBox rtb;
        string ip;
        int port;

        public SetupSocket(RichTextBox rtb, string ip, int port, string model)
        {
            this.rtb = rtb;
            this.ip = ip;
            this.port = port;
            errLog = new ErrorLoging();
            voskInit = new VoskInit(rtb, model);
        }

        public void RunSocket()
        {
            voskInit.Init();

            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listenSocket.Bind(ipPoint);
                listenSocket.Listen(10);

                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    StringBuilder builder = new StringBuilder();
                    byte[] data = null;
                    var buffer = new System.Collections.Generic.List<byte>();
                    do {
                        var currByte = new Byte[1];
                        var byteCounter = handler.Receive(currByte, currByte.Length, SocketFlags.None);

                        if (byteCounter.Equals(1))
                        {
                            buffer.Add(currByte[0]);
                        }
                    }
                    while (handler.Available > 0);

                    data = buffer.ToArray();
                    using (var acceptFile = new FileStream(file, FileMode.Create))
                    {
                        foreach (var byt in data) {
                            acceptFile.WriteByte(byt);
                        }
                        builder.Append("Голос сохранен, размер " + data.Length + " байт.\n");
                    }
                    rtb.BeginInvoke(
                        new Action(() =>
                        {
                            rtb.AppendText("=> " + DateTime.Now.ToLocalTime() +
                                ": " + builder.ToString());
                            rtb.ScrollToCaret();
                        }));
                    voskInit.Run(file);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                errLog.AppendLog(ex.Message);
                rtb.BeginInvoke(
                    new Action(() => {
                        rtb.Text += "<- " + 
                        "Ошибка!.. Запись произведена в error-log.txt!" + "\n";
                    }));
            }
        }        
    }
}