using System.Speech.Synthesis;

namespace ServerRec.Recognition
{
    class TextToSpeech
    {
        public TextToSpeech(string text)
        {
            var synth = new SpeechSynthesizer();

            synth.Rate = 3;
            synth.Volume = 65;

            synth.Speak(text);
        }
    }
}