using System.Runtime.InteropServices;
using static ps3rpc.Network;

namespace ps3rpc
{
    public partial class Hook : Form
    {
        public Hook()
        {
                       
            InitializeComponent();
            

        }
        // stupid console stuff delete on prod
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();


        private void Hook_Load(object sender, EventArgs e)
        {
            
            //AllocConsole();

            var ConfigIni = new IniFile("Settings.ini");
            var Id = ConfigIni.Read("ClientID");

            if (ConfigIni.Read("RefreshInterval").Length == 0)
            {
                ConfigIni.Write("RefreshInterval", "20");
            }
            if(ConfigIni.Read("SendNotification").Length == 0)
            {
                ConfigIni.Write("SendNotification", "True");
            }
            ipBox.Text = ConfigIni.Read("DefaultIP");
            

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HELP BUTTON PRESS");


            InfoBox infoBox = new InfoBox();
            infoBox.ShowDialog();
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            var ConfigIni = new IniFile("Settings.ini");
            var clientID = ConfigIni.Read("ClientID");
            if (clientID.Length == 0)
            {
                MessageBox.Show("No Client ID Found!");
                AppIdEntry appIdEntry = new();
                appIdEntry.Show();
                //MessageBox.Show("NO CLIENT");
                return;
            }
            if (String.IsNullOrEmpty(ipBox.Text))
            {
                MessageBox.Show("No IP Entered");
                return;
            }

            try
            {
                Network network = new Network();
                String ip_addr = ipBox.Text;
                ConfigIni.Write("DefaultIP", ip_addr);

                String gameID = network.getID(ip_addr);
                if (ConfigIni.Read("SendNotification") == "True")
                {
                    network.sendNotif(ip_addr);
                }
                
                StatusWindow statuswindow = new StatusWindow(gameID, ip_addr);
                statuswindow.Show();
                this.Visible = false;
                //this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured\nPlease check IP Address");
            }


        }
        private void cfgButton_Click(object sender, EventArgs e)
        {
            AppIdEntry appIdEntry = new();
            appIdEntry.ShowDialog();
        }
    }
}
