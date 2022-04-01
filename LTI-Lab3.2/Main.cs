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
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            toolStripMenuItem1.Text = user;
        }

        private void GetScopedAuth()
        {
            String url = "http://" + label1.Text + "/identity/v3/auth/tokens";
            MessageBox.Show(url);
            String json = "{\"auth\":{\"identity\":{\"methods\":[\"token\"],\"token\":{\"id\":" + "\"" + unscopedToken + "\"" + "}},\"scope\":{\"system\":{\"all\":true}}}}";
            var myWebClient = new WebClient();
            responseString = myWebClient.UploadString(url, json);
            dynamic convertObj = JObject.Parse(responseString);
            user = convertObj.token.user.name;
        }
    }
}
