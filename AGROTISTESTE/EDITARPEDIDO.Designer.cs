namespace AGROTISTESTE
{
    partial class EDITARPEDIDO
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 47);
            label1.TabIndex = 0;
            label1.Text = "DADOS PEDIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 72);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Emissão";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 72);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 4;
            label4.Text = "Código Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 135);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 7;
            label5.Text = "Nome Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 198);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 8;
            label6.Text = "Preço Total Pedido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(196, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(196, 198);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 11;
            label7.Text = "Peso Total Pedido";
            // 
            // button1
            // 
            button1.Location = new Point(25, 271);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 12;
            button1.Text = "Salvar Edições";
            button1.UseVisualStyleBackColor = true;
            button1.Click += salvarEdicoesPedido;
            // 
            // EDITARPEDIDO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EDITARPEDIDO";
            Text = "EDITARPEDIDO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
    }
}