namespace AGROTISTESTE
{
    partial class CONTROLEPEDIDO
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(366, 47);
            label1.TabIndex = 0;
            label1.Text = "CONTROLE PEDIDOS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(666, 394);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(497, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += editarControlePedido;
            // 
            // button2
            // 
            button2.Location = new Point(603, 79);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += deletarPedido;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(511, 32);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 5;
            label2.Text = "INSIRA O CÓDIGO DO PEDIDO";
            // 
            // CONTROLEPEDIDO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 514);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CONTROLEPEDIDO";
            Text = "CONTROLEPEDIDO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodidoPedido;
        private DataGridViewTextBoxColumn DataEmissaoPedido;
        private DataGridViewTextBoxColumn codigoClientePedido;
        private DataGridViewTextBoxColumn NomeClientePedido;
        private DataGridViewTextBoxColumn PrecoTotalPedido;
        private DataGridViewTextBoxColumn PesoTotalPedido;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
    }
}