using Newtonsoft.Json.Linq;
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
    public partial class ImageAdd : Form
    {
        private int counter;
        private String url;
        private String token;
        private String imageId;
        private String file;
        public ImageAdd(String url, String token)
        {
            InitializeComponent();
            this.url = url;
            this.token = token;
        }

        private void radioButtonPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPrivate.Checked == true)
            {
                radioButtonPublic.Checked = false;
                radioButtonShared.Checked = false;
            }
            else if(radioButtonPublic.Checked == true)
            {
                radioButtonPrivate.Checked = false;
                radioButtonShared.Checked = false;
            }
            else
            {
                radioButtonPublic.Checked = false;
                radioButtonPrivate.Checked = false;
            }

            if(radioButtonNo.Checked == true)
            {
                radioButtonYes.Checked = false;
            }
            else
            {
                radioButtonYes.Checked = true;
            }
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxImageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxImageFile.Text = openFileDialog1.FileName;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (formValidator() == true)
            {
                imageCreator();
            }
        }

        private void imageCreator()
        {
            String name;
            String description="";
            String format = "";
            String visibility = "";
            file = textBoxImageFile.Text;
            bool isProtected;
            int min_disk = (int)numericUpDownDisk.Value;
            int min_ram = (int)numericUpDownRam.Value;


            name = textBoxImageName.Text;
            switch (comboBoxImageFormat.SelectedIndex)
            {
                case 0:
                    format = "iso";
                break;

                case 1:
                    format = "ploop";
                break;

                case 2:
                    format = "qcow2";
                    break;

                case 3:
                    format = "raw";
                    break;

                case 4:
                    format = "vdi";
                    break;

                case 5:
                    format = "vhd";
                    break;

                case 6:
                    format = "vmdk";
                    break;

                case 7:
                    format = "aki";
                    break;

                case 8:
                    format = "ami";
                    break;

                case 9: format = "ari";
                    break;
            }

            if(textBoxImageDescription.Text != "")
            {
                description = textBoxImageDescription.Text;
            }

            if(radioButtonPrivate.Checked == true)
            {
                visibility = "private";
            }else if(radioButtonPublic.Checked == true)
            {
                visibility = "public";
            }
            else if(radioButtonShared.Checked == true)
            {
                visibility = "shared";
            }

            if(radioButtonNo.Checked == true)
            {
                isProtected = false;
            }
            else
            {
                isProtected = true;
            }

            counter = 12;
            timer1.Interval = 1000;
            String address = "http://" + url + "/image/v2/images";
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", token);
            var json = "{\"disk_format\":" + "\"" + format + "\"" + ",\"name\":" + "\"" + name + "\"" + ",\"min_disk\":" + min_disk  + ",\"min_ram\":" + min_ram   + ",\"visibility\":" + "\"" + visibility + "\"" + ",\"description\":" + "\"" + description + "\"" + ",\"protected\":" + isProtected.ToString().ToLower() + ",\"container_format\":" + "\"bare\"}";
            //this.Hide();
            //var progressBarForm = new ProgressBarForm();
            //progressBarForm.Show();
            timer1.Start();
            var progressForm = new ProgressBarForm();
            progressForm.ShowDialog();
            this.Hide();
            var response = myWebClient.UploadString(address, json);
            dynamic convertObj = JObject.Parse(response);
            
            imageId = convertObj.id;          
        }

        private void uploadFile()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", token);
            myWebClient.Headers.Set("Content-Type", "application/octet-stream");
            String address2 = "http://" + url + "/image/v2/images/" + imageId + "/file";
            byte[] data = File.ReadAllBytes(file);
            myWebClient.UploadData(address2, "PUT", data);
        }

        private bool formValidator()
        {
            if (textBoxImageName.Text == "")
            {
                MessageBox.Show("Insira um nome para a imagem");
                return false;
            }
            else if (textBoxImageFile.Text == "")
            {
                MessageBox.Show("Selecione o ficheiro para a imagem");
                return false;
            }
            else if (comboBoxImageFormat.Text == "")
            {
                MessageBox.Show("Selecione o formato da imagem");
                return false;
            }
            else
                return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter != 0)
            {

                counter--;
            }
            else
            {
                timer1.Stop();
                uploadFile();
                MessageBox.Show(textBoxImageName.Text + " criada com sucesso!");       
                this.Close();
            }
        }
    }
}
