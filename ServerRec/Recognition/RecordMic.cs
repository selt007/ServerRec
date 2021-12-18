using NAudio.Wave;
using System;
using System.Timers;
using System.Windows.Forms;

namespace ServerRec.Recognition
{
    class RecordMic
    {
        /// <summary>
        /// Timer used to start/stop recording
        /// </summary>
        private System.Timers.Timer _timer;

        private WaveInEvent _waveSource;
        private WaveFileWriter _waveWriter;
        private string _tempFilename;
        public event EventHandler RecordingFinished;
        private RichTextBox rtb;

        public RecordMic(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        /// <summary>
        /// Record from the mic
        /// </summary>
        /// <param name="seconds">Duration in seconds</param>
        /// <param name="filename">Output file name</param>
        public void RecordAudio(int seconds)
        {
            /*if the filename is empty, throw an exception*/
            //if (string.IsNullOrEmpty(filename))
            //    throw new ArgumentNullException("The file name cannot be empty.");

            /*if the recording duration is not > 0, throw an exception*/
            if (seconds <= 0)
                throw new ArgumentNullException("The recording duration must be a positive integer.");

            _tempFilename = "temp\\temp.wav";

            _waveSource = new WaveInEvent
            {
                WaveFormat = new WaveFormat(44100, 1)
            };

            _waveSource.DataAvailable += DataAvailable;
            _waveSource.RecordingStopped += RecordingStopped;
            _waveWriter = new WaveFileWriter(_tempFilename, _waveSource.WaveFormat);

            /*Start the timer that will mark the recording end*/
            /*We multiply by 1000 because the Timer object works with milliseconds*/
            _timer = new System.Timers.Timer(seconds * 1000);

            /*if the timer elapses don't reset it, stop it instead*/
            _timer.AutoReset = false;

            /*Callback that will be executed once the recording duration has elapsed*/
            _timer.Elapsed += StopRecording;

            /*Start recording the audio*/
            _waveSource.StartRecording();

            /*Start the timer*/
            _timer.Start();
        }

        /// <summary>
        /// Callback that will be executed once the recording duration has elapsed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopRecording(object sender, ElapsedEventArgs e)
        {
            /*Stop the timer*/
            _timer?.Stop();

            /*Destroy/Dispose of the timer to free memory*/
            _timer?.Dispose();

            /*Stop the audio recording*/
            _waveSource.StopRecording();

            rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                                ": Запись произведена.\n");
        }

        /// <summary>
        /// Callback executed when the recording is stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecordingStopped(object sender, StoppedEventArgs e)
        {
            _waveSource.DataAvailable -= DataAvailable;
            _waveSource.RecordingStopped -= RecordingStopped;
            _waveSource?.Dispose();
            _waveWriter?.Dispose();

            /*Send notification that the recording is complete*/
            RecordingFinished?.Invoke(this, null);
        }

        /// <summary>
        /// Callback executed when new data is available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataAvailable(object sender, WaveInEventArgs e)
        {
            if (_waveWriter != null)
            {
                _waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
                _waveWriter.Flush();
            }
        }
    }
}