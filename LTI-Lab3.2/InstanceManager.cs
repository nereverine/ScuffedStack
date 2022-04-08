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
        int counter=10;
        public InstanceManager(String authToken, String instanceId, String url)
        {
            InitializeComponent();
            progressBar1.Visible = false;
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

        private void pictureBoxTurnOnOff_Click(object sender, EventArgs e)
        {
            turnOnOffInstance();
        }

        private void turnOnOffInstance()
        {
            if(labelInstanceStatus.Text == "ACTIVE")
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende desligar a instancia?", "Desligar a instancia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //ligar a vm
                    String address = "http://" + url + "/compute/v2.1/servers/" + instanceId + "/action";
                    var myWebClient = new WebClient();
                    myWebClient.Headers.Add("X-Auth-Token", authToken);
                    String json = "{\"os-stop\":null}";
                    myWebClient.UploadString(address, json);
                    progressBar1.Visible = true;
                    //getInstanceDetails(instanceId);
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else if(labelInstanceStatus.Text == "SHUTOFF")
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ligar a instancia?", "Ligar a instancia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //desligar a vm
                    String address = "http://" + url + "/compute/v2.1/servers/" + instanceId + "/action";
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("X-Auth-Token", authToken);
                String json = "{\"os-start\":null}";
                myWebClient.UploadString(address, json);
                progressBar1.Visible = true;
                //getInstanceDetails(instanceId);
                timer1.Interval = 1000;
                timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value+=10;
            }
            else
            {
                progressBar1.Value=0;
                progressBar1.Visible = false;
                timer1.Stop();
                getInstanceDetails(instanceId);
            }
        }
    }
    }

