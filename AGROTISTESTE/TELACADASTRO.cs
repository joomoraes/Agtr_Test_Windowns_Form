using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROTISTESTE
{
    public partial class TELACADASTRO : Form
    {
        static HttpClient client = new HttpClient();
        public TELACADASTRO()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand();
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
                {
                    MessageBox.Show("Problema em estabelecer conexão com o banco");
                }

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

                MessageBox.Show("Não foi possível salvar o novo item");

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

        }
    }
}
