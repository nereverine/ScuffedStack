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
        private String projectToken;
        //flavors
        ArrayList flavorIds = new ArrayList();
        ArrayList allocatedFlavor = new ArrayList(); //could be a string
        public InstanceAdd(String authToken, String url, String projectName, String projectToken)
        {
            InitializeComponent();
            textBoxProjectName.Text = projectName;
            this.url = url;
            this.projectToken = projectToken;

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
            listFalvors();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2 || tabControl1.SelectedIndex == 3)
            {
                tabControl1.Size = new Size(600, 314);
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
            MessageBox.Show(allocatedFlavor[0].ToString());
            allocatedFlavor.Clear();
            listBoxAllocatedFlavor.Items.Remove(listBoxAllocatedFlavor.SelectedItem);
        }
    }
}
