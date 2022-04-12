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
            this.buttonAssociateFloatingIP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstanceName
            // 
            this.labelInstanceName.AutoSize = true;
            this.labelInstanceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstanceName.Location = new System.Drawing.Point(360, 52);
            this.labelInstanceName.Name = "labelInstanceName";
            this.labelInstanceName.Size = new System.Drawing.Size(57, 21);
            this.labelInstanceName.TabIndex = 0;
            this.labelInstanceName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 9);
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
            this.groupBox1.Controls.Add(this.buttonAssociateFloatingIP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(169, 220);
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
            this.pictureBoxTurnOnOff.Location = new System.Drawing.Point(648, 31);
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
            this.progressBar1.Location = new System.Drawing.Point(623, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ligar/Desligar";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::LTI_Lab3._2.Properties.Resources.delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(648, 118);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(51, 42);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 10;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // buttonAssociateFloatingIP
            // 
            this.buttonAssociateFloatingIP.Location = new System.Drawing.Point(6, 155);
            this.buttonAssociateFloatingIP.Name = "buttonAssociateFloatingIP";
            this.buttonAssociateFloatingIP.Size = new System.Drawing.Size(126, 23);
            this.buttonAssociateFloatingIP.TabIndex = 1;
            this.buttonAssociateFloatingIP.Text = "Associar floating IP";
            this.buttonAssociateFloatingIP.UseVisualStyleBackColor = true;
            this.buttonAssociateFloatingIP.Click += new System.EventHandler(this.buttonAssociateFloatingIP_Click);
            // 
            // InstanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "InstanceManager";
            this.Text = "InstanceManager";
            this.Load += new System.EventHandler(this.InstanceManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
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
        private Button buttonAssociateFloatingIP;
    }
}