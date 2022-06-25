using System.Net;

namespace ServerRec.Network
{
    class PhysicalController
    {
        string ip;
        string num;

        public PhysicalController(string ip, string num)
        {
            this.ip = ip;
            this.num = num;
        }

        public void SendWeb()
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadString($"http://" + ip + "/LED" + num);
            }
        }
    }
}