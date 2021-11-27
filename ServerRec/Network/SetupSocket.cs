using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ServerRec.Network;

namespace ServerRec
{
    class SetupSocket
    {
        RichTextBox rtb;
        string ip;
        int port;

        public SetupSocket(RichTextBox rtb, string ip, int port)
        {
            this.rtb = rtb;
            this.ip = ip;
            this.port = port;
        }

        public void RunSocket()
        {
            //int lineCount;
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listenSocket.Bind(ipPoint);
                listenSocket.Listen(10);

                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; 
                    byte[] data = new byte[256];
                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.UTF8.GetString(data));
                    }
                    while (handler.Available > 0);

                    rtb.BeginInvoke(
                        new Action(() => {
                            rtb.AppendText("=> " + DateTime.Now.ToLocalTime() + 
                                ": " + builder.ToString());
                            RequestAssistant ra = new RequestAssistant(rtb.Lines);
                            ra.Get(rtb);                            
                            rtb.ScrollToCaret();
                        }));

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                MainForm.errLog.AppendLog(ex.Message);
                rtb.BeginInvoke(
                    new Action(() => {
                        rtb.Text += "<- " + 
                        "Ошибка!.. Запись произведена в error-log.txt!" + "\n";
                    }));
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}