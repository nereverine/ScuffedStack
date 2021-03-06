namespace LTI_Lab3._2
{
    partial class InstanceManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceManager));
            this.labelInstanceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInstanceStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInstanceImage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAddresses = new System.Windows.Forms.ListBox();
            this.pictureBoxTurnOnOff = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameChange = new System.Windows.Forms.TextBox();
            this.buttonEditName = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstanceName
            // 
            this.labelInstanceName.AutoSize = true;
            this.labelInstanceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstanceName.Location = new System.Drawing.Point(214, 52);
            this.labelInstanceName.Name = "labelInstanceName";
            this.labelInstanceName.Size = new System.Drawing.Size(57, 21);
            this.labelInstanceName.TabIndex = 0;
            this.labelInstanceName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão de Instancia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // labelInstanceStatus
            // 
            this.labelInstanceStatus.AutoSize = true;
            this.labelInstanceStatus.Location = new System.Drawing.Point(77, 92);
            this.labelInstanceStatus.Name = "labelInstanceStatus";
            this.labelInstanceStatus.Size = new System.Drawing.Size(38, 15);
            this.labelInstanceStatus.TabIndex = 3;
            this.labelInstanceStatus.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagem:";
            // 
            // labelInstanceImage
            // 
            this.labelInstanceImage.AutoSize = true;
            this.labelInstanceImage.Location = new System.Drawing.Point(77, 118);
            this.labelInstanceImage.Name = "labelInstanceImage";
            this.labelInstanceImage.Size = new System.Drawing.Size(175, 15);
            this.labelInstanceImage.TabIndex = 5;
            this.labelInstanceImage.Text = "Imagem provém de um volume";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rede";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAddresses);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereços";
            // 
            // listBoxAddresses
            // 
            this.listBoxAddresses.FormattingEnabled = true;
            this.listBoxAddresses.ItemHeight = 15;
            this.listBoxAddresses.Location = new System.Drawing.Point(6, 15);
            this.listBoxAddresses.Name = "listBoxAddresses";
            this.listBoxAddresses.Size = new System.Drawing.Size(208, 49);
            this.listBoxAddresses.TabIndex = 0;
            // 
            // pictureBoxTurnOnOff
            // 
            this.pictureBoxTurnOnOff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTurnOnOff.Image")));
            this.pictureBoxTurnOnOff.Location = new System.Drawing.Point(408, 150);
            this.pictureBoxTurnOnOff.Name = "pictureBoxTurnOnOff";
            this.pictureBoxTurnOnOff.Size = new System.Drawing.Size(51, 42);
            this.pictureBoxTurnOnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTurnOnOff.TabIndex = 7;
            this.pictureBoxTurnOnOff.TabStop = false;
            this.pictureBoxTurnOnOff.Click += new System.EventHandler(this.pictureBoxTurnOnOff_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(383, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ligar/Desligar";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::LTI_Lab3._2.Properties.Resources.delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(408, 237);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(51, 42);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 10;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome:";
            // 
            // textBoxNameChange
            // 
            this.textBoxNameChange.Location = new System.Drawing.Point(77, 147);
            this.textBoxNameChange.Name = "textBoxNameChange";
            this.textBoxNameChange.Size = new System.Drawing.Size(100, 23);
            this.textBoxNameChange.TabIndex = 12;
            // 
            // buttonEditName
            // 
            this.buttonEditName.Location = new System.Drawing.Point(40, 176);
            this.buttonEditName.Name = "buttonEditName";
            this.buttonEditName.Size = new System.Drawing.Size(75, 23);
            this.buttonEditName.TabIndex = 13;
            this.buttonEditName.Text = "Alterar";
            this.buttonEditName.UseVisualStyleBackColor = true;
            this.buttonEditName.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LTI_Lab3._2.Properties.Resources.command_line;
            this.pictureBox1.Location = new System.Drawing.Point(339, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(339, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Abrir consola";
            // 
            // InstanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEditName);
            this.Controls.Add(this.textBoxNameChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoxTurnOnOff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelInstanceImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInstanceStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstanceName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstanceManager";
            this.Text = "Gestão de Instancia";
            this.Load += new System.EventHandler(this.InstanceManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInstanceName;
        private Label label1;
        private Label label2;
        private Label labelInstanceStatus;
        private Label label3;
        private Label labelInstanceImage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBoxAddresses;
        private PictureBox pictureBoxTurnOnOff;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label label4;
        private PictureBox pictureBoxDelete;
        private Label label5;
        private TextBox textBoxNameChange;
        private Button buttonEditName;
        private PictureBox pictureBox1;
        private Label label6;
    }
}