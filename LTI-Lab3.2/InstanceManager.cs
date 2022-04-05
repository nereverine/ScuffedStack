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
    public partial class InstanceManager : Form
    {
        private string authToken;
        private string instanceId;
        private string url;
        public InstanceManager(String authToken, String instanceId, String url)
        {
            InitializeComponent();
            this.authToken = authToken;
            this.instanceId = instanceId;
            this.url = url;
        }

        private void InstanceManager_Load(object sender, EventArgs e)
        {
            getInstanceDetails(instanceId);

        }

        private void getInstanceDetails(string instanceId)
        {
            String address = "http://" + url + "/compute/v2.1/servers/" + instanceId;
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            String responseString = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(responseString);
            labelInstanceName.Text = convertObj.server.name;
            processInstanceStatus(convertObj.server.status);
            labelInstanceImage.Text = convertObj.server.image;

        }

        private void processInstanceStatus(dynamic status)
        {
            labelInstanceStatus.Text = status;
            if(status == "ACTIVE")
            {
                labelInstanceStatus.ForeColor = Color.Green;
            }
            else
            {
                labelInstanceStatus.ForeColor = Color.Red;
            }

        }
    }
}
