﻿namespace LTI_Lab3._2
{
    partial class InstanceAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceAdd));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInstanceDescription = new System.Windows.Forms.TextBox();
            this.textBoxInstanceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAllocated = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxCreateVolume = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxAddFlavor = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemoveFlavor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxAvailableFlavors = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxAllocatedFlavor = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBoxAddNetwork = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemoveNetwork = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxAvailableNetworks = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxAllocatedNetworks = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFlavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveFlavor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveNetwork)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 100);
            this.tabControl1.Location = new System.Drawing.Point(79, 99);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 314);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.numericUpDownCount);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxInstanceDescription);
            this.tabPage1.Controls.Add(this.textBoxInstanceName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxProjectName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalhes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Insira o nome da Instancia e a quantidade a criar.";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(16, 260);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCount.TabIndex = 7;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição";
            // 
            // textBoxInstanceDescription
            // 
            this.textBoxInstanceDescription.Location = new System.Drawing.Point(16, 195);
            this.textBoxInstanceDescription.Name = "textBoxInstanceDescription";
            this.textBoxInstanceDescription.Size = new System.Drawing.Size(141, 23);
            this.textBoxInstanceDescription.TabIndex = 4;
            // 
            // textBoxInstanceName
            // 
            this.textBoxInstanceName.Location = new System.Drawing.Point(16, 132);
            this.textBoxInstanceName.Name = "textBoxInstanceName";
            this.textBoxInstanceName.Size = new System.Drawing.Size(141, 23);
            this.textBoxInstanceName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome da Instancia";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(16, 72);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.ReadOnly = true;
            this.textBoxProjectName.Size = new System.Drawing.Size(141, 23);
            this.textBoxProjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Projeto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBoxCreateVolume);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Origem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Selecione a imagem de template para a Instancia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAvailable);
            this.groupBox2.Location = new System.Drawing.Point(219, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponivel:";
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 15;
            this.listBoxAvailable.Location = new System.Drawing.Point(16, 22);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.Size = new System.Drawing.Size(94, 64);
            this.listBoxAvailable.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAllocated);
            this.groupBox1.Location = new System.Drawing.Point(27, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alocado:";
            // 
            // listBoxAllocated
            // 
            this.listBoxAllocated.FormattingEnabled = true;
            this.listBoxAllocated.ItemHeight = 15;
            this.listBoxAllocated.Location = new System.Drawing.Point(16, 22);
            this.listBoxAllocated.Name = "listBoxAllocated";
            this.listBoxAllocated.Size = new System.Drawing.Size(94, 64);
            this.listBoxAllocated.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 134);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tamanho do Volume (GB)";
            // 
            // checkBoxCreateVolume
            // 
            this.checkBoxCreateVolume.AutoSize = true;
            this.checkBoxCreateVolume.Location = new System.Drawing.Point(242, 77);
            this.checkBoxCreateVolume.Name = "checkBoxCreateVolume";
            this.checkBoxCreateVolume.Size = new System.Drawing.Size(129, 19);
            this.checkBoxCreateVolume.TabIndex = 4;
            this.checkBoxCreateVolume.Text = "Criar novo volume?";
            this.checkBoxCreateVolume.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Image"});
            this.comboBox1.Location = new System.Drawing.Point(22, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origem do Boot";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxAddFlavor);
            this.tabPage3.Controls.Add(this.pictureBoxRemoveFlavor);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(374, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Flavor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAddFlavor
            // 
            this.pictureBoxAddFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddFlavor.Image")));
            this.pictureBoxAddFlavor.Location = new System.Drawing.Point(327, 280);
            this.pictureBoxAddFlavor.Name = "pictureBoxAddFlavor";
            this.pictureBoxAddFlavor.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxAddFlavor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddFlavor.TabIndex = 4;
            this.pictureBoxAddFlavor.TabStop = false;
            // 
            // pictureBoxRemoveFlavor
            // 
            this.pictureBoxRemoveFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemoveFlavor.Image")));
            this.pictureBoxRemoveFlavor.Location = new System.Drawing.Point(327, 141);
            this.pictureBoxRemoveFlavor.Name = "pictureBoxRemoveFlavor";
            this.pictureBoxRemoveFlavor.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxRemoveFlavor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemoveFlavor.TabIndex = 3;
            this.pictureBoxRemoveFlavor.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Flavors afetam fatores como por exemplo a memoria ou os VCPUs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxAvailableFlavors);
            this.groupBox4.Location = new System.Drawing.Point(9, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 109);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flavors Disponiveis";
            // 
            // listBoxAvailableFlavors
            // 
            this.listBoxAvailableFlavors.FormattingEnabled = true;
            this.listBoxAvailableFlavors.ItemHeight = 15;
            this.listBoxAvailableFlavors.Location = new System.Drawing.Point(6, 22);
            this.listBoxAvailableFlavors.Name = "listBoxAvailableFlavors";
            this.listBoxAvailableFlavors.Size = new System.Drawing.Size(341, 79);
            this.listBoxAvailableFlavors.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxAllocatedFlavor);
            this.groupBox3.Location = new System.Drawing.Point(6, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 70);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alocado";
            // 
            // listBoxAllocatedFlavor
            // 
            this.listBoxAllocatedFlavor.FormattingEnabled = true;
            this.listBoxAllocatedFlavor.ItemHeight = 15;
            this.listBoxAllocatedFlavor.Location = new System.Drawing.Point(6, 26);
            this.listBoxAllocatedFlavor.Name = "listBoxAllocatedFlavor";
            this.listBoxAllocatedFlavor.Size = new System.Drawing.Size(341, 34);
            this.listBoxAllocatedFlavor.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBoxAddNetwork);
            this.tabPage4.Controls.Add(this.pictureBoxRemoveNetwork);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(104, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(374, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rede";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAddNetwork
            // 
            this.pictureBoxAddNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddNetwork.Image")));
            this.pictureBoxAddNetwork.Location = new System.Drawing.Point(326, 277);
            this.pictureBoxAddNetwork.Name = "pictureBoxAddNetwork";
            this.pictureBoxAddNetwork.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxAddNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddNetwork.TabIndex = 5;
            this.pictureBoxAddNetwork.TabStop = false;
            // 
            // pictureBoxRemoveNetwork
            // 
            this.pictureBoxRemoveNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemoveNetwork.Image")));
            this.pictureBoxRemoveNetwork.Location = new System.Drawing.Point(326, 133);
            this.pictureBoxRemoveNetwork.Name = "pictureBoxRemoveNetwork";
            this.pictureBoxRemoveNetwork.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxRemoveNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemoveNetwork.TabIndex = 4;
            this.pictureBoxRemoveNetwork.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxAvailableNetworks);
            this.groupBox6.Location = new System.Drawing.Point(6, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(362, 109);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flavors Disponiveis";
            // 
            // listBoxAvailableNetworks
            // 
            this.listBoxAvailableNetworks.FormattingEnabled = true;
            this.listBoxAvailableNetworks.ItemHeight = 15;
            this.listBoxAvailableNetworks.Location = new System.Drawing.Point(16, 22);
            this.listBoxAvailableNetworks.Name = "listBoxAvailableNetworks";
            this.listBoxAvailableNetworks.Size = new System.Drawing.Size(330, 79);
            this.listBoxAvailableNetworks.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxAllocatedNetworks);
            this.groupBox5.Location = new System.Drawing.Point(6, 49);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 78);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alocado";
            // 
            // listBoxAllocatedNetworks
            // 
            this.listBoxAllocatedNetworks.FormattingEnabled = true;
            this.listBoxAllocatedNetworks.ItemHeight = 15;
            this.listBoxAllocatedNetworks.Location = new System.Drawing.Point(16, 38);
            this.listBoxAllocatedNetworks.Name = "listBoxAllocatedNetworks";
            this.listBoxAllocatedNetworks.Size = new System.Drawing.Size(330, 34);
            this.listBoxAllocatedNetworks.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Inserir uma ou varias redes";
            // 
            // InstanceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "InstanceAdd";
            this.Text = "InstanceAdd";
            this.Load += new System.EventHandler(this.InstanceAdd_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFlavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveFlavor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveNetwork)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown numericUpDownCount;
        private Label label5;
        private Label label4;
        private TextBox textBoxInstanceDescription;
        private TextBox textBoxInstanceName;
        private Label label3;
        private TextBox textBoxProjectName;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private ListBox listBoxAvailable;
        private GroupBox groupBox1;
        private ListBox listBoxAllocated;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private CheckBox checkBoxCreateVolume;
        private ComboBox comboBox1;
        private Label label2;
        private TabPage tabPage3;
        private PictureBox pictureBoxAddFlavor;
        private PictureBox pictureBoxRemoveFlavor;
        private Label label9;
        private GroupBox groupBox4;
        private ListBox listBoxAvailableFlavors;
        private GroupBox groupBox3;
        private ListBox listBoxAllocatedFlavor;
        private TabPage tabPage4;
        private PictureBox pictureBoxAddNetwork;
        private PictureBox pictureBoxRemoveNetwork;
        private GroupBox groupBox6;
        private ListBox listBoxAvailableNetworks;
        private GroupBox groupBox5;
        private ListBox listBoxAllocatedNetworks;
        private Label label10;
    }
}