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

        public RequestAssistant(string[] arr)
        {
            int lineCount = arr.Length - 2;

            prevStr = arr[lineCount - 1].Substring(25).Replace("\"", "");
            requestStrWithName = arr[lineCount].Substring(25).Replace("\"", "");
            requestStr = arr[lineCount].Substring(25).Replace("\"", "").Replace(Config.nameAssist, "");
        }

        public void Get(RichTextBox rtb)
        {
            if ((prevStr.Equals(Config.nameAssist) && requestStr.Length > 2)
                                || (requestStrWithName.Contains(Config.nameAssist) &&
                                requestStrWithName.Replace(Config.nameAssist, "").Length > 1))
            {
                if (requestStr.Contains("найди в интернете") || 
                    requestStr.Contains("найти в интернете")) {
                    resultStr = "Вот что нашлось...";                        
                }
                else if (requestStr.Contains("найди в заметках") ||
                    requestStr.Contains("найти в заметках")) {
                    resultStr = "Вот что нашлось...";
                }
                else resultStr = "Не удалось выполнить запрос!";

                rtb.AppendText("<- " + DateTime.Now.ToLocalTime() +
                        ": " + resultStr);
            }
        }
    }
}