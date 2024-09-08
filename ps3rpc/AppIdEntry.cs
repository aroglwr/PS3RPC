using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps3rpc
{
    public partial class AppIdEntry : Form
    {
        IniFile configFile = default!;
        public AppIdEntry()
        {
            InitializeComponent();
            this.configFile = new IniFile("Settings.ini");
            this.appIdBox.Text = configFile.Read("ClientID");
            this.refreshBox.Value = Int16.Parse(configFile.Read("RefreshInterval"));

            if(configFile.Read("SendNotification") == "True")
            {
                notifBox.Checked = true;
            }


        }

        private void appIdButton_Click(object sender, EventArgs e)
        {
            this.configFile.Write("RefreshInterval", refreshBox.Value.ToString());
            this.configFile.Write("ClientID", appIdBox.Text);
            //this.Close();

        }

        private void appIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetConf_Click(object sender, EventArgs e)
        {
            configFile.DeleteKey("ClientID");
            configFile.DeleteKey("DefaultIP");
            configFile.Write("SendNotification", "True");
            configFile.Write("RefreshInterval", "20");
            appIdBox.Text = "";
            notifBox.Checked = true;
            refreshBox.Value = 20;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (notifBox.Checked == true)
            {
                configFile.Write("SendNotification", "True");
            }
            else
            {
                configFile.Write("SendNotification", "False");
            }
        }
    }
}
