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
    public partial class EDITARPEDIDO : Form
    {

        public string _codigopedido { get; set; }


        public EDITARPEDIDO(string codigopedido)
        {
            InitializeComponent();
            _codigopedido = codigopedido;

            try
            {
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Problema em estabelecer conexão com o banco");

                SqlCommand cmd = new SqlCommand(@"select * from colocacaopedidos where Codigo = " + codigopedido, conn);
                var leitor = cmd.ExecuteReader();


                while (leitor.Read())
                {
                    if (leitor.HasRows)
                    {
                        var date = leitor["dataemissao"].ToString();
                        dateTimePicker1.Text = date;
                        textBox1.Text = leitor["codigocliente"].ToString();
                        textBox2.Text = (string)leitor["nomecliente"];
                        textBox3.Text = leitor["precototalpedido"].ToString();
                        textBox4.Text = leitor["pesototalpedido"].ToString();
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

        private void salvarEdicoesPedido(object sender, EventArgs e)
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

                double precounitario = double.Parse(textBox3.Text.ToString().Replace(",","."), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));
                double pesoliquido = double.Parse(textBox4.Text.ToString().Replace(",","."), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));
                

                SqlCommand cmd = new SqlCommand("update colocacaopedidos" +
                " set dataemissao ='" + DateTime.Parse(dateTimePicker1.Text).ToString("dd-MM-yyyy HH:mm:ss") + "'," +
                "codigocliente ='" + textBox1.Text + "'," +
                "nomecliente='" + textBox2.Text + "'," +
                "precototalpedido=" + precounitario.ToString(CultureInfo.InvariantCulture) + "," +
                "pesototalpedido=" + pesoliquido.ToString(CultureInfo.InvariantCulture) + 
                " where Codigo=" + _codigopedido
                , conn);
                var leitor = cmd.ExecuteReader();

                MessageBox.Show("Alteração realizada com sucesso");
                conn.Close();

                EDITARCLIENTE editarcliente = new EDITARCLIENTE(_codigopedido);
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
