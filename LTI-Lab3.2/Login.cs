using System;
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
    public partial class Login : Form
    {
        private string responseString;

        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Verificacao();
            login();
        }

        private void Verificacao()
        {
            if (textBoxEndereco.Text == "")
            {
                MessageBox.Show("Tem de inserir o endereço!", "Erro");
            }
            else if (textBoxPorto.Text == "")
            {
                MessageBox.Show("Tem de inserir o porto!", "Erro");
            }
            else if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Tem de inserir o seu username!", "Erro");
            }
            else if (maskedTextBoxPassword.Text == "")
            {
                MessageBox.Show("Tem de inserir a sua password!", "Erro");
            }
        }
        public string unAuthToken { get; private set; } //?????
        public void login()
        {
            String endereco = textBoxEndereco.Text + ":" + textBoxPorto.Text;
            String username = textBoxUsername.Text;
            String password = maskedTextBoxPassword.Text;
            String url = "http://" + endereco + "/identity/v3/auth/tokens/";
            String json = "{\"auth\": {\"identity\": {\"methods\": [\"password\"],\"password\": {\"user\": {\"name\": " + "\"" + username + "\"" + ",\"domain\": {\"name\": \"Default\"},\"password\":" + "\"" + password + "\"" + "}}}}}";
            var myWebClient = new WebClient();

            try
            {

                responseString = myWebClient.UploadString(url, json);
                WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;
                

                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                    {
                        unAuthToken = myWebHeaderCollection.Get(i); // GUARDAR O UNSCOPED TOKEN (APENAS UTILIZADO PARA AUTENTICA��O E CRIA��O DE SCOPED TOKENS), N�O PERMITE ACESSO AOS DETALHES DOS SERVI�OS
                    }
                }
                //MessageBox.Show(unAuthToken);
                this.Hide();
                var main = new Main(unAuthToken, endereco);
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            catch (WebException ex)
            {
                // failed...
                if(ex.Response == null)
                {
                    MessageBox.Show("Nao foi possivel conectar a "+textBoxEndereco.Text);
                    return;
                }
                using (StreamReader r = new StreamReader(
                    ex.Response.GetResponseStream()))
           

                {
                    string responseContent = r.ReadToEnd();
                    if (((HttpWebResponse)ex.Response).StatusCode.ToString() == "Unauthorized")
                    {
                        MessageBox.Show("Credenciais Incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}


