using AGROTISTESTE.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AGROTISTESTE.TELACADASTRO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AGROTISTESTE
{
    public partial class CONTROLECLIENTES : Form
    {
        public CONTROLECLIENTES()
        {
            InitializeComponent();

            try
            {
                List<Clientes> list = new List<Clientes>();
                List<string> resultado = new List<string>();
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Problema em estabelecer conexão com o banco");

                SqlCommand cmd = new SqlCommand(@"select * from cadastrocliente", conn);
                var leitor = cmd.ExecuteReader();

                int nColunas = leitor.FieldCount;


                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView1.Columns.Add(leitor.GetName(i).ToString(), leitor.GetName(i).ToString());
                }
                string[] linhaDados = new string[nColunas];

                while (leitor.Read())
                {
                    for (int a = 0; a < nColunas; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (leitor.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = leitor.GetInt32(a).ToString();
                        }
                        if (leitor.GetFieldType(a).ToString() == "System.String")

                        {
                            linhaDados[a] = leitor.GetString(a).ToString();
                        }
                        if (leitor.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = leitor.GetDateTime(a).ToString();

                        }
                    }
                    dataGridView1.Rows.Add(linhaDados);
                }

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void editarClient(object sender, EventArgs e)
        {

            EDITARCLIENTE editarclientes = new EDITARCLIENTE(textBox1.Text.ToString());
            editarclientes.Show();
        }

        private void apagarDadosClient(object sender, EventArgs e)
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


                SqlCommand cmd = new SqlCommand("delete from cadastrocliente" +
                " where Codigo=" + textBox1.Text.ToString(), conn);
                var leitor = cmd.ExecuteReader();

                MessageBox.Show("Alteração realizada com sucesso");
                conn.Close();
                Refresh();
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
