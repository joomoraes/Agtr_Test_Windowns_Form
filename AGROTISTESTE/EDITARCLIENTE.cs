using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AGROTISTESTE.TELACADASTRO;

namespace AGROTISTESTE
{
    public partial class EDITARCLIENTE : Form
    {
        public string _codigocliente { get; set; }

        public EDITARCLIENTE(string codigocliente)
        {
            InitializeComponent();
            _codigocliente = codigocliente;

            try
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Problema em estabelecer conexão com o banco");

                SqlCommand cmd = new SqlCommand(@"select * from cadastrocliente where Codigo = " + codigocliente, conn);
                var leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    if (leitor.HasRows)
                    {
                        textBox1.Text = (string)leitor["Nome"];
                        textBox3.Text = (string)leitor["Logradouro"];
                        textBox2.Text = (string)leitor["CEP"];
                        textBox4.Text = (string)leitor["Cidade"];
                        textBox5.Text = (string)leitor["Bairro"];
                        textBox6.Text = (string)leitor["UF"];
                        textBox7.Text = (string)leitor["ibge"];
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve algum problema em obter os dados do DB");
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Close();
            }
            finally
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Close();
            }
        }

        private void salvarDadosEmEdicao(object sender, EventArgs e)
        {
            try
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Problema em estabelecer conexão com o banco");

                SqlCommand cmd = new SqlCommand("update cadastrocliente" +
                " set Nome ='" + textBox1.Text + "'," +
                "CEP ='" + textBox2.Text + "'," +
                "Logradouro='" + textBox3.Text + "'," +
                "Bairro='" + textBox5.Text + "'," +
                "Cidade='" + textBox4.Text + "'," +
                "UF='" + textBox6.Text + "'," +
                "ibge='" + textBox7.Text + "'" +
                "where Codigo=" + _codigocliente
                , conn);
                var leitor = cmd.ExecuteReader();

                MessageBox.Show("Alteração realizada com sucesso");
                conn.Close();

                EDITARCLIENTE editarcliente = new EDITARCLIENTE(_codigocliente);
                editarcliente.Close(); 



            }
            catch (Exception)
            {
                MessageBox.Show("Houve algum problema em obter os dados do DB");
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Close();
            }
            finally
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Close();
            }
            
        }
    }
}
