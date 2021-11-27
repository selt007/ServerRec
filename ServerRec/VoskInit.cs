using System;
using System.IO;
using System.Windows.Forms;
using Vosk;

public class VoskInit
{
    RichTextBox rtb;
    string nameAudio = "temp\\test1.wav";
    string nameModel = "models\\model-ru";
    float rate = 16000.0f;
    string str;

    public VoskInit(RichTextBox rtb)
    {
        this.rtb = rtb;
    }

    public void DemoBytes(Model model)
    {
        // Demo byte buffer
        VoskRecognizer rec = new VoskRecognizer(model, rate);
        rec.SetMaxAlternatives(0);
        rec.SetWords(true);
        using(Stream source = File.OpenRead(nameAudio)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0) {
                if (rec.AcceptWaveform(buffer, bytesRead)) {
                    //str += (rec.Result());
                } else {
                    //str += (rec.PartialResult());
                }
            }
        }
        str += "DemoBytes" + rec.FinalResult() + "\n";
    }

    public void DemoFloats(Model model)
    {
        // Demo float array
        VoskRecognizer rec = new VoskRecognizer(model, rate);
        using(Stream source = File.OpenRead(nameAudio)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0) {
                float[] fbuffer = new float[bytesRead / 2];
                for (int i = 0, n = 0; i < fbuffer.Length; i++, n+=2) {
                    fbuffer[i] = (short)(buffer[n] | buffer[n+1] << 8);
                }
                if (rec.AcceptWaveform(fbuffer, fbuffer.Length))
                {
                    //str += (rec.Result());
                }
                else
                {
                    //str += (rec.PartialResult());
                }
            }
        }
        str += "DemoFloats" + rec.FinalResult() + "\n";
    }

    public void DemoSpeaker(Model model)
    {
        // Output speakers
        SpkModel spkModel = new SpkModel("model-spk");
        VoskRecognizer rec = new VoskRecognizer(model, rate);
        rec.SetSpkModel(spkModel);

        using(Stream source = File.OpenRead(nameAudio)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0) {
                if (rec.AcceptWaveform(buffer, bytesRead)) {
                    //str += (rec.Result());
                } else {
                    //str += (rec.PartialResult());
                }
            }
        }
        str += "DemoSpeaker" + rec.FinalResult() + "\n";
    }

    public void Run()
    {
        if (Directory.Exists(nameModel))
        {
            // You can set to -1 to disable logging messages
            Vosk.Vosk.SetLogLevel(0);

            Model model = new Model(nameModel);
            DemoBytes(model);
            DemoFloats(model);
            DemoSpeaker(model);

            rtb.BeginInvoke(
                        new Action(() => {
                            rtb.AppendText(str);
                            rtb.ScrollToCaret();
                        }));
        }
        else
        {
            MessageBox.Show("�� ������� ������ ��� ������������� ����. " +
                "��� ������� �� ����� ���������������." +
                " ��������� ���������� ����� �������� � ������� �������.", 
                "��������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }
}