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
            GetAllDados();
            btnAlterarDados.Enabled = true;
            btnSalvarDados.Enabled = true;
            btnConsumir.Enabled = false;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            cboId.Enabled = true;
            btnIncluir.Enabled = false;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            txtDado1.Text = "";
            txtDado2.Text = "";
            txtDado3.Text = "";

        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoProduto = Convert.ToInt32(cboId.SelectedItem);
            if (codigoProduto != -1)
            {
                GetDadosPorId(codigoProduto);
            }
        }


        private void btnSalvarDados_Click(object sender, EventArgs e)
        {

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
            AddDados();
            panel.Visible = false;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDados(codigoProduto);
            panel.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (codigoProduto != -1)
            {
                DeleteDados(codigoProduto);
            }
            panel.Visible = false;
        }

        //=================================métodos para acessar a Web API ------------------------------------------------------
        private async void GetAllDados()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Dados[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetDadosPorId(int codDados)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + codDados.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var DadosJsonString = await response.Content.ReadAsStringAsync();
                    Dados dados = JsonConvert.DeserializeObject<Dados>(DadosJsonString);
                    txtDado1.Text = dados.Nome;
                    txtDado2.Text = dados.Categoria;
                }
                else
                {
                    MessageBox.Show("Falha ao obter dados : " + response.StatusCode);
                }
            }
        }

        private async void AddDados()
        {
            URI = txtURI.Text;
            Dados dados = new Dados();
            dados.Nome = txtDado1.Text;
            dados.Categoria = txtDado2.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(dados);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllDados();
        }

        private async void AtualizarDados(int codProduto)
        {
            URI = txtURI.Text;
            Dados dados = new Dados();
            dados.Id = codProduto;
            dados.Nome = txtDado1.Text;
            dados.Categoria = txtDado2.Text;

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
            GetAllDados();
        }

        private async void DeleteDados(int codProduto)
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
            GetAllDados();
        }
    }
}
