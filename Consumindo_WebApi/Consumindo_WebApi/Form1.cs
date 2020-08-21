using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

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
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            cboId.Enabled = true;
            btnIncluir.Enabled = false;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Enabled = false;
            txtCategoria.Enabled = false;
            txtPreco.Enabled = false;
            txtNome.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPreco.Text = string.Empty;

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
        }


        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoProduto = Convert.ToInt32(cboId.SelectedItem);
            if (codigoProduto != -1)
            {
                GetProdutoPorId(codigoProduto);
            }
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            txtNome.Enabled = true;
            txtCategoria.Enabled = true;
            txtPreco.Enabled = true;

        }


        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            SalvarBancoDados();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            cboId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPreco.Enabled = true;
            txtNome.Enabled = true;
            txtCategoria.Enabled = true;
            cboId.Enabled = false;
            btnIncluir.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtPreco.Text != string.Empty)
            {
                AddProdutos();
                panel.Visible = false;
            }
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

        // txtPreco aceita apenas Números e Decimal

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }


        // Permite movimentação do Panel

        Point PanelMouseDownLocation;

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel.Left += e.X - PanelMouseDownLocation.X;

                panel.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }


        //================================= Métodos para acessar a Web API ------------------------------------------------------

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

                        //Preenche DataGridView
                        dgvDados.DataSource = dados;

                        //Preenche combo box do panel
                        cboId.Items.Clear();
                        cboId.Text = string.Empty;
                        var listaId = 0;
                        foreach (Produtos i in dados)
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

        private async void GetProdutoPorId(int codProdutos)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + codProdutos.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var DadosJsonString = await response.Content.ReadAsStringAsync();
                    Produtos dados = JsonConvert.DeserializeObject<Produtos>(DadosJsonString);
                    txtNome.Text = dados.Nome;
                    txtCategoria.Text = dados.Categoria;
                    txtPreco.Text = dados.Preco.ToString("N2");
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
            dados.Preco = Convert.ToDecimal(txtPreco.Text);

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
            Produtos produtos = new Produtos();
            produtos.Id = codProduto;
            produtos.Nome = txtNome.Text;
            produtos.Categoria = txtCategoria.Text;
            produtos.Preco = Convert.ToDecimal(txtPreco.Text);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + produtos.Id, produtos);
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

        //================================= Método para salvar no Banco de Dados ------------------------------------------------------
        private async void SalvarBancoDados()
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

                        SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
                        string sql = "insert into Produtos values (@Id, @Nome, @Categoria, @Preco)";
                        SqlCommand c = new SqlCommand(sql, conn);
                        conn.Open();
                        try
                        {
                            foreach (Produtos row in dados)
                            {
                                c.Parameters.Clear();

                                c.Parameters.AddWithValue("@Id", Convert.ToInt32(row.Id));
                                c.Parameters.AddWithValue("@Nome", Convert.ToString(row.Nome));
                                c.Parameters.AddWithValue("@Categoria", Convert.ToString(row.Categoria));
                                c.Parameters.AddWithValue("@Preco", Convert.ToDecimal(row.Preco));

                                c.ExecuteNonQuery();

                            }

                            conn.Close();

                            MessageBox.Show("Produtos foram salvos no Banco de dados");

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Ocorreu o erro: " + ex);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados : " + response.StatusCode);
                    }
                }
            }
        }
    }
}
