using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
    public partial class InstanceAdd : Form
    {
        private String url;
        private String networkUrl;
        private String projectToken;
        private int counter;
        //flavors
        ArrayList flavorIds = new ArrayList();
        ArrayList allocatedFlavor = new ArrayList(); //could be a string
        //networks
        ArrayList networksIds = new ArrayList();
        //private List<String> subnets = new List<string> { };
        private JArray subnets = new JArray();
        ArrayList allocatedNetworks = new ArrayList();
        //images
        ArrayList imageIds = new ArrayList();
        ArrayList allocatedImage = new ArrayList(); //could be a string


        public InstanceAdd(String authToken, String url, String projectName, String projectToken)
        {
            InitializeComponent();
            textBoxProjectName.Text = projectName;
            this.url = url;
            this.projectToken = projectToken;
            int index = url.IndexOf(":");      
            if (index >= 0)
                networkUrl = url.Substring(0, index);
            networkUrl = networkUrl + ":9696";
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl1.Font, Brushes.Black, x, y);
        }

        private void InstanceAdd_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            listFalvors();
            listNetworks();
        }

        private void listFalvors()
        {
            String address = "http://" + url + "/compute/v2.1/flavors";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            
            foreach (JObject flavor in obj["flavors"])
            {
                string flavorName = (string)flavor["name"];
                listBoxAvailableFlavors.Items.Add(flavorName);
            }
            foreach (JObject flavor in obj["flavors"])
            {
                string flavorId = (string)flavor["id"];
                flavorIds.Add(flavorId);
            }

        }
        private void listNetworks()
        {
            String address = "http://" + networkUrl + "/v2.0/networks";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);

            foreach (JObject network in obj["networks"])
            {
                string networkName = (string)network["name"];
                listBoxAvailableNetworks.Items.Add(networkName);
            }
            foreach (JObject network in obj["networks"])
            {
                string flavorId = (string)network["id"];
                networksIds.Add(flavorId);
            }

        }

        private void listBoxAvailableFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFlavorDetails(flavorIds[listBoxAvailableFlavors.SelectedIndex].ToString());
        }

        private void getFlavorDetails(String flavorId)
        {
            groupBoxFlavorsDetails.Visible = true;
            String address = "http://" + url + "/compute/v2.1/flavors/"+flavorId;
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(json);
            labelFlavorName.Text = convertObj.flavor.name;
            labelRam.Text = convertObj.flavor.ram + "MB";
            labelDiskSize.Text = convertObj.flavor.disk.ToString() + "GB";
            labelVcpu.Text = convertObj.flavor.vcpus;

        }

        private void getNetworkDetails(String networkId)
        {
            groupBoxNetworkDetails.Visible = true;
            string address = "http://" + networkUrl + "/v2.0/networks/" + networkId;
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(json);
            labelNetworkName.Text = convertObj.network.name;
            if(convertObj.network.shared == "true")
            {
                labelIsShared.Text = "Sim";
            }
            else
            {
                labelIsShared.Text = "Nao";
            }
            labelStatus.Text = convertObj.network.status;
            subnets = convertObj.network.subnets;
            fillSubnetsBox();
            
        }

        private void fillSubnetsBox()
        {
            
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            foreach (String subnetId in subnets)
            {
                string address = "http://" + networkUrl + "/v2.0/subnets/" + subnetId;
                var json = myWebClient.DownloadString(address);
                dynamic convertObj = JObject.Parse(json);
                listBoxSubnets.Items.Add(convertObj.subnet.name);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2 || tabControl1.SelectedIndex == 3)
            {
                tabControl1.Size = new Size(600, 314);
                groupBoxFlavorsDetails.Visible = true;
                groupBoxNetworkDetails.Visible = true;
            }
            else
            {
                tabControl1.Size = new Size(482, 314);
            }
        }

        private void pictureBoxAddFlavor_Click(object sender, EventArgs e)
        {
            if (listBoxAllocatedFlavor.Items.Count == 0)
            {
                listBoxAllocatedFlavor.Items.Add(listBoxAvailableFlavors.SelectedItem);
                allocatedFlavor.Add(flavorIds[listBoxAvailableFlavors.SelectedIndex].ToString());
                
            }
            else
            {
                MessageBox.Show("Só pode adicionar um flavor!");
            }
            
        }

        private void pictureBoxRemoveFlavor_Click(object sender, EventArgs e)
        { 
            allocatedFlavor.Clear();
            listBoxAllocatedFlavor.Items.Remove(listBoxAllocatedFlavor.SelectedItem);
        }

        private void listBoxAvailableNetworks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSubnets.Items.Clear();
            if (subnets.Count > 0)
            {
                subnets.Clear();
            }
            getNetworkDetails(networksIds[listBoxAvailableNetworks.SelectedIndex].ToString());
        }

        private void pictureBoxRemoveNetwork_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxAddNetwork_Click(object sender, EventArgs e)
        {
            if(allocatedNetworks.Count > 0)
            {
                foreach (String network in listBoxAllocatedNetworks.Items)
                {

                    if(listBoxAvailableNetworks.SelectedItem == network)
                    {
                        MessageBox.Show("Rede já adicionada!");
                        return;
                    }
                }
            }
            listBoxAllocatedNetworks.Items.Add(listBoxAvailableNetworks.SelectedItem);
            allocatedNetworks.Add(networksIds[listBoxAvailableNetworks.SelectedIndex].ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Imagem")
            {
                listImages();
            }
        }

        private void listImages()
        {
            String address = "http://" + url + "/image/v2/images";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject image in obj["images"])
            {
                string imageName = (string)image["name"];
                listBoxAvailable.Items.Add(imageName);
            }
            foreach (JObject image in obj["images"])
            {
                string flavorId = (string)image["id"];
                imageIds.Add(flavorId);
            }
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
             if (listBoxAllocated.Items.Count == 0)
            {
                listBoxAllocated.Items.Add(listBoxAvailable.SelectedItem);
                allocatedImage.Add(imageIds[listBoxAvailable.SelectedIndex].ToString());

            }
            else
            {
                MessageBox.Show("Só pode adicionar uma imagem!");
            }
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            allocatedImage.Clear();
            listBoxAllocated.Items.Remove(listBoxAllocated.SelectedItem);
        }

        private void pictureBoxCreate_Click(object sender, EventArgs e)
        {
            if (textBoxInstanceName.Text == "")
            {
                MessageBox.Show("Não inseriu nome!");
            }
            else if (allocatedImage.Count == 0)
            {
                MessageBox.Show("Não selecionou imagem!");
            }
            else if (allocatedFlavor.Count == 0)
            {
                MessageBox.Show("Não selecionou um Flavor!");
            }
            else if (allocatedNetworks.Count == 0)
            {
                MessageBox.Show("Não selecionou as redes!");
            }
            else
            {
                createInstance();
            }
        }

        private String networksStringBuilder()
        {
            String networks = "";
            if(allocatedNetworks.Count == 1)
            {
                networks = "networks\":[{\"uuid\":" + "\"" + allocatedNetworks[0] + "\"" + "}]";
                return networks;
            }
            else
            {
                networks = "networks\":[ ";
                //foreach(String network in allocatedNetworks)
                //{
                //networks = networks + "\"uuid\":" + "\"" + network + "\",";
                //}
                for (int i = 0; i < allocatedNetworks.Count; i++)
                {
                    if (i == allocatedNetworks.Count - 1)
                    {
                        networks = networks + "{\"uuid\":" + "\"" + allocatedNetworks[i] + "\"}";
                    }
                    else
                    networks = networks + "{\"uuid\":" + "\"" + allocatedNetworks[0] + "\"},";
                }
                //networks = networks + allocatedNetworks[0] + "\"" + "}]";
                networks = networks  + "]";
                return networks;
            }
        }

        private void createInstance()
        {
            counter = 12;
            String address = "http://" + url + "/compute/v2.1/servers";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectToken);
            var json = "{\"server\":{\"name\":" + "\"" + textBoxInstanceName.Text + "\"" + ",\"flavorRef\":" + "\"" + allocatedFlavor[0] + "\"" + ",\"imageRef\":" + "\"" + allocatedImage[0] + "\"" + ",\"min_count\":" + "\"1" + "\"" +",\"max_count\":" + "\"" + numericUpDownCount.Value  + "\"" + ",\"" + networksStringBuilder() + "}}";
            this.Hide();
            var progressBarForm = new ProgressBarForm();
            progressBarForm.Show();
            timer1.Start();
            var response = myWebClient.UploadString(address, json);

        }

        private void formValidator()
        {
            if(textBoxInstanceName.Text == "")
            {
                MessageBox.Show("Não inseriu nome!");
            }
            else if(allocatedImage.Count == 0)
            {
                MessageBox.Show("Não selecionou imagem!");
            }
            else if(allocatedFlavor.Count == 0)
            {
                MessageBox.Show("Não selecionou um Flavor!");
            }
            else if(allocatedNetworks.Count == 0)
            {
                MessageBox.Show("Não selecionou as redes!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(counter == 0)
            {
                this.Show();
                timer1.Stop();
                this.Close();
            }
            else
            {
                this.Hide();
            }
            counter--;
        }
    }
}
