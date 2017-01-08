using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;

using Newtonsoft.Json;

using System.Threading;

namespace ClientAppDNS
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer t;

        public MainForm()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 2000;//1000000;
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(this.serverCheckIn);
            thread.Start();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            t.Start();
            bStop.Enabled = true;
        }

        private void serverCheckIn()
        {
            var ipRequest = WebRequest.CreateHttp("https://api.ipify.org?format=json");
            ipRequest.Method = "GET";

            using (var ipResponse = ipRequest.GetResponse())
            {
                var dataStream = ipResponse.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var ipAddress = JsonConvert.DeserializeObject<IPFromJson>(objResponse.ToString());
                Console.WriteLine(ipAddress.ip);
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            bStop.Enabled = false;
            t.Stop();
            bStart.Enabled = true;
        }
    }
}
