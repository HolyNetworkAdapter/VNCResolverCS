using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VNCResolverCS
{
    public partial class VNCDetails : Form
    {
        public VNCDetails()
        {
            InitializeComponent();
        }

        private void VNCDetails_Load(object sender, EventArgs e)
        {
            var WebClient = new WebClient();
            try
            {
                string vnc = WebClient.DownloadString("https://computernewb.com/vncresolver/api/random");
                WebClient.Dispose();
                string jdata = vnc;
                dynamic data = JObject.Parse(jdata);

                label1.Text = data.ip + ":" + data.port;
                label2.Text = "ID: " + data.id;
                label3.Text = data.city + ", " + data.state + ", " + data.country;
                pictureBox2.Load("https://holynetworkadapter.fun/flags16/" + data.country + ".png");
                label4.Text = "ASN: " + data.asn;
                label5.Text = "Client name: " + data.clientname;
                label6.Text = "Hostname: " + data.hostname;
                label7.Text = "Screen resolution: " + data.screenres;
                pictureBox1.Load("https://computernewb.com/vncresolver/screenshots/" + data.ip + "_" + data.port + ".jpg");
                this.Text = "Details for " + data.ip + ":" + data.port;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
