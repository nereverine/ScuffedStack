using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTI_Lab3._2
{
    public partial class ImageAdd : Form
    {
        public ImageAdd()
        {
            InitializeComponent();
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
            MessageBox.Show(comboBoxImageFormat.SelectedIndex.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxImageFile.Text = openFileDialog1.FileName;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formValidator();
        }

        private void formValidator()
        {
            throw new NotImplementedException();
        }
    }
}
