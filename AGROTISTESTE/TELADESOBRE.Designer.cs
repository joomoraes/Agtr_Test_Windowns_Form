namespace AGROTISTESTE
{
    partial class TELADESOBRE
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(247, 21);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO AO AGROTIS TESTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(180, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Versão 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 66);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "by: João Pedro ";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(229, 66);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Linkedin";
            
            // 
            // TELADESOBRE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TELADESOBRE";
            Text = "TELADESOBRE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}