using Newtonsoft.Json;
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

namespace LTI_Lab3._2
{
    public partial class AssociateFloatingIP : Form
    {
        private String token;
        private String url;
        private String instanceID;
        private String networkUrl;
        public AssociateFloatingIP(String token, String url, String instanceID)
        {
            InitializeComponent();
            this.token = token;
            this.url = url;
            this.instanceID = instanceID;
            int index = url.IndexOf(":");
            if (index >= 0)
                networkUrl = url.Substring(0, index);
            networkUrl = networkUrl + ":9696";
        }

        private void AssociateFloatingIP_Load(object sender, EventArgs e)
        {
            listFloatingIps();
            listPorts();
        }

        private void listPorts()
        {
            String address = "http://" + networkUrl + "/v2.0/ports";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", token);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            dynamic convertObj = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject ip in obj["ports"])
            {             
                    string port = convertObj.ports.fixed_ips.ip;
                    comboBoxPorts.Items.Add(port);           
            }
        }

        private void listFloatingIps()
        {
            String address = "http://" + networkUrl + "/v2.0/floatingips";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", token);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject ip in obj["floatingips"])
            {         
                    string floatingip = (string)ip["floating_ip_address"];
                    comboBoxFloatingIPs.Items.Add(floatingip);
            }
        }
    }
}
