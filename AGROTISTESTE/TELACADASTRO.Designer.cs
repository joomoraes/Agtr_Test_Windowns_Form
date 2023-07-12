namespace AGROTISTESTE
{
    partial class TELACADASTRO
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label11 = new Label();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label18 = new Label();
            textBox16 = new TextBox();
            button6 = new Button();
            textBox15 = new TextBox();
            label17 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label16 = new Label();
            textBox14 = new TextBox();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button10 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 188);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1102, 404);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1094, 376);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CADASTRO CLIENTE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(765, 48);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 19;
            button2.Text = "BUSCAR POR CEP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clickBuscarCep;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cadastroCliente;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(908, 163);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 17;
            label10.Text = "CÓDIGO IBGE";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(908, 181);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(659, 181);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(659, 163);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 14;
            label9.Text = "UF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(269, 163);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 13;
            label8.Text = "CIDADE";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(269, 181);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(180, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(39, 181);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 23);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 163);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 10;
            label7.Text = "BAIRRO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(659, 90);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 9;
            label6.Text = "COMPLEMENTO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(659, 108);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(349, 23);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 90);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 7;
            label5.Text = "LOGRADOURO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(553, 23);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(659, 30);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 5;
            label4.Text = "CEP";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(659, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(181, 30);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "NOME";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 30);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "CÓDIGO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1094, 376);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CADASTRO ITENS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(41, 240);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "SUBMIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cadastroItens;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(269, 183);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(269, 165);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 6;
            label14.Text = "Preço Unitário";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(41, 183);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(41, 165);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 4;
            label13.Text = "Peso Líquido ";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(41, 103);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 3;
            label12.Text = "Descrição Produto";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(41, 121);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(576, 23);
            textBox11.TabIndex = 2;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(41, 60);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(41, 42);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 0;
            label11.Text = "Código Item";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(textBox16);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(textBox15);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(dateTimePicker2);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(textBox14);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1094, 376);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "COLOCAÇÃO DE PEDIDOS";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(670, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 319);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes Pedido ";
            // 
            // button9
            // 
            button9.Location = new Point(127, 136);
            button9.Name = "button9";
            button9.Size = new Size(141, 23);
            button9.TabIndex = 13;
            button9.Text = "Adicionar Itens";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(946, 319);
            button8.Name = "button8";
            button8.Size = new Size(122, 23);
            button8.TabIndex = 12;
            button8.Text = "Finalizar Pedido (f9)";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(29, 136);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Refresh (f5)";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(29, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(605, 170);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código Produto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição Produto";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Peso Líquido ";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Preço Unitário ";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(29, 81);
            label18.Name = "label18";
            label18.Size = new Size(86, 15);
            label18.TabIndex = 9;
            label18.Text = "Nome Cliente ";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(29, 99);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(332, 23);
            textBox16.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(537, 44);
            button6.Name = "button6";
            button6.Size = new Size(110, 23);
            button6.TabIndex = 7;
            button6.Text = "Buscar Cliente";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(431, 44);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(100, 23);
            textBox15.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(431, 23);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 5;
            label17.Text = "ClientID";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(161, 41);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(161, 23);
            label16.Name = "label16";
            label16.Size = new Size(79, 15);
            label16.TabIndex = 3;
            label16.Text = "Data Emissão";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(29, 41);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(29, 23);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 0;
            label15.Text = "N° Pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transferir;
            pictureBox1.Location = new Point(908, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 170);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 59);
            label1.Name = "label1";
            label1.Size = new Size(474, 86);
            label1.TabIndex = 3;
            label1.Text = "AGROTISTESTI";
            // 
            // button4
            // 
            button4.Location = new Point(16, 159);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 4;
            button4.Text = "Controle de Clientes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += controleClientes;
            // 
            // button5
            // 
            button5.Location = new Point(177, 159);
            button5.Name = "button5";
            button5.Size = new Size(134, 23);
            button5.TabIndex = 5;
            button5.Text = "Controle de Itens";
            button5.UseVisualStyleBackColor = true;
            button5.Click += controleItens;
            // 
            // button10
            // 
            button10.Location = new Point(333, 159);
            button10.Name = "button10";
            button10.Size = new Size(140, 23);
            button10.TabIndex = 6;
            button10.Text = "Controle de Pedidos";
            button10.UseVisualStyleBackColor = true;
            button10.Click += controlePedidos;
            // 
            // TELACADASTRO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 604);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Name = "TELACADASTRO";
            Text = "TELACADASTRO";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label9;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label7;
        private Button button2;
        private TextBox textBox12;
        private Label label13;
        private Label label12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox13;
        private Label label14;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox14;
        private Label label15;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private Label label18;
        private TextBox textBox16;
        private Button button6;
        private TextBox textBox15;
        private Label label17;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button8;
        private Button button7;
        private Button button9;
        private GroupBox groupBox1;
        private Button button10;
    }
}