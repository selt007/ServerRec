using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using NAudio.Utils;
using NAudio.Wave;
using ServerRec.Network;

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
                    int bytes = 0;
                    byte[] data = new byte[2048];
                    byte[] dataall = new byte[8000000];
                    int bytesall = 0;
                    do
                    {
                        bytes = handler.Receive(dataall);
                        bytesall = bytes;
                        //builder.Append(Encoding.UTF8.GetString(data));
                    }
                    while (handler.Available > 0);

                    /*using (var acceptFile = new FileStream(file, FileMode.Create))
                    {
                        acceptFile.Write(dataall, 0, bytesall);
                        builder.Append("Голос сохранен, размер " + bytesall + " байт.\n");

                        rtb.BeginInvoke(
                            new Action(() =>
                            {
                                rtb.AppendText("=> " + DateTime.Now.ToLocalTime() +
                                    ": " + builder.ToString());
                                RequestAssistant ra = new RequestAssistant(rtb.Lines);
                                ra.Get(rtb);
                                rtb.ScrollToCaret();
                            }));
                    }*/
                    using (var acceptFile = new WaveFileWriter(file, new WaveFormat(44100, 16, 1)))
                    {
                        acceptFile.Write(dataall, 1, bytesall);
                        builder.Append("Голос сохранен, размер " + bytesall + " байт.\n");

                        rtb.BeginInvoke(
                            new Action(() =>
                            {
                                rtb.AppendText("=> " + DateTime.Now.ToLocalTime() +
                                    ": " + builder.ToString());
                                RequestAssistant ra = new RequestAssistant(rtb.Lines);
                                ra.Get(rtb);
                                rtb.ScrollToCaret();
                            }));
                    }
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
                //MessageBox.Show(ex.Message, "Error!",
                    //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}