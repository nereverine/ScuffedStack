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
        private string url;
        //Projects
        ArrayList projectIds = new ArrayList();
        ArrayList projectDetails = new ArrayList();
        private string projectId;
        //User credentials;
        private string userPassword;
        private string userId;
        //Tokens
        private string unAuthToken;
        private string authToken;
        //Instances
        ArrayList instanceIds = new ArrayList();
        ArrayList instanceNames = new ArrayList();

        

        public Main(String unAuthToken, String url, String userId, String password)
        {
            InitializeComponent();
            //label1.Text = unAuthToken;
            label1.Text = url;
            unscopedToken = unAuthToken;
            userPassword = password;
            this.userId = userId;
            this.unAuthToken = unAuthToken;
            this.url = url;

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
            //THIS IS CURRENTLY ONLY USED TO GET THE USER NAME
        {
            String url = "http://" + label1.Text + "/identity/v3/auth/tokens";
            String json = "{\"auth\":{\"identity\":{\"methods\":[\"token\"],\"token\":{\"id\":" + "\"" + unscopedToken + "\"" + "}},\"scope\":{\"system\":{\"all\":true}}}}";
            var myWebClient = new WebClient();
            responseString = myWebClient.UploadString(url, json);
            dynamic convertObj = JObject.Parse(responseString);
            user = convertObj.token.user.name;
            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;
            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                  authToken = myWebHeaderCollection.Get(i); 
                }
            }
        }

        private String GetScopedProject(String projectId)
        {
            String url = "http://" + label1.Text + "/identity/v3/auth/tokens";
            String json = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"id\":" + "\"" + userId + "\"" + ",\"password\":" + "\"" + userPassword + "\"" + "}}},\"scope\":{\"project\":{\"id\":" + "\"" + projectId + "\"" + "}}}}";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            String responseString = myWebClient.UploadString(url, json);
            String token = "";

            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;


            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    token = myWebHeaderCollection.Get(i); 
                }
            }
            return token;
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
            instanceNames.Clear();
            instanceIds.Clear();
            listBoxInstances.Items.Clear();
            groupBox2.Visible = true;
            labelNomeProj.Text = listBox1.SelectedItem.ToString();
            labelProjectId.Text = projectIds[listBox1.SelectedIndex].ToString();
            string details = projectDetails[listBox1.SelectedIndex].ToString(); 
    
            if (details == "")
            {
                labelProjectDetails.Text = "Este projeto não tem descrição";
            }
            else
            {
                labelProjectDetails.Text = details;
            }
            String projectScoped = GetScopedProject(labelProjectId.Text);
            GetProjectInstances(projectScoped);
            
        }

        private void GetProjectInstances(string projectScoped)
        {
            String url = "http://" + label1.Text + "/compute/v2.1/servers";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectScoped);          
            String responseString = myWebClient.DownloadString(url);

            var parsedObject = JObject.Parse(responseString);
            JObject obj = JsonConvert.DeserializeObject<JObject>(responseString);
            foreach (JObject projects in obj["servers"])
            {
                string instanceName = (string)projects["name"];
                listBoxInstances.Items.Add(instanceName);
                instanceNames.Add(instanceName);
            }
            foreach (JObject projects in obj["servers"])
            {
                string instanceId = (string)projects["id"];
                instanceIds.Add(instanceId);
            }
        }

        private void listBoxInstances_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxInstances.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de selecionar uma instancia primeiro!");
            }
            else
            {
                MessageBox.Show(instanceIds[listBoxInstances.SelectedIndex].ToString());
                manageInstance();
            }
        }

        private void manageInstance()
        {
            //this.Hide();
            var instanceManager = new InstanceManager(authToken, instanceIds[listBoxInstances.SelectedIndex].ToString(), url);
            //instanceManager.Closed += (s, args) => this.Close();
            instanceManager.Show();
        }
    }
}
