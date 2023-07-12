using AGROTISTESTE.Models;
using AutoMapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AGROTISTESTE
{
    public partial class TELACADASTRO : Form
    {
        Random numAleatorio = new Random();
        static HttpClient client = new HttpClient();
        public TELACADASTRO(string? ultimopedido)
        {
            InitializeComponent();
            textBox14.Text = numAleatorio.Next(1, 10000).ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void clickBuscarCep(object sender, EventArgs e)
        {

            EnderecoCEP enderecoCEP = null;
            var stringResponse = "https://viacep.com.br/ws/" + textBox3.Text.ToString() + "/json/";
            HttpResponseMessage response = client.GetAsync(stringResponse).Result;
            if (response.IsSuccessStatusCode)
            {
                enderecoCEP = await response.Content.ReadFromJsonAsync<EnderecoCEP>();

                if (enderecoCEP.logradouro == null && enderecoCEP.uf == null && enderecoCEP.localidade == null)
                    MessageBox.Show("CEP inexistente");

                textBox3.Text = enderecoCEP.cep ?? "";
                textBox4.Text = enderecoCEP.logradouro ?? "";
                textBox5.Text = enderecoCEP.complemento ?? "";
                textBox6.Text = enderecoCEP.bairro ?? "";
                textBox7.Text = enderecoCEP.localidade ?? "";
                textBox8.Text = enderecoCEP.uf ?? "";
                textBox9.Text = enderecoCEP.ibge ?? "";
            }
            else
            {
                MessageBox.Show("CEP não encontrando");
            }
        }

        public class EnderecoCEP
        {
            public string? cep { get; set; }
            public string? logradouro { get; set; }
            public string? complemento { get; set; }
            public string? bairro { get; set; }
            public string? localidade { get; set; }
            public string? uf { get; set; }
            public string? ibge { get; set; }
            public string? gia { get; set; }
            public string? ddd { get; set; }
            public string? siafi { get; set; }
        }

        private void cadastroCliente(object sender, EventArgs e)
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


                SqlCommand cmd = new SqlCommand(@"INSERT INTO cadastrocliente(Codigo, Nome, CEP, Logradouro, Bairro, Cidade, UF, ibge)" +
                            "VALUES('" + textBox1.Text.ToString() + "','" +
                                        textBox2.Text.ToString() + "','" +
                                        textBox3.Text.ToString() + "','" +
                                        textBox4.Text.ToString() + "','" +
                                        textBox6.Text.ToString() + "','" +
                                        textBox7.Text.ToString() + "','" +
                                        textBox8.Text.ToString() + "','" +
                                        textBox9.Text.ToString() + "');", conn);
                cmd.ExecuteReader();

                conn.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();

                MessageBox.Show("Novo cliente cadastrado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível salvar o novo cliente");

            }


        }



        public class ConnectionString
        {
            public string connectionString { get; set; }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cadastroItens(object sender, EventArgs e)
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


                SqlCommand cmd = new SqlCommand(@"INSERT INTO cadastroproduto(Codigo, Descricao, Pesoliquido, Precounitario)" +
                          "VALUES('" + textBox10.Text.ToString() + "','" +
                                      textBox11.Text.ToString() + "'," +
                                      textBox12.Text + "," +
                                      textBox13.Text +
                                       ");", conn);
                cmd.ExecuteReader();

                conn.Close();

                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();


                MessageBox.Show("Novo item cadastrado com sucesso!");

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarSeExisteProduto())
                {


                    string fileName = "connectionString.json";
                    string jsonString = File.ReadAllText(fileName);
                    ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                    SqlConnection conn = new SqlConnection(strConn.connectionString);
                    conn.Open();
                    if (conn.State != ConnectionState.Open)
                        MessageBox.Show("Problema em estabelecer conexão com o banco");



                    SqlCommand cmd = new SqlCommand(@"INSERT INTO auxiliapedido(CodigoItem, CodigoPedido)" +
                              "VALUES('" + textBox17.Text.ToString() + "','" +
                                          textBox14.Text.ToString() + "'" +
                                           ");", conn);



                    cmd.ExecuteReader();

                    conn.Close();


                    InserirEmListaProdutos();
                    MessageBox.Show("Novo item cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não existe produto cadastradado com esse id");
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

        private bool ValidarSeExisteProduto()
        {
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

                SqlCommand cmd = new SqlCommand(@"select * from cadastroproduto 
                                                    where Codigo =" + textBox17.Text.ToString(), conn);
                var leitor = cmd.ExecuteReader();


                if (!leitor.HasRows)
                {
                    conn.Close();
                    return false;
                }
                conn.Close();
                return true;


            }
            catch (Exception)
            {
                MessageBox.Show("Houve algum problema em obter os dados do DB");
                string fileName = "connectionString.json";
                string jsonString = File.ReadAllText(fileName);
                ConnectionString strConn = JsonSerializer.Deserialize<ConnectionString>(jsonString);
                SqlConnection conn = new SqlConnection(strConn.connectionString);
                conn.Close();
                return false;


            }

        }

        private void InserirEmListaProdutos()
        {
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

                SqlCommand cmd = new SqlCommand(@"select * from cadastroproduto as ct
                                                    inner join auxiliapedido as ap
                                                    on ap.CodigoItem = ct.Codigo
                                                    where ap.CodigoPedido =" + textBox14.Text.ToString(), conn);
                var leitor = cmd.ExecuteReader();

                int nColunas = leitor.FieldCount;


                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView1.Columns.Add(leitor.GetName(i).ToString(), leitor.GetName(i).ToString());
                }
                string[] linhaDados = new string[nColunas];
                double[] totalpreco = new double[nColunas];

                while (leitor.Read())
                {
                    for (int a = 0; a < nColunas; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (leitor.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = leitor.GetInt32(a).ToString();
                        }
                        if (leitor.GetFieldType(a).ToString() == "System.Double")
                        {
                            linhaDados[a] = leitor.GetDouble(a).ToString();
                            totalpreco[a] = double.Parse(leitor.GetDouble(a).ToString());
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

                }

                dataGridView1.Rows.Add(linhaDados);

                double totalprec = 0;
                double totalpeso = 0;

                double precoatual = double.Parse(textBox19.Text.ToString() == string.Empty ? "0" : textBox19.Text);
                double pesototal = double.Parse(textBox18.Text.ToString() == string.Empty ? "0" : textBox18.Text);

                for (int i = 0; i < linhaDados.GetLength(0); i++)
                {
                    totalpeso = +pesototal + double.Parse(linhaDados[2]);
                    totalprec = +precoatual + double.Parse(linhaDados[3]);
                }

                textBox19.Text = totalprec.ToString("F");
                textBox18.Text = totalpeso.ToString("F");

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


        private void controleClientes(object sender, EventArgs e)
        {
            CONTROLECLIENTES controleclientes = new CONTROLECLIENTES();
            controleclientes.Show();
        }

        private void controleItens(object sender, EventArgs e)
        {
            CONTROLEITENS controleitens = new CONTROLEITENS();
            controleitens.Show();
        }

        private void controlePedidos(object sender, EventArgs e)
        {
            CONTROLEPEDIDO controlepedido = new CONTROLEPEDIDO();
            controlepedido.Show();

        }

        private void buscarCliente(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand(@"select * from cadastrocliente where Codigo = " + textBox15.Text, conn);
                var leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    if (leitor.HasRows)
                    {
                        textBox16.Text = (string)leitor["Nome"];
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

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalizaPedido(object sender, EventArgs e)
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


                double pesoliquidototal = double.Parse(textBox19.Text.ToString().Replace(",","."), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));
                double precototal = double.Parse(textBox18.Text.ToString().Replace(",", "."), NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));



                SqlCommand cmd = new SqlCommand(@"INSERT INTO colocacaopedidos(Codigo, dataemissao, codigocliente, nomecliente, precototalpedido, pesototalpedido)" +
                            "VALUES('" + textBox14.Text.ToString() + "','" +
                                        DateTime.Parse(dateTimePicker2.Text).ToString("dd-MM-yyyy HH:mm:ss") + "','" +
                                        textBox15.Text.ToString() + "','" +
                                        textBox16.Text.ToString() + "'," +
                                        pesoliquidototal.ToString(CultureInfo.InvariantCulture) + "," +
                                        precototal.ToString(CultureInfo.InvariantCulture) +
                                        ");", conn);


               

                cmd.ExecuteReader();

                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox18.Clear();
                textBox19.Clear();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].DataGridView.Columns.Clear();
                }

                conn.Close();

                    MessageBox.Show("Pedido encaminhado com sucesso");
                textBox14.Text = numAleatorio.Next(1, 10000).ToString();



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
