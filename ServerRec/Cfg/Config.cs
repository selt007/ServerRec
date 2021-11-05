using System;
using System.IO;
using System.Windows.Forms;

namespace ServerRec
{
    class Config
    {
        string path = Application.StartupPath + "\\config.cfg";
        MaskedTextBox tb1, tb2;

        public Config(MaskedTextBox tb1, MaskedTextBox tb2)
        {
            this.tb1 = tb1;
            this.tb2 = tb2;
        }

        public void SetCfg()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(tb1.Text + "\n" + tb2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetCfg()
        {
            string[] str;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    str = sr.ReadToEnd().Split('\n'); ;
                    tb1.Text = str[0];
                    tb2.Text = str[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
