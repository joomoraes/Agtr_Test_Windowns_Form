using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AGROTISTESTE.TELACADASTRO;
using static System.Windows.Forms.DataFormats;

namespace AGROTISTESTE
{
    public partial class TELAINICIAL : Form
    {
        public TELAINICIAL()
        {
            InitializeComponent();
        }


        private BindingSource binding1;

        private void TELAINICIAL_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private async void button1_Click_1(object sender, EventArgs e)
        {

            var strConn = textBox1.Text.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                SqlCommand cmd = new SqlCommand(
                "if not exists (select * from sysobjects where name='cadastrocliente' and xtype='U') " +
                "create table cadastrocliente " +
                "(" +
                "Codigo varchar(64) not null unique," +
                "Nome varchar(250) not null," +
                "CEP varchar(10) not null," +
                "Logradouro varchar(250) not null," +
                "Bairro varchar(50) not null," +
                "Cidade varchar(50) not null," +
                "UF varchar(25) not null," +
                "ibge varchar(35) not null" +
                ");" +
                "if not exists (select * from sysobjects where name='cadastroproduto' and xtype='U') " +
                "create table cadastroproduto " +
                "(" +
                "Codigo varchar(64) not null unique," +
                "Descricao varchar(250) not null," +
                "Pesoliquido FLOAT not null," +
                "Precounitario FLOAT not null" +
                ");" +
                "if not exists (select * from sysobjects where name='colocacaopedidos' and xtype='U') " +
                "create table colocacaopedidos " +
                "(" +
                "Codigo varchar(64) not null unique," +
                "dataemissao DATETIME not null," +
                "codigocliente integer not null," +
                "nomecliente varchar(250) not null," +
                "precototalpedido FLOAT not null," +
                "pesototalpedido FLOAT not null" +
                ")", conn);


                cmd.ExecuteReader();

                var connectionString = new
                {
                    connectionString = textBox1.Text
                };
                conn.Close();

                string fileName = "connectionString.json";
                using FileStream createStream = File.Create(fileName);
                await JsonSerializer.SerializeAsync(createStream, connectionString);
                await createStream.DisposeAsync();
                MessageBox.Show("Conexão estabelecida com sucesso");
                TELACADASTRO tELACADASTRO = new TELACADASTRO();
                tELACADASTRO.Show();
            }
            else
            {
                MessageBox.Show("Ops, falha ao seu conectar");
            }

        }

        private void manualConect(object sender, EventArgs e)
        {

            string fileName = "connectionString.json";
            string jsonString = File.ReadAllText(fileName);
            ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
            SqlConnection conn = new SqlConnection(strConn.connectionString);
            conn.Open();
            if (conn.State != ConnectionState.Open)
                MessageBox.Show("Problema em estabelecer conexão com o banco");

            conn.Close();


            TELACADASTRO tELACADASTRO = new TELACADASTRO();
            tELACADASTRO.Show();
        }
    }
}
