using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ps3rpc
{
    class Network
    {
        private WebClient client = new WebClient();


        private string get_data(string url)
        {
            string x = "";
            try
            {
                x = client.DownloadString(url);
            }
            catch
            {
            }
            return x;
        }
        public string getID(string ip)
        {
            string Output = get_data($"http://{ip}/cpursx.ps3?/sman.ps3");
            int gamePos = Output.IndexOf("target=\"_blank\">") + 16;
            return Output.Substring(gamePos, 9);
        }

        public void sendNotif(string ip)
        {
            client.DownloadString($"http://{ip}/notify.ps3mapi?msg=ps3rpc+connected%21&icon=5&snd=8");
        }

    }
}
