using AGROTISTESTE.Models;
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
    public partial class CONTROLEPEDIDO : Form
    {
        public CONTROLEPEDIDO()
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

                SqlCommand cmd = new SqlCommand(@"select * from colocacaopedidos", conn);
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
                        if (leitor.GetFieldType(a).ToString() == "System.Double")
                        {
                            linhaDados[a] = leitor.GetDouble(a).ToString();
                        }
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

        private void editarControlePedido(object sender, EventArgs e)
        {
            EDITARPEDIDO editarpedido = new EDITARPEDIDO(textBox1.Text.ToString());
            editarpedido.Show();
        }

        private void deletarPedido(object sender, EventArgs e)
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


                SqlCommand cmd = new SqlCommand("delete from colocacaopedidos" +
                " where Codigo=" + textBox1.Text.ToString(), conn);
                cmd.ExecuteReader();

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
