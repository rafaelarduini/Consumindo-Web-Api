using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Consumindo_WebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoProduto = 1;

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            GetAllProdutos();
            btnAlterarProdutos.Enabled = true;
            btnSalvarProdutos.Enabled = true;
            btnConsumir.Enabled = false;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            cboId.Enabled = true;
            btnIncluir.Enabled = false;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtPreco.Text = "";


        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoProduto = Convert.ToInt32(cboId.SelectedItem);
            if (codigoProduto != -1)
            {
                GetProdutoPorId(codigoProduto);
            }
        }


        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            SalvarBancoDados();
        }

        //================================= Método para salvar no Banco de Dados ------------------------------------------------------
        private void SalvarBancoDados()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
            string sql = "insert into Produtos values (@Id, @Nome, @Categoria, @Preco)";
            SqlCommand c = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    c.Parameters.Clear();

                    c.Parameters.AddWithValue("@Id", Convert.ToInt32(row.Cells["Id"].Value));
                    c.Parameters.AddWithValue("@Nome", Convert.ToString(row.Cells["Nome"].Value));
                    c.Parameters.AddWithValue("@Categoria", Convert.ToString(row.Cells["Categoria"].Value));
                    c.Parameters.AddWithValue("@Preco", Convert.ToDecimal(row.Cells["Preco"].Value));

                    c.ExecuteNonQuery();

                }


                conn.Close();

                MessageBox.Show("Produtos foram salvos no Banco de dados");



            }            
            catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cboId.Enabled = false;
            btnIncluir.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AddProdutos();
            panel.Visible = false;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarProdutos(codigoProduto);
            panel.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (codigoProduto != -1)
            {
                DeleteProdutos(codigoProduto);
            }
            panel.Visible = false;
        }

        //=================================métodos para acessar a Web API ------------------------------------------------------

        private async void GetAllProdutos()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<Produtos[]>(ProdutoJsonString).ToList();
                        dgvDados.DataSource = dados;
                        cboId.Items.Clear();
                        var listaId = 0;
                        foreach(Produtos i in dados)
                        {
                            listaId = i.Id;
                            cboId.Items.Add(listaId);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados : " + response.StatusCode);
                    }

                }
            }
        }

        private async void GetProdutoPorId(int codDados)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + codDados.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var DadosJsonString = await response.Content.ReadAsStringAsync();
                    Produtos dados = JsonConvert.DeserializeObject<Produtos>(DadosJsonString);
                    txtNome.Text = dados.Nome;
                    txtCategoria.Text = dados.Categoria;
                    txtPreco.Text = dados.Preco.ToString();
                }
                else
                {
                    MessageBox.Show("Falha ao obter dados : " + response.StatusCode);
                }
            }
        }

        private async void AddProdutos()
        {
            URI = txtURI.Text;
            Produtos dados = new Produtos();
            dados.Nome = txtNome.Text;
            dados.Categoria = txtCategoria.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(dados);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllProdutos();
        }

        private async void AtualizarProdutos(int codProduto)
        {
            URI = txtURI.Text;
            Produtos dados = new Produtos();
            dados.Id = codProduto;
            dados.Nome = txtNome.Text;
            dados.Categoria = txtCategoria.Text;
            dados.Preco = Convert.ToDecimal(txtCategoria.Text);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + dados.Id, dados);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

        private async void DeleteProdutos(int codProduto)
        {
            URI = txtURI.Text;
            int ProdutoID = codProduto;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, ProdutoID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }
    }
}
