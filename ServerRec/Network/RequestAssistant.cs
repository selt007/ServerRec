using ServerRec.Recognition;
using System;
using System.Windows.Forms;

namespace ServerRec.Network
{
    class RequestAssistant
    {
        string prevStr;
        string requestStr;
        string requestStrWithName;
        string resultStr;
        PhysicalController controller;

        public RequestAssistant(string[] arr)
        {
            int lineCount = arr.Length - 2;

            prevStr = arr[lineCount - 1].Substring(25).Replace("\"", "");
            requestStrWithName = arr[lineCount].Substring(25).Replace("\"", "");
            requestStr = arr[lineCount].Substring(25).Replace("\"", "").Replace(Config.nameAssist, "");
            controller = new PhysicalController(MainForm.ipContr);
        }

        public void Get(RichTextBox rtb)
        {
            /*if ((prevStr.Equals(Config.nameAssist) && requestStr.Length > 2)
                                || (requestStrWithName.Contains(Config.nameAssist) &&
                                requestStrWithName.Replace(Config.nameAssist, "").Length > 1))*/
            if ((requestStr.Length > 2) || (requestStrWithName.Contains(Config.nameAssist) &&
                                requestStrWithName.Replace(Config.nameAssist, "").Length > 1))
            {
                if (requestStr.Contains("найди в интернете") || 
                    requestStr.Contains("найти в интернете")) {
                    resultStr = "Вот что нашлось в интернете...";                        
                }
                else if (requestStr.Contains("найди в заметках") ||
                    requestStr.Contains("найти в заметках")) {
                    resultStr = "Вот что нашлось в заметках...";
                }
                else if (requestStr.Contains("привет") ||
                    requestStr.Contains("здарова")) {
                    resultStr = new AssistantAnswer().AnswHello();
                }
                else if (requestStr.Contains("включи свет") || 
                    requestStr.Contains("выключи свет")) {
                    controller.SendWeb("LED2");
                    resultStr = new AssistantAnswer().AnswReady();
                }
                else if (requestStr.Contains("как дела") || 
                    requestStr.Contains("как сам") ||
                    requestStr.Contains("как сама") ||
                    requestStr.Contains("че кого")) {
                    resultStr = new AssistantAnswer().AnswWhatsup();
                }
                else resultStr = "Не удалось выполнить запрос!";
                try {
                    new TextToSpeech(resultStr);
                    rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                            ": " + resultStr + "\n");
                } catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
    }
}