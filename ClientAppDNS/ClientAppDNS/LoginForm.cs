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
            string postData = "{\"username\" : \""
                + tbUsername.Text
                + "\", \"password\" : \""
                + tbPassword.Text
                + "\"}";

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


                    var dataStream = response.GetResponseStream();


                    StreamReader reader = new StreamReader(dataStream);
                    object objResponse = reader.ReadToEnd();
                    var tok = JsonConvert.DeserializeObject<TokenFromJson>(objResponse.ToString());
                    GlobalPOCO.token = tok.token;
                    GlobalPOCO.username = tbUsername.Text;

                    MainForm pom = new MainForm();
                    pom.ShowDialog();

                }
            }
            catch (WebException ex)
            {
                var status = ((HttpWebResponse)ex.Response).StatusCode;
                if (status == HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Invalid credentials supplied");
                }
                else if (status == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Unsuccessful login");
                }
                else if (status == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Not found");
                }
                else if (status == HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Server error");
                }
                else {
                    MessageBox.Show("An error occured while connecting to server");
                }
                
            }
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            string postData = "{\"username\" : \""
                + tbCreateUsername.Text
                + "\", \"password\" : \""
                + tbCreatePassword.Text
                + "\", \"email\" : \""
                + tbCreateEmail.Text
                + "\"}";


            var data = Encoding.UTF8.GetBytes(postData);

            var loginRequest = WebRequest.CreateHttp("http://localhost:3000/createuser");

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

                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Account created successfully. Please check your email to verify it.");
                    }

                }
            }
            catch (WebException ex)
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
        }
    }
}
