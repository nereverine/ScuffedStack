using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

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
            labelInstanceName.Text = convertObj.server.name; //show instance name
            processInstanceStatus(convertObj.server.status);
            labelInstanceImage.Text = convertObj.server.image; //show instance image
            String toGetAddr = convertObj.server.addresses.ToString();
            MessageBox.Show(toGetAddr);
            JObject obj = JsonConvert.DeserializeObject<JObject>(toGetAddr);
            foreach (var x in obj)
            {
                string name = x.Key;              
                JToken value = x.Value;
                JEnumerable<JToken> results = value.Children();
                foreach (JToken result in results)
                {
                    var addr = result.Value<string>("addr");
                    var version = result.Value<string>("version");
                    listBoxAddresses.Items.Add("Rede:" + name + " IPv" + version + " : "+addr);
                }
            }
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
