using System;
using System.Windows.Forms;
using NAudio.Wave;
using StoppedEventArgs = NAudio.Wave.StoppedEventArgs;

namespace ServerRec.Recognition
{
    class RecordMic
    {
        string file_loc;
        RichTextBox rtb;
        WaveIn waveIn;
        WaveFileWriter writer;

        public RecordMic(string file_loc, RichTextBox rtb)
        {
            this.file_loc = file_loc;
            this.rtb = rtb;
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.WriteData(e.Buffer, 0, e.BytesRecorded);
        }

        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;
            SetupSocket.voskInit.Run(file_loc);
        }

        public void StartRecording()
        {
            try
            {
                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped);
                waveIn.WaveFormat = new WaveFormat(16000, 1);
                writer = new WaveFileWriter(file_loc, waveIn.WaveFormat);
                waveIn.StartRecording();                 
            }
            catch (Exception ex)
            {
                rtb.BeginInvoke(
                     new Action(() => {
                         rtb.Text += "<- " +
                         ex.Message + "\n";
                     }));
            }
        }
        public void StopRecording()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
            }
        }
    }
}