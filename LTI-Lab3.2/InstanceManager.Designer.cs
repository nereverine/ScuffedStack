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
            this.labelInstanceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInstanceStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInstanceImage = new System.Windows.Forms.Label();
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
            this.labelInstanceImage.Size = new System.Drawing.Size(38, 15);
            this.labelInstanceImage.TabIndex = 5;
            this.labelInstanceImage.Text = "label4";
            // 
            // InstanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInstanceImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInstanceStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstanceName);
            this.Name = "InstanceManager";
            this.Text = "InstanceManager";
            this.Load += new System.EventHandler(this.InstanceManager_Load);
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
    }
}