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
        //Images
        ArrayList imageIds = new ArrayList();
        ArrayList imageNames = new ArrayList();
        

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
            imageNames.Clear();
            instanceIds.Clear();
            
            listBoxInstances.Items.Clear();
            listBoxImages.Items.Clear();
            pictureBox1.Visible = false;
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
            GetProjectImages(projectScoped);
            
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
        private void GetProjectImages(String projectScoped)
        {
            String address = "http://" + url + "/image/v2/images";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectScoped) ;
            var json = myWebClient.DownloadString(address);
            var parsedObject = JObject.Parse(json);
            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject image in obj["images"])
            {
                string imageName = (string)image["name"];
                listBoxImages.Items.Add(imageName);
                imageNames.Add(imageName);
            }           
            foreach (JObject image in obj["images"])
            {
                string imageId = (string)image["id"];
                imageIds.Add(imageId);
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

        private void button2_Click(object sender, EventArgs e)
        {
            String projectScoped = GetScopedProject(labelProjectId.Text);
            //this.Hide();
            var instanceAdd = new InstanceAdd(authToken, url, listBox1.SelectedItem.ToString(), projectScoped);
            //instanceManager.Closed += (s, args) => this.Close();
            instanceAdd.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            String projectScoped = GetScopedProject(labelProjectId.Text);
            var imageAdd = new ImageAdd(url, projectScoped);
            //instanceManager.Closed += (s, args) => this.Close();
            imageAdd.Show();
        }

        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            if(listBoxImages.SelectedItem == null)
            {
                MessageBox.Show("Selecione a imagem a remover!");
            }
            else
            {

                String imageName = imageNames[listBoxImages.SelectedIndex].ToString();
                String imageId = imageIds[listBoxImages.SelectedIndex].ToString();
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende eliminar " + imageNames[listBoxImages.SelectedIndex], "Remover?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    imageRemove(imageId);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void imageRemove(string imageId)
        {
            if (isProtected(imageId) == true)
            {
                MessageBox.Show("A imagem está protegida, nao pode ser removida!");
            }
            else
            {
                String projectScoped = GetScopedProject(labelProjectId.Text);
                String address = "http://" + url + "/image/v2/images/" + imageId;
                var request = WebRequest.Create(address);
                request.Headers.Add("X-Auth-Token", projectScoped);
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();
            }
        }

        private bool isProtected(String imageId)
        {
            
            String projectScoped = GetScopedProject(labelProjectId.Text);
            String address = "http://" + url + "/image/v2/images/" + imageId;
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", projectScoped);
            var json = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(json);
            MessageBox.Show(json);
            if(convertObj.@protected == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            

        }
    }
}
