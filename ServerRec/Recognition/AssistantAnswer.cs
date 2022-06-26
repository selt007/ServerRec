using System;

namespace ServerRec.Recognition
{
    class AssistantAnswer
    {
        Random rnd = new Random();
        public string AnswHello()
        {
            string[] arr = { "привет", "здарова", "здаров", 
                "здаров, че каво?", "приветик", "здравствуй", "хай" };
            return arr[rnd.Next(0, arr.Length)];
        }

        public string AnswReady()
        {
            string[] arr = { "готово", "исполнено", "сделано",
                 "всё", "готово. что еще?" };
            return arr[rnd.Next(0, arr.Length)];
        }

        public string AnswWhatsup()
        {
            string[] arr = { "нормально", "нормалек. а у тебя?", "не жалуюсь",
                "зашибись", "хорошо. ты как?", "скучаю. жду указаний", "норм. а у тебя?" };
            return arr[rnd.Next(0, arr.Length)];
        }
    }
}