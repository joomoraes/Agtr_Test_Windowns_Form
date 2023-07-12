namespace AGROTISTESTE
{
    partial class CONTROLECLIENTES
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
            dataGridView1 = new DataGridView();
            CodigoCliente = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Logradouro = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            IBGE = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodigoCliente, NomeCliente, CEP, Logradouro, Bairro, Cidade, UF, IBGE });
            dataGridView1.Location = new Point(13, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(860, 476);
            dataGridView1.TabIndex = 2;
            // 
            // CodigoCliente
            // 
            CodigoCliente.HeaderText = "Codigo";
            CodigoCliente.Name = "CodigoCliente";
            // 
            // NomeCliente
            // 
            NomeCliente.HeaderText = "Nome";
            NomeCliente.Name = "NomeCliente";
            // 
            // CEP
            // 
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            // 
            // Logradouro
            // 
            Logradouro.HeaderText = "Logradouro";
            Logradouro.Name = "Logradouro";
            // 
            // Bairro
            // 
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            // 
            // Cidade
            // 
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            // 
            // UF
            // 
            UF.HeaderText = "UF";
            UF.Name = "UF";
            // 
            // IBGE
            // 
            IBGE.HeaderText = "IBGE";
            IBGE.Name = "IBGE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(405, 30);
            label1.TabIndex = 3;
            label1.Text = "CONTROLE DE CADASTRO DE CLIENTES";
            // 
            // button1
            // 
            button1.Location = new Point(718, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += editarClient;
            // 
            // button2
            // 
            button2.Location = new Point(799, 56);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += apagarDadosClient;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(773, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 23);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(744, 9);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 7;
            label2.Text = "INSIRA O CÓDIGO";
            // 
            // CONTROLECLIENTES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 573);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CONTROLECLIENTES";
            Text = "CONTROLECLIENTES";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodigoCliente;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
        private DataGridViewTextBoxColumn IBGE;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
    }
}