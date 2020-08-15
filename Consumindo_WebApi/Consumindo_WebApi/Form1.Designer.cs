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
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.lblPanel = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtDado3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDado2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDado1 = new System.Windows.Forms.TextBox();
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
            // btnSalvarDados
            // 
            this.btnSalvarDados.Enabled = false;
            this.btnSalvarDados.Location = new System.Drawing.Point(355, 392);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(164, 31);
            this.btnSalvarDados.TabIndex = 5;
            this.btnSalvarDados.Text = "Salvar no Banco de Dados";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
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
            // btnAlterarDados
            // 
            this.btnAlterarDados.Enabled = false;
            this.btnAlterarDados.Location = new System.Drawing.Point(185, 392);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(164, 31);
            this.btnAlterarDados.TabIndex = 8;
            this.btnAlterarDados.Text = "Alterar Dados";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnNovo);
            this.panel.Controls.Add(this.btnIncluir);
            this.panel.Controls.Add(this.btnExcluir);
            this.panel.Controls.Add(this.cboId);
            this.panel.Controls.Add(this.lblPanel);
            this.panel.Controls.Add(this.btnAtualizar);
            this.panel.Controls.Add(this.txtDado3);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtDado2);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtDado1);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(56, 77);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(403, 217);
            this.panel.TabIndex = 12;
            this.panel.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(64, 178);
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
            this.btnIncluir.Location = new System.Drawing.Point(145, 178);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(307, 178);
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
            this.cboId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboId.Location = new System.Drawing.Point(57, 56);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(45, 21);
            this.cboId.TabIndex = 10;
            //this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
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
            this.btnAtualizar.Location = new System.Drawing.Point(226, 178);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtDado3
            // 
            this.txtDado3.Location = new System.Drawing.Point(57, 135);
            this.txtDado3.Name = "txtDado3";
            this.txtDado3.Size = new System.Drawing.Size(325, 20);
            this.txtDado3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dado3";
            // 
            // txtDado2
            // 
            this.txtDado2.Location = new System.Drawing.Point(57, 109);
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.Size = new System.Drawing.Size(325, 20);
            this.txtDado2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dado2";
            // 
            // txtDado1
            // 
            this.txtDado1.Location = new System.Drawing.Point(57, 83);
            this.txtDado1.Name = "txtDado1";
            this.txtDado1.Size = new System.Drawing.Size(325, 20);
            this.txtDado1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dado1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
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
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.btnSalvarDados);
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
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Button btnDeletarProduto;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtDado3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDado2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDado1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cboId;
    }
}

