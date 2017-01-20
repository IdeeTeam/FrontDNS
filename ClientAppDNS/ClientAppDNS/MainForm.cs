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

            lURLEnd.Text = "." + GlobalPOCO.username + ".idee.com";

            t = new System.Windows.Forms.Timer();
            t.Interval = 15000;//1000000;
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
            serverCheckIn(); //first time
            t.Start();
            bStop.Enabled = true;
        }

        private void serverCheckIn()
        {
            //if (!GlobalPOCO.customIP)
            //{
            //    getIP();
            //}
            string postData = "{ \"url\" : \""
                + tbURL.Text + "\","
                + " \"username\" : \""
                + GlobalPOCO.username + "\" }";

            var data = Encoding.UTF8.GetBytes(postData);

            var loginRequest = WebRequest.CreateHttp("http://localhost:3000/servercheckin");

            loginRequest.Method = "POST";
            loginRequest.ContentType = "application/json";
            loginRequest.ContentLength = data.Length;
            loginRequest.Headers.Add("token:" + GlobalPOCO.token);
            try
            {
                using (var stream = loginRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }

                using (var response = loginRequest.GetResponse())
                {
                    Console.WriteLine(((HttpWebResponse)response).StatusCode);

                }
            }
            catch (WebException ex)
            {

                if (bStop.InvokeRequired)
                {
                    bStop.BeginInvoke(new Action(() =>
                    {
                        bStop.Enabled = true;
                    }));
                }
                else
                {
                    bStop.Enabled = true;
                }

                t.Stop();

                if (bStart.InvokeRequired)
                {
                    bStart.BeginInvoke(new Action(() =>
                    {
                        bStart.Enabled = true;
                    }));
                }
                else
                {
                    bStart.Enabled = true;
                }
                if (ex.Response != null)
                {
                    var status = ((HttpWebResponse)ex.Response).StatusCode;
                    if (status == HttpStatusCode.Forbidden)
                    {
                        MessageBox.Show("Invalid credentials supplied");
                    }
                    else if (status == HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Invalid data supplied");
                    }
                    else if (status == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Not found");
                    }
                    else if (status == HttpStatusCode.InternalServerError)
                    {
                        MessageBox.Show("Server error");
                    }
                    else
                    {
                        MessageBox.Show("An error occured while connecting to server");
                    }
                }
                else
                {
                    MessageBox.Show("Connection unsuccessful");
                }
                

            }
        }


        //test funkcija, nikad se ne koristi
        private void getIP()
        {
            var ipRequest = WebRequest.CreateHttp("https://api.ipify.org?format=json");
            ipRequest.Method = "GET";
            try
            {
                using (var ipResponse = ipRequest.GetResponse())
                {
                    var dataStream = ipResponse.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);
                    object objResponse = reader.ReadToEnd();
                    var ipAddress = JsonConvert.DeserializeObject<IPFromJson>(objResponse.ToString());
                    Console.WriteLine(ipAddress.ip);
                    if (lIP.InvokeRequired)
                    {
                        lIP.BeginInvoke(new Action(() =>
                        {
                            GlobalPOCO.ipAddress = ipAddress.ip;
                            lIP.Text = ipAddress.ip;
                        }));
                    }
                    else
                    {
                        GlobalPOCO.ipAddress = ipAddress.ip;
                        lIP.Text = ipAddress.ip;
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    var status = ((HttpWebResponse)ex.Response).StatusCode;
                    if (status == HttpStatusCode.Forbidden)
                    {
                        MessageBox.Show("Invalid credentials supplied");
                    }
                    else if (status == HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Invalid data supplied");
                    }
                    else if (status == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Not found");
                    }
                    else if (status == HttpStatusCode.InternalServerError)
                    {
                        MessageBox.Show("Server error");
                    }
                    else
                    {
                        MessageBox.Show("An error occured while connecting to server");
                    }
                }
                else
                {
                    MessageBox.Show("Connection unsuccessful");
                }


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
