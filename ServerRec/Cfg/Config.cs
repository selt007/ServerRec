using System;
using System.IO;
using System.Windows.Forms;

namespace ServerRec
{
    class Config
    {
        string path = Application.StartupPath + "\\config.cfg";
        public static string nameAssist;
        MaskedTextBox tb1, tb2;
        TextBox tb3;
        Label model;

        public Config(MaskedTextBox tb1, MaskedTextBox tb2, TextBox tb3, Label model)
        {
            this.tb1 = tb1;
            this.tb2 = tb2;
            this.tb3 = tb3;
            this.model = model;

            if (!File.Exists("config.cfg"))
                File.Create("config.cfg").Close();

            if (!Directory.Exists("models"))
                Directory.CreateDirectory("models");
            if (!Directory.Exists("temp"))
                Directory.CreateDirectory("temp");

        }

        public void SetCfg()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(tb1.Text + "\n" + tb2.Text + "\n" 
                        + tb3.Text.ToLower() + "\n" + model.Text.Replace("\r", ""));
                    nameAssist = tb3.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetCfg(out bool cfg)
        {
            string[] str;
            cfg = false;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    str = sr.ReadToEnd().Split('\n');
                    if (str.Length > 1)
                    {
                        tb1.Text = str[0];
                        tb2.Text = str[1];
                        tb3.Text = nameAssist =
                            str[2].Replace("\r", "");
                        model.Text = str[3].Replace("\r", "");
                        cfg = true;
                    }
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
