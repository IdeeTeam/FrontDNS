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

namespace ClientAppDNS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string postData = "{username:"
                + tbUsername.Text
                + ",password:"
                + tbPassword.Text
                + "}";

            var data = Encoding.UTF8.GetBytes(postData);

            var loginRequest = WebRequest.CreateHttp("http://localhost:3000/login");

            loginRequest.Method = "POST";
            loginRequest.ContentType = "application/json";
            loginRequest.ContentLength = data.Length;
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
                    //var dataStream = response.GetResponseStream();


                    //StreamReader reader = new StreamReader(dataStream);
                    //object objResponse = reader.ReadToEnd();

                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Unable to connect to server.");
                
            }
            

            MainForm pom = new MainForm();
            pom.ShowDialog();
        }
    }
}
