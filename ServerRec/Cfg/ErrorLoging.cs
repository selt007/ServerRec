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
                StreamReader sr = new StreamReader(path);
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(sr.ReadToEnd() + "\n" + errorStr);
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
