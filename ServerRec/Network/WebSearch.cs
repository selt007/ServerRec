using System;
using System.Diagnostics;

namespace ServerRec.Network
{
    class WebSearch
    {
        public string Search(string searchTxt)
        {
            Process.Start("https://www.google.ru/search?q=" + searchTxt);

            return "Вот что нашлось в интернете...";
        }
    }
}