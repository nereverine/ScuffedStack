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

namespace LTI_Lab3._2
{
    public partial class Main : Form
    {
        private string unscopedToken;
        private string responseString;
        private string user;

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
            //dynamic dynJson = JsonConvert.DeserializeObject(json);
            //foreach (var projects in dynJson)
            //{
            //  listBox1.Items.Add(projects);
            //}
            var parsedObject = JObject.Parse(json);
            //var projects = parsedObject["projects"][0]["name"].ToString();

            JObject obj = JsonConvert.DeserializeObject<JObject>(json);
            foreach (JObject projects in obj["projects"])
            {          
                    string projectName = (string)projects["name"];
                listBox1.Items.Add(projectName);
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
    }
}
