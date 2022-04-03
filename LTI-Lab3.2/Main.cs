using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections;

namespace LTI_Lab3._2
{
    public partial class Main : Form
    {
        private string unscopedToken;
        private string responseString;
        private string user;
        ArrayList projectIds = new ArrayList();
        ArrayList projectDetails = new ArrayList();

        public Main(String unAuthToken, String url)
        {
            InitializeComponent();
            //label1.Text = unAuthToken;
            label1.Text = url;
            unscopedToken = unAuthToken;

        }
        public void Main_Load(object sender, EventArgs e)
        { 
            GetScopedAuth();
            PopulateMenus();
        }

        private void PopulateMenus()
        {
            toolStripMenuItem1.Text = user;
            ListProjects();
        }

        private void ListProjects()
        {
            String url = "http://" + label1.Text + "/identity/v3/auth/projects";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", unscopedToken);
            var json = myWebClient.DownloadString(url);
            MessageBox.Show(json);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject projects in obj["projects"])
            {       
                    string projectName = (string)projects["name"];
                    listBox1.Items.Add(projectName);                  

            }
            foreach (JObject projects in obj["projects"])
            {
                string projectId = (string)projects["id"];
                projectIds.Add(projectId);
            }
            foreach (JObject projects in obj["projects"])
            {
                string projectDetail = (string)projects["description"];
                projectDetails.Add(projectDetail);
            }
        }

        private void GetScopedAuth()
        {
            String url = "http://" + label1.Text + "/identity/v3/auth/tokens";
            String json = "{\"auth\":{\"identity\":{\"methods\":[\"token\"],\"token\":{\"id\":" + "\"" + unscopedToken + "\"" + "}},\"scope\":{\"system\":{\"all\":true}}}}";
            var myWebClient = new WebClient();
            responseString = myWebClient.UploadString(url, json);
            dynamic convertObj = JObject.Parse(responseString);
            user = convertObj.token.user.name;
        }


        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            groupBox2.Visible = true;
            labelNomeProj.Text = listBox1.SelectedItem.ToString();
            labelProjectId.Text = projectIds[listBox1.SelectedIndex].ToString();
            string details = projectDetails[listBox1.SelectedIndex].ToString(); 
            if(details == "")
            {
                labelProjectDetails.Text = "Este projeto não tem descrição";
            }
            else
            {
                labelProjectDetails.Text = details;
            }
        }
    }
}
