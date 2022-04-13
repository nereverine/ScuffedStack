namespace LTI_Lab3._2
{
    partial class ImageAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImageDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxImageFormat = new System.Windows.Forms.ComboBox();
            this.textBoxImageFile = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownRam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDisk = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonPublic = new System.Windows.Forms.RadioButton();
            this.radioButtonShared = new System.Windows.Forms.RadioButton();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisk)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxImageName
            // 
            this.textBoxImageName.Location = new System.Drawing.Point(6, 63);
            this.textBoxImageName.Name = "textBoxImageName";
            this.textBoxImageName.Size = new System.Drawing.Size(175, 39);
            this.textBoxImageName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxImageDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxImageName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // textBoxImageDescription
            // 
            this.textBoxImageDescription.Location = new System.Drawing.Point(6, 143);
            this.textBoxImageDescription.Name = "textBoxImageDescription";
            this.textBoxImageDescription.Size = new System.Drawing.Size(175, 39);
            this.textBoxImageDescription.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxImageFormat);
            this.groupBox2.Controls.Add(this.textBoxImageFile);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origem da Imagem";
            // 
            // comboBoxImageFormat
            // 
            this.comboBoxImageFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxImageFormat.FormattingEnabled = true;
            this.comboBoxImageFormat.Items.AddRange(new object[] {
            "ISO - Optical Disk Image",
            "PLOOP - Virtuozzo/Parallels Loopback Disk",
            "QCOW2 - QEMU Emulator",
            "Raw",
            "VDI - Virtual Disk Image",
            "VHD - Virtual Hard Disk",
            "VMDK - Virtual Machine Disk",
            "AKI - Amazon Kernel Image",
            "AMI - Amazon Machine Image",
            "ARI - Amazon Ramdisk Image"});
            this.comboBoxImageFormat.Location = new System.Drawing.Point(6, 151);
            this.comboBoxImageFormat.Name = "comboBoxImageFormat";
            this.comboBoxImageFormat.Size = new System.Drawing.Size(175, 23);
            this.comboBoxImageFormat.TabIndex = 6;
            this.comboBoxImageFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxImageFormat_SelectedIndexChanged);
            // 
            // textBoxImageFile
            // 
            this.textBoxImageFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImageFile.Location = new System.Drawing.Point(26, 63);
            this.textBoxImageFile.Name = "textBoxImageFile";
            this.textBoxImageFile.ReadOnly = true;
            this.textBoxImageFile.Size = new System.Drawing.Size(137, 23);
            this.textBoxImageFile.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ficheiro:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Title = "Selecionar Ficheiro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownRam);
            this.groupBox3.Controls.Add(this.numericUpDownDisk);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 197);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requisitos da Imagem";
            // 
            // numericUpDownRam
            // 
            this.numericUpDownRam.Location = new System.Drawing.Point(6, 143);
            this.numericUpDownRam.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownRam.Name = "numericUpDownRam";
            this.numericUpDownRam.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownRam.TabIndex = 4;
            // 
            // numericUpDownDisk
            // 
            this.numericUpDownDisk.Location = new System.Drawing.Point(6, 63);
            this.numericUpDownDisk.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownDisk.Name = "numericUpDownDisk";
            this.numericUpDownDisk.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownDisk.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Minimo de RAM(MB):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Minimo de Disco(GB):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(297, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 197);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Partilha da Imagem";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonNo);
            this.groupBox6.Controls.Add(this.radioButtonYes);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(16, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 67);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Protegida?";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNo.Location = new System.Drawing.Point(110, 28);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(65, 29);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Nao";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(16, 28);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(61, 29);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Sim";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonPublic);
            this.groupBox5.Controls.Add(this.radioButtonShared);
            this.groupBox5.Controls.Add(this.radioButtonPrivate);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(16, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 67);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visibilidade";
            // 
            // radioButtonPublic
            // 
            this.radioButtonPublic.AutoSize = true;
            this.radioButtonPublic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPublic.Location = new System.Drawing.Point(133, 29);
            this.radioButtonPublic.Name = "radioButtonPublic";
            this.radioButtonPublic.Size = new System.Drawing.Size(58, 19);
            this.radioButtonPublic.TabIndex = 2;
            this.radioButtonPublic.TabStop = true;
            this.radioButtonPublic.Text = "Public";
            this.radioButtonPublic.UseVisualStyleBackColor = true;
            this.radioButtonPublic.CheckedChanged += new System.EventHandler(this.radioButtonPrivate_CheckedChanged);
            // 
            // radioButtonShared
            // 
            this.radioButtonShared.AutoSize = true;
            this.radioButtonShared.Checked = true;
            this.radioButtonShared.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonShared.Location = new System.Drawing.Point(66, 29);
            this.radioButtonShared.Name = "radioButtonShared";
            this.radioButtonShared.Size = new System.Drawing.Size(61, 19);
            this.radioButtonShared.TabIndex = 1;
            this.radioButtonShared.TabStop = true;
            this.radioButtonShared.Text = "Shared";
            this.radioButtonShared.UseVisualStyleBackColor = true;
            this.radioButtonShared.CheckedChanged += new System.EventHandler(this.radioButtonPrivate_CheckedChanged);
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPrivate.Location = new System.Drawing.Point(6, 29);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(61, 19);
            this.radioButtonPrivate.TabIndex = 0;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            this.radioButtonPrivate.CheckedChanged += new System.EventHandler(this.radioButtonPrivate_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(568, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LTI_Lab3._2.Properties.Resources.ScuffedStack;
            this.pictureBox3.Location = new System.Drawing.Point(568, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // ImageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 433);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisk)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBoxImageName;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBoxImageDescription;
        private GroupBox groupBox2;
        private ComboBox comboBoxImageFormat;
        private TextBox textBoxImageFile;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDownRam;
        private NumericUpDown numericUpDownDisk;
        private Label label5;
        private Label label6;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private GroupBox groupBox5;
        private RadioButton radioButtonPublic;
        private RadioButton radioButtonShared;
        private RadioButton radioButtonPrivate;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
    }
}