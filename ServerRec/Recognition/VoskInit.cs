using System;
using System.IO;
using System.Windows.Forms;
using Vosk;

public class VoskInit
{
    RichTextBox rtb;
    string nameAudio;
    string nameModel = "models\\";
    Model model;
    float rate = ServerRec.MainForm.rate;
    public static string str;

    public VoskInit(RichTextBox rtb, string nameModel)
    {
        this.rtb = rtb;
        this.nameModel += nameModel;
    }

    private void DemoBytes(Model model)
    {
        // Demo byte buffer
        VoskRecognizer rec = new VoskRecognizer(model, rate);
        rec.SetMaxAlternatives(0);
        rec.SetWords(true);
        using(Stream source = File.OpenRead(nameAudio)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0) {
                rec.AcceptWaveform(buffer, bytesRead);
            }
        }
        str += "DemoBytes: " + rec.FinalResult() + "\n";
    }

    private void DemoFloats(Model model)
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
                rec.AcceptWaveform(fbuffer, fbuffer.Length);
            }
        }
        //str += "DemoFloats: " + rec.FinalResult() + "\n";
        str += rec.FinalResult() + "\n";
    }

    private void DemoSpeaker(Model model)
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
        str += "DemoSpeaker: " + rec.FinalResult().Substring(13) + "\n";
    }

    public void Init()
    {
        // You can set to -1 to disable logging messages
        Vosk.Vosk.SetLogLevel(0);
        rtb.BeginInvoke(
                        new Action(() => {
                            rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                                ": Модель по пути \"" + nameModel + "\" загружается в память, подождите...\n");
                            rtb.ScrollToCaret();
                        }));
        model = new Model(nameModel);
        rtb.BeginInvoke(
                        new Action(() => {
                            rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                                ": Модель загружена.\n");
                            rtb.ScrollToCaret();
                            //RecordMic rm = new RecordMic(rtb);
                            //rm.RecordAudio(2);
                        }));
    }

    public void Run(string audio)
    {
        nameAudio = audio;
        if (Directory.Exists(nameModel))
        {
            DemoBytes(model);
            DemoFloats(model);
            //DemoSpeaker(model);

            rtb.BeginInvoke(
                        new Action(() => {
                            rtb.AppendText("=> " + DateTime.Now.ToLocalTime() + ": " +
                                str.Replace("}", "").Replace("\n", "")
                                .Replace("{\"text\": ", "")
                                .Replace("{  \"text\" : ", "") + "\n");
                            rtb.ScrollToCaret();
                            str = "";
                        }));

        }
        else
        {
            MessageBox.Show("Не найдена модель для распознавания речи. " +
                "Эта функция не будет функционировать." +
                " Остальной функционал будет работать в штатном порядке.",
                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }
}