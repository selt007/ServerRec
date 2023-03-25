using System;
using System.Windows.Forms;
using ServerRec.Recognition;

namespace ServerRec.Network
{
    class RequestAssistant
    {
        public static bool relay_1 = false, 
            relay_2 = false, relay_3 = false, 
            relay_4 = false, relay_5 = false, 
            relay_6 = false, relay_7 = false;
        string prevStr;
        string requestStr;
        string requestStrWithName;
        string resultStr;
        PhysicalController controller;

        public RequestAssistant(string[] arr)
        {
            int lineCount = arr.Length - 2;

            prevStr = arr[lineCount - 1].Substring(24).Replace("\"", "");
            requestStrWithName = arr[lineCount].Substring(24).Replace("\"", "");
            requestStr = arr[lineCount].Substring(24).Replace("\"", "").Replace(Config.nameAssist, "");
            controller = new PhysicalController(MainForm.ipContr);
        }

        public RequestAssistant()
        {
            controller = new PhysicalController(MainForm.ipContr);
            controller.SendWeb("alloff");
        }

        public async void Get(RichTextBox rtb)
        {
            /*if ((prevStr.Equals(Config.nameAssist) && requestStr.Length > 2)
                                || (requestStrWithName.Contains(Config.nameAssist) &&
                                requestStrWithName.Replace(Config.nameAssist, "").Length > 1))*/
            if ((requestStr.Length > 2) || (requestStrWithName.Contains(Config.nameAssist) &&
                                requestStrWithName.Replace(Config.nameAssist, "").Length > 1))
            {
                if (requestStr.Contains("найди в заметках") ||
                    requestStr.Contains("найти в заметках"))
                {
                    resultStr = "Вот что нашлось в заметках...";
                }
                else if (requestStrWithName.Contains("закрой саму себя") ||
                    requestStrWithName.Contains("заверши работ") ||
                    requestStrWithName.Contains("завершил работ")) {
                    resultStr = new AssistantAnswer().AnswTurnOff();
                    Application.Exit();
                }
                else if (requestStr.Contains("включи свет"))
                {
                    if (!relay_2)
                    {
                        controller.SendWeb("LED2");
                        relay_2 = true;
                        resultStr = new AssistantAnswer().AnswReady();
                    }
                    else
                        resultStr = new AssistantAnswer().AnswBeforeDone();
                }
                else if (requestStr.Contains("выключи свет"))
                {
                    if (relay_2)
                    {
                        controller.SendWeb("LED2");
                        relay_2 = false;
                        resultStr = new AssistantAnswer().AnswReady();
                    }
                    else
                        resultStr = new AssistantAnswer().AnswBeforeDone();
                }
                else {
                    if (requestStr.Length > 8) new TextToSpeech("Секунду...");
                    try
                    {
                        var chatGPTInit = new ChatGPTInit();
                        var response = await chatGPTInit.SendPrompt(requestStr, "text-davinci-003");
                        resultStr = response;
                    }
                    catch 
                    {
                        resultStr = "К сожалению возникли непредвиденные обстоятельства " +
                            "и поэтому не удалось выполнить запрос!";
                    }
                }
                try {
                    new TextToSpeech(resultStr);
                    rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                            ": " + resultStr + "\n");
                } catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
    }
}