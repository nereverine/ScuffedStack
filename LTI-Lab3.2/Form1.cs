using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace LTI_Lab3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string? unAuthToken { get; private set; } //?????
        public string? responseString { get; private set; } //?????

        public string? responseString2 { get; private set; } //?????

        private void button1_Click(object sender, EventArgs e)
        {
            getResponseString();


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            getScopedToken();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // EXEMPLO DE UM PEDIDO POST DIRIGIDO AO API DO SERVIcO KEYSTONE (IDENTITY)

            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";


            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST

            String jsonToSend = "{\"auth\": {\"identity\": {\"methods\": [\"password\"],\"password\": {\"user\": {\"name\": \"admin\",\"domain\": {\"name\": \"Default\"},\"password\": \"devstack\"}}}}}";


            // ... PEDIDO POST AO API DO KEYSTONE

             responseString = myWebClient.UploadString("http://127.0.0.1/identity/v3/auth/tokens/", jsonToSend);


            // ... RETIRAR DOS HEADERS RECEBIDOS NA RESPOSTA O TOKEN

            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;

            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    unAuthToken = myWebHeaderCollection.Get(i); // GUARDAR O UNSCOPED TOKEN (APENAS UTILIZADO PARA AUTENTICAO E CRIAO DE SCOPED TOKENS), NaO PERMITE ACESSO AOS DETALHES DOS SERVIcOS
                }
            }


            //TAREFA 2
            var myWebClient2 = new WebClient();
            myWebClient2.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient2.Headers.Add("x-auth-token", "gAAAAABiNhTSL9aHqPAxXT4WhnetjtYmkaQ6ub3nCXYL0GgEiS9WVwMboPh_YzgcOvmdhicQiF40xsE3wCNaatc_gS_53yw6pfE44yY-paD9Of08DiOHtwtWbCYEmcmPeE9lYIn5f70B952YGdaIf7Y0kxtHM-pvetmGuLwNeVn6RL8L9Mpk9-s");

      //      responseString2 = myWebClient2.DownloadString("http://192.168.38.128/identity/v3/auth/projects");

        }

        private void getScopedToken()
        {
            MessageBox.Show(unAuthToken, "UnAuthToken");
        }
        private void getResponseString()
        {
            MessageBox.Show(responseString, "Json de resposta");
        }

        private void getUnscopedToken()
        {
            MessageBox.Show(responseString2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getUnscopedToken();
        }
    }


 
}

