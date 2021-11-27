using System.Threading;
using System.Windows.Forms;
using System;

namespace ServerRec
{
    public partial class MainForm : Form
    {
        public static ErrorLoging errLog;
        SetupSocket setSocket;
        Thread threadSocket;
        Thread threadInit;
        VoskInit voskInit;
        static Config config;
        static int port;
        static string ip;
        bool run = false;
        bool log = false;
        bool cfg;

        public MainForm()
        {
            InitializeComponent();
            ToggleLog();
            errLog = new ErrorLoging();

            config = new Config(
                maskedTextIP, maskedTextPort, textBoxName, modelNameLabel);
            config.GetCfg(out cfg);

            if (cfg)
            {
                ip = maskedTextIP.Text;
                port = Convert.ToInt32(maskedTextPort.Text);
                setSocket = new SetupSocket(richTextBox, ip, port);

                threadSocket = new Thread(setSocket.RunSocket);
                threadSocket.IsBackground = true;
            }

            voskInit = new VoskInit(richTextBox, modelNameLabel.Text);
            threadInit = new Thread(voskInit.Init);
            threadInit.IsBackground = true;
        }

        private void buttonLog_Click(object sender, EventArgs e) => 
            ToggleLog();

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (maskedTextIP.Text.Equals("") || maskedTextPort.Text.Equals(""))
                MessageBox.Show("В поля с IP и\\или портом не были введены значения!", "Information!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (modelNameLabel.Text.Equals(""))
                MessageBox.Show("Выберите необходимую модель!", "Information!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                config.SetCfg();
                if (!run)
                {
                    if (checkBoxModel.Checked)
                        threadInit.Start();
                    threadSocket.Start();
                    buttonRun.Text = "Стоп";
                    richTextBox.AppendText("<- " + DateTime.Now.ToLocalTime() + 
                        ": " + "Сервер запущен. Выполняется прослушивание..." + "\n");
                    run = true;
                }
                else
                {
                    buttonRun.Text = "Старт";
                    richTextBox.AppendText("<- " + DateTime.Now.ToLocalTime() + 
                        ": " + "Сервер остановлен!" + "\n");
                    run = false;
                    buttonRun.Enabled = false;
                }
                richTextBox.ScrollToCaret();
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

        private void modelExploreButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.SelectedPath = Application.StartupPath + "\\models";

            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string openPath = folderBrowserDialog.SelectedPath;
                modelNameLabel.Text = openPath.Replace(Application.StartupPath + "\\models\\", "");
            }
        }

        private void checkBoxModel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModel.Checked)
            {
                modelExploreButton.Enabled = true;
                modelNameLabel.Enabled = true;
            }
            else
            {
                modelExploreButton.Enabled = false;
                modelNameLabel.Enabled = false;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            voskInit.Run();
            VoskInit.str = "";
        }
    }
}