using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AGROTISTESTE.TELACADASTRO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AGROTISTESTE
{
    public partial class EDITARITEM : Form
    {

        public string _codigoitem { get; set; }
        public EDITARITEM(string codigoitem)
        {
            InitializeComponent();

            _codigoitem = codigoitem;

            try
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Problema em estabelecer conexão com o banco");

                SqlCommand cmd = new SqlCommand(@"select * from cadastroproduto where Codigo = " + codigoitem, conn);
                var leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    if (leitor.HasRows)
                    {
                        textBox1.Text = (string) leitor["Descricao"];
                        textBox3.Text = (string) leitor["Precounitario"].ToString();
                        textBox2.Text = (string) leitor["Pesoliquido"].ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salvarAlteracoesItem(object sender, EventArgs e)
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

                double pesoliquido = double.Parse(textBox2.Text.ToString(), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));
                double precounitario = double.Parse(textBox3.Text.ToString(), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));

                SqlCommand cmd = new SqlCommand("update cadastroproduto" +
                " set Descricao ='" + textBox1.Text + "'," +
                "Pesoliquido =" + pesoliquido.ToString(CultureInfo.InvariantCulture) + "," +
                "Precounitario=" + precounitario.ToString(CultureInfo.InvariantCulture) +
                "where Codigo=" + _codigoitem
                , conn);
                var leitor = cmd.ExecuteReader();

                MessageBox.Show("Alteração realizada com sucesso");
                conn.Close();

                EDITARCLIENTE editarcliente = new EDITARCLIENTE(_codigoitem);
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
