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
            using (var webClient = new WebClient())
            {
                webClient.DownloadString($"http://" + ip + "/" + device);
            }
        }
    }
}