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
    public partial class VolumeAdd : Form
    {
        private String url;
        private String projectId;
        private String token;
        ArrayList imageNames = new ArrayList();
        ArrayList imageIds = new ArrayList();
        private String imageId;

        public VolumeAdd(String url, String projectId, String token)
        {
            this.url = url;
            this.projectId = projectId;
            this.token = token;
            InitializeComponent();
        }

        private void VolumeAdd_Load(object sender, EventArgs e)
        {
            comboBoxVolumeSource.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            createVolume();
        }

        private void createVolume()
        {
            String name = textBoxVolumeName.Text;
            String description = richTextBoxVolumeDescription.Text;
            int size = (int)numericUpDownSize.Value;
            if (imageId != null)
            {
                var json = "{\"volume\":{\"size\":" + size + ",\"description\":" + "\"" + description + "\"" + ",\"name\":" + "\"" + name + "\"" + ",\"imageRef\":" + "\"" + imageId + "\"" + ",\"volume_type\":null}}";
                String address = "http://" + url + "/volume/v3/volumes";
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("X-Auth-Token", token);
                myWebClient.Headers.Add("Content-Type", "application/json");
                myWebClient.Headers.Add("User-Agent", "PostmanRuntime/7.29.0");
                myWebClient.Headers.Add("Accept","*/*");
                myWebClient.Headers.Add("Accept-Encoding","gzip,deflate,br");           
                var response = myWebClient.UploadString(address, json);
                MessageBox.Show("Volume criado");
                this.Close();
                
            }
            else
            {
                var json = "{\"volume\":{\"size\":" + size + ",\"description\":" + "\"" + description + "\"" + ",\"name\":" + "\"" + name + "\"" + ",\"volume_type\":null}}";
                String address = "http://" + url + "/volume/v3/volumes";
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("Content-Type", "application/json");
                myWebClient.Headers.Add("User-Agent", "PostmanRuntime/7.29.0");
                myWebClient.Headers.Add("Accept", "*/*");
                myWebClient.Headers.Add("Accept-Encoding", "gzip,deflate,br");
                myWebClient.Headers.Add("X-Auth-Token", token);         
                var response = myWebClient.UploadString(address, json);
                MessageBox.Show("Volume criado");
                this.Close();
            }

        }

        private void comboBoxVolumeSource_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if (comboBoxVolumeSource.SelectedIndex == 1)
            {
                label5.Visible = true;
                comboBoxImage.Visible = true;
                listImages();
            }
            else
            {
                label5.Visible = false;
                comboBoxImage.Visible = false;
            }
        }

        private void listImages()
        {
            String address = "http://" + url + "/image/v2/images";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", token);
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject image in obj["images"])
            {
                string imageName = (string)image["name"];
                comboBoxImage.Items.Add(imageName);
                imageNames.Add(imageName);
            }
            foreach (JObject image in obj["images"])
            {
                string imageId = (string)image["id"];
                imageIds.Add(imageId);
            }
            comboBoxImage.SelectedIndex = 0;
        }

        private void comboBoxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageId = imageIds[comboBoxImage.SelectedIndex].ToString();
        }
    }
}
