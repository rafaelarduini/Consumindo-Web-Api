namespace Consumindo_WebApi
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.btnSalvarProdutos = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            this.btnAlterarProdutos = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.lblPanel = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - Web API:";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(99, 6);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(420, 20);
            this.txtURI.TabIndex = 1;
            this.txtURI.Text = "https://localhost:44305/produtos/";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 32);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(504, 354);
            this.dgvDados.TabIndex = 2;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(12, 392);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(164, 31);
            this.btnConsumir.TabIndex = 3;
            this.btnConsumir.Text = "Consumir Web API";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.Enabled = false;
            this.btnSalvarProdutos.Location = new System.Drawing.Point(355, 392);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(164, 31);
            this.btnSalvarProdutos.TabIndex = 5;
            this.btnSalvarProdutos.Text = "Salvar no Banco de Dados";
            this.btnSalvarProdutos.UseVisualStyleBackColor = true;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(590, 279);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(130, 37);
            this.btnDeletarProduto.TabIndex = 10;
            this.btnDeletarProduto.Text = "Deletar Produto";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            // 
            // btnAlterarProdutos
            // 
            this.btnAlterarProdutos.Enabled = false;
            this.btnAlterarProdutos.Location = new System.Drawing.Point(185, 392);
            this.btnAlterarProdutos.Name = "btnAlterarProdutos";
            this.btnAlterarProdutos.Size = new System.Drawing.Size(164, 31);
            this.btnAlterarProdutos.TabIndex = 8;
            this.btnAlterarProdutos.Text = "Alterar Dados";
            this.btnAlterarProdutos.UseVisualStyleBackColor = true;
            this.btnAlterarProdutos.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnCancela);
            this.panel.Controls.Add(this.btnNovo);
            this.panel.Controls.Add(this.btnIncluir);
            this.panel.Controls.Add(this.btnExcluir);
            this.panel.Controls.Add(this.cboId);
            this.panel.Controls.Add(this.lblPanel);
            this.panel.Controls.Add(this.btnAtualizar);
            this.panel.Controls.Add(this.txtPreco);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtCategoria);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(56, 77);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(408, 238);
            this.panel.TabIndex = 12;
            this.panel.Visible = false;
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(329, 212);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 14;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(5, 212);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Location = new System.Drawing.Point(86, 212);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(248, 212);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(75, 56);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(45, 21);
            this.cboId.TabIndex = 10;
            this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Location = new System.Drawing.Point(54, 19);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(71, 13);
            this.lblPanel.TabIndex = 9;
            this.lblPanel.Text = "Alterar Dados";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(167, 212);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(74, 135);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(308, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(74, 109);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(308, 20);
            this.txtCategoria.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 442);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAlterarProdutos);
            this.Controls.Add(this.btnSalvarProdutos);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Button btnSalvarProdutos;
        private System.Windows.Forms.Button btnDeletarProduto;
        private System.Windows.Forms.Button btnAlterarProdutos;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.Button btnCancela;
    }
}

