namespace LTI_Lab3._2
{
    partial class AssociateFloatingIP
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFloatingIPs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço IP";
            // 
            // comboBoxFloatingIPs
            // 
            this.comboBoxFloatingIPs.FormattingEnabled = true;
            this.comboBoxFloatingIPs.Location = new System.Drawing.Point(46, 46);
            this.comboBoxFloatingIPs.Name = "comboBoxFloatingIPs";
            this.comboBoxFloatingIPs.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFloatingIPs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Associar ao porto:";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(46, 121);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPorts.TabIndex = 3;
            // 
            // AssociateFloatingIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 244);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFloatingIPs);
            this.Controls.Add(this.label1);
            this.Name = "AssociateFloatingIP";
            this.Text = "AssociateFloatingIP";
            this.Load += new System.EventHandler(this.AssociateFloatingIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxFloatingIPs;
        private Label label2;
        private ComboBox comboBoxPorts;
    }
}