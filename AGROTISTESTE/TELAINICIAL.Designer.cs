namespace AGROTISTESTE
{
    partial class TELAINICIAL
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TELAINICIAL));
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(672, 65);
            label1.TabIndex = 2;
            label1.Text = "BEM VINDO A AGROTISTEST";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 316);
            label2.Name = "label2";
            label2.Size = new Size(809, 15);
            label2.TabIndex = 3;
            label2.Text = "POR FAVOR INSIRA OS DADOS DA SUA CONEXÃO DE BANCO DE DADOS LOGO ABAIXO E INFORME O TIPO DE BANCO QUE VOCÊ PRETENE USAR";
            label2.Click += label2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "transferir.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transferir;
            pictureBox1.Location = new Point(324, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 226);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 364);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 6;
            label3.Text = "STRING DE CONEXÃO";
            // 
            // button1
            // 
            button1.Location = new Point(34, 411);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(115, 411);
            button2.Name = "button2";
            button2.Size = new Size(184, 23);
            button2.TabIndex = 10;
            button2.Text = "Já realizei conexão manual";
            button2.UseVisualStyleBackColor = true;
            button2.Click += manualConect;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "(f1) Ajuda";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 331);
            label4.Name = "label4";
            label4.Size = new Size(536, 15);
            label4.TabIndex = 12;
            label4.Text = "Obs: a cadeia de strings precisa ser em formato microsoft-sql-server como segue de exemplo abaixo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 346);
            label5.Name = "label5";
            label5.Size = new Size(619, 15);
            label5.TabIndex = 13;
            label5.Text = "connectionString\":\"Server=localhost;Database=AGROTISTESTE;Trusted_Connection=True;TrustServerCertificate=True;";
            // 
            // TELAINICIAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 493);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TELAINICIAL";
            Text = "TELAINICIAL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
    }
}