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
    public partial class ConsoleViewer : Form
    {
        private String instanceId;
        private String authToken;
        private String url;
        private String consoleLink;
        public ConsoleViewer(String instanceId, String authToken, String address)
        {
            InitializeComponent();
            this.instanceId = instanceId;
            this.authToken = authToken;
            this.url = address;
        }

        private void ConsoleViewer_Load(object sender, EventArgs e)
        {
            consoleLink = getConsoleLink();
            int pFrom = consoleLink.IndexOf("http://") + "http://".Length;
            int pTo = consoleLink.LastIndexOf("/");
            String resultString = consoleLink.Substring(pTo, consoleLink.Length-pTo);
            String ip = url.Split(':')[0];
            String combined = "http://" + ip + ":6080" + resultString;
            webView21.Source = new System.Uri(combined);
        }

        private String getConsoleLink()
        {
            String address = "http://" + url + "/compute/v2.1/servers/" + instanceId + "/action";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            String json = "{\"os-getVNCConsole\":{\"type\":\"novnc\"}}";
            var response = myWebClient.UploadString(address, json);
            dynamic convertObj = JObject.Parse(response);
            return convertObj.console.url;
        }
    }
}
