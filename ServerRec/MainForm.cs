using System.Threading;
using System.Windows.Forms;
using System;

namespace ServerRec
{
    public partial class MainForm : Form
    {
        public static ErrorLoging errLog;
        static Config config;
        static int port;
        static string ip;
        public static string msgLog;
        bool run = false;
        bool log = false;
        Thread threadSocket;
        SetupSocket setSocket;

        public MainForm()
        {
            InitializeComponent();
            ToggleLog();
            errLog = new ErrorLoging();

            config = new Config(
                maskedTextIP, maskedTextPort, textBoxName);
            config.GetCfg();

            ip = maskedTextIP.Text;
            port = Convert.ToInt32(maskedTextPort.Text);
            setSocket = new SetupSocket(richTextBox, ip, port);

            threadSocket = new Thread(setSocket.RunSocket);
            threadSocket.IsBackground = true;
        }

        private void buttonLog_Click(object sender, EventArgs e) => 
            ToggleLog();

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (maskedTextIP.Text.Equals("") || maskedTextPort.Text.Equals(""))
            {
                MessageBox.Show("В поля с IP и\\или портом не были введены значения!", "Information!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                config.SetCfg();
                if (!run)
                {
                    threadSocket.Start();
                    buttonRun.Text = "Стоп";
                    richTextBox.Text += "<- " + DateTime.Now.ToLocalTime() + 
                        ": " + "Сервер запущен. Выполняется прослушивание..." + "\n";
                    run = true;
                }
                else
                {
                    buttonRun.Text = "Старт";
                    richTextBox.Text += "<- " + DateTime.Now.ToLocalTime() + 
                        ": " + "Сервер остановлен!" + "\n";
                    run = false;
                    buttonRun.Enabled = false;
                }
            }            
        }

        private void ToggleLog()
        {
            if (!log)
            {
                Size = new System.Drawing.Size(518, Height);
                log = true;
                buttonLog.Text = "Скрыть Log";
            }
            else
            {
                Size = new System.Drawing.Size(250, Height);
                log = false;
                buttonLog.Text = "Log";
            }
        }

        private void buttonError_Click(object sender, EventArgs e) =>
            errLog.GetLog();
    }
}