namespace AGROTISTESTE
{
    partial class TELADEAJUDA
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
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 54);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO AO AGROTISTESTE";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(150, 123);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Link Para PDF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(308, 15);
            label2.TabIndex = 2;
            label2.Text = "Você poderá encontrar mais detalhes sobre a usabilidade ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 84);
            label3.Name = "label3";
            label3.Size = new Size(276, 15);
            label3.TabIndex = 3;
            label3.Text = "do sistema no manual PDF presente no linkl abaixo";
            // 
            // TELADEAJUDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 415);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "TELADEAJUDA";
            Text = "TELADEAJUDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
    }
}