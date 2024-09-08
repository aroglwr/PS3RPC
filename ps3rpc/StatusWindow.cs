using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace ps3rpc
{
    public partial class StatusWindow : Form
    {

        // stupid console stuff delete on prod
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        // ini
        int refresh = default!;
        String clientId = default!;

        String id = default!;
        String large_text = default!;
        String state = default!;
        String small_cover = default!;
        String ip_addr = default!;
        String name = default!;
        String publisher = default!;
        String developer = default!;
        String type = default!;
        String cover = default!;
        String thumb = default!;
        Database db = default!;
        DiscordRpcClient client = default!;

        int timer = 0;
        public StatusWindow(String gameID, String ip_address)
        {
            InitializeComponent();
            this.id = gameID;
            this.ip_addr = ip_address;

            var ConfigIni = new IniFile("Settings.ini");
            this.clientId = ConfigIni.Read("ClientID");
            Int32.TryParse(ConfigIni.Read("RefreshInterval"), out this.refresh);
            Console.WriteLine(this.refresh);


        }
        private void GetDetails(Database database)
        {
            Database.DBGame gameData = new Database.DBGame();

            gameData = database.SearchDB(this.id);
            if (this.id == "PUBLIC \"-")
            {
                this.name = "On XMB";
                this.publisher = "Idle";
                this.type = "";
                this.cover = "";
                this.thumb = "https://www.psdevwiki.com/vita/images/b/bc/PSN_logo_color_trans.png";
                this.large_text = "XMB";
                this.small_cover = "";
                this.state = "Idle";


                GameCover.ImageLocation = @"./assets/xmb.png";
            }
            else
            {
                this.name = gameData.name;
                this.state = "In Game";
                this.cover = gameData.cover;
                this.thumb = gameData.thumb;
                this.publisher = gameData.publisher;
                this.developer = gameData.developer;
                this.type = gameData.type;
                this.large_text = this.id;
                this.small_cover = "https://gmedia.playstation.com/is/image/SIEPDC/ps-network-blue-bag-icon-01-01feb23?$100px--t$";

                GameCover.ImageLocation = this.cover;
            }



            nameLabel.Text = @name + "\n" + publisher + "\n" + type;
        }
        private void StatusWindow_Load(object sender, EventArgs e)
        {
            //AllocConsole();

            _stopwatch.Start();
            timer1.Start();
            timer1.Interval = 100;


            Console.WriteLine(this.id);
            nameLabel.Text = this.id;

            Database database = new Database();
            database.LoadDB();
            this.db = database;
            GetDetails(database);


            MainRpc();

        }

        private string GetGameID()
        {
            try
            {
                Network network = new Network();
                String gameID = network.getID(this.ip_addr);
                return gameID;

            }
            catch
            {
                MessageBox.Show("An Error Occured\nPlease check IP Address");
                return "";
            }
        }

        private void MainRpc()
        {
            var client = new DiscordRpcClient(this.clientId, pipe: -1);
            this.client = client;
            client.OnReady += (sender, msg) =>
            {
                Console.WriteLine("Connected to discord with user {0}", msg.User.Username);
            };
            client.OnPresenceUpdate += (sender, msg) =>
            {
                //The presence has updated
                Console.WriteLine("Presence has been updated! ");
            };
            client.Initialize();

            // == Set the presence
            client.SetPresence(new RichPresence()
            {
                Details = name,

                State = this.state,
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageText = this.large_text,
                    LargeImageKey = this.thumb, // was this.cover
                    SmallImageKey = this.small_cover,
                    SmallImageText = this.type

                }
            }
            );
        }
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private const string TimeFormat = @"hh\:mm\:ss";



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer += 1;
            //Console.WriteLine("tick");
            if (this.timer == this.refresh * 10)
            {
                this.timer = 0;

                // do id check here


                refreshGame();
            }

            timerLabel.Text = _stopwatch.Elapsed.ToString(TimeFormat);
        }
        private void refreshGame()
        {
            Console.WriteLine("refreshing presence");
            //Console.WriteLine(this.name);
            string newId = GetGameID();
            if (this.id == newId)
            {

            }
            else
            {
                this.id = newId;

                GetDetails(this.db);
                this.client.SetPresence(new RichPresence()
                {
                    Details = name,
                    State = this.state,

                    //State = "In Game",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageText = this.large_text,
                        LargeImageKey = this.thumb, // was this.cover
                        SmallImageKey = this.small_cover,
                        SmallImageText = this.type

                    }
                });
                _stopwatch.Restart();

            }
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }



        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshGame();

        }

        private void timerLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void StatusWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
