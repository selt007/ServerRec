using System;
using System.Net;

namespace ServerRec.Network
{
    class PhysicalController
    {
        string ip;

        public PhysicalController(string ip)
        {
            this.ip = ip;
        }

        public void SendWeb(string device)
        {
            string address = $"http://" + ip + "/" + device;

            using (var webClient = new WebClient())
            {
                Uri uri = new Uri(address);
                webClient.DownloadStringAsync(uri);
            }
        }
    }
}