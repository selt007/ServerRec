using System;
using System.IO;
using System.Windows.Forms;

namespace ServerRec
{
    public class ErrorLoging
    {
        string path = Application.StartupPath + "\\error-log.txt";

        public void AppendLog(string errorStr)
        {
            try
            {
                string read = null;
                if (!File.Exists(path))
                    File.Create(path).Close();

                using (StreamReader sr = new StreamReader(path))
                {
                    read = sr.ReadToEnd();
                }

                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("=> " + DateTime.Now.ToLocalTime() +
                                ": " + errorStr + "\n" + read);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetLog()
        {
            try
            {
                if (!File.Exists(path))
                    File.Create(path).Close();
                System.Diagnostics.Process log = new System.Diagnostics.Process();
                log.StartInfo.FileName = "notepad.exe";
                log.StartInfo.Arguments = path;
                log.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
