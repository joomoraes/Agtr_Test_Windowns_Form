namespace AGROTISTESTE
{
    partial class EDITARCLIENTE
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(315, 50);
            label2.TabIndex = 1;
            label2.Text = "DADOS CLIENTE ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 149);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(384, 85);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 5;
            label4.Text = "Logradouro";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(384, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(169, 149);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(384, 149);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 9;
            label6.Text = "Bairro";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(384, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(606, 167);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(606, 149);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 12;
            label7.Text = "UF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 227);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "IBGE";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(22, 245);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(22, 302);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 15;
            button1.Text = "Salvar Dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += salvarDadosEmEdicao;
            // 
            // EDITARCLIENTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EDITARCLIENTE";
            Text = "EDITARCLIENTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
    }
}