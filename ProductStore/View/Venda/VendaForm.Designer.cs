namespace ProductStore.View.Venda
{
    partial class VendaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntNovoProduto = new System.Windows.Forms.Button();
            this.bntNovoFornecedor = new System.Windows.Forms.Button();
            this.bntNovoFuncionario = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataVenda = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bntRemover = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxCliente = new System.Windows.Forms.ComboBox();
            this.cBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.bntAdicionarProduto = new System.Windows.Forms.Button();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVItensVenda = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovoProduto
            // 
            this.bntNovoProduto.Location = new System.Drawing.Point(856, 165);
            this.bntNovoProduto.Name = "bntNovoProduto";
            this.bntNovoProduto.Size = new System.Drawing.Size(24, 30);
            this.bntNovoProduto.TabIndex = 52;
            this.bntNovoProduto.Text = "+";
            this.bntNovoProduto.UseVisualStyleBackColor = true;
            this.bntNovoProduto.Click += new System.EventHandler(this.bntNovoProduto_Click);
            // 
            // bntNovoFornecedor
            // 
            this.bntNovoFornecedor.Location = new System.Drawing.Point(665, 63);
            this.bntNovoFornecedor.Name = "bntNovoFornecedor";
            this.bntNovoFornecedor.Size = new System.Drawing.Size(24, 30);
            this.bntNovoFornecedor.TabIndex = 51;
            this.bntNovoFornecedor.Text = "+";
            this.bntNovoFornecedor.UseVisualStyleBackColor = true;
            this.bntNovoFornecedor.Click += new System.EventHandler(this.bntNovoFornecedor_Click);
            // 
            // bntNovoFuncionario
            // 
            this.bntNovoFuncionario.Location = new System.Drawing.Point(297, 63);
            this.bntNovoFuncionario.Name = "bntNovoFuncionario";
            this.bntNovoFuncionario.Size = new System.Drawing.Size(24, 30);
            this.bntNovoFuncionario.TabIndex = 50;
            this.bntNovoFuncionario.Text = "+";
            this.bntNovoFuncionario.UseVisualStyleBackColor = true;
            this.bntNovoFuncionario.Click += new System.EventHandler(this.bntNovoFuncionario_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(31, 93);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(68, 31);
            this.txtCod.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Codigo:";
            // 
            // dataVenda
            // 
            this.dataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataVenda.Location = new System.Drawing.Point(1013, 93);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.Size = new System.Drawing.Size(154, 31);
            this.dataVenda.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1023, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Data Venda:";
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(963, 371);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(119, 36);
            this.bntRemover.TabIndex = 45;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(608, 484);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(128, 31);
            this.txtTotalVenda.TabIndex = 44;
            this.txtTotalVenda.Text = "0";
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total Venda:";
            // 
            // cBoxCliente
            // 
            this.cBoxCliente.FormattingEnabled = true;
            this.cBoxCliente.Location = new System.Drawing.Point(578, 93);
            this.cBoxCliente.Name = "cBoxCliente";
            this.cBoxCliente.Size = new System.Drawing.Size(353, 31);
            this.cBoxCliente.TabIndex = 42;
            // 
            // cBoxFuncionario
            // 
            this.cBoxFuncionario.FormattingEnabled = true;
            this.cBoxFuncionario.Location = new System.Drawing.Point(175, 93);
            this.cBoxFuncionario.Name = "cBoxFuncionario";
            this.cBoxFuncionario.Size = new System.Drawing.Size(317, 31);
            this.cBoxFuncionario.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cliente:";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(171, 67);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(131, 23);
            this.F.TabIndex = 39;
            this.F.Text = "Funcionario:";
            // 
            // bntAdicionarProduto
            // 
            this.bntAdicionarProduto.Location = new System.Drawing.Point(838, 371);
            this.bntAdicionarProduto.Name = "bntAdicionarProduto";
            this.bntAdicionarProduto.Size = new System.Drawing.Size(119, 36);
            this.bntAdicionarProduto.TabIndex = 38;
            this.bntAdicionarProduto.Text = "Adicionar";
            this.bntAdicionarProduto.UseVisualStyleBackColor = true;
            this.bntAdicionarProduto.Click += new System.EventHandler(this.bntAdicionarProduto_Click);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(1061, 298);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(117, 31);
            this.txtValorUnit.TabIndex = 37;
            this.txtValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(782, 298);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 31);
            this.txtQuantidade.TabIndex = 36;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1057, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantidade:";
            // 
            // cBoxProdutos
            // 
            this.cBoxProdutos.FormattingEnabled = true;
            this.cBoxProdutos.Location = new System.Drawing.Point(751, 198);
            this.cBoxProdutos.Name = "cBoxProdutos";
            this.cBoxProdutos.Size = new System.Drawing.Size(427, 31);
            this.cBoxProdutos.TabIndex = 33;
            this.cBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.cBoxProdutos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Itens da Compra";
            // 
            // dGVItensVenda
            // 
            this.dGVItensVenda.AllowUserToAddRows = false;
            this.dGVItensVenda.AllowUserToDeleteRows = false;
            this.dGVItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeProduto,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal});
            this.dGVItensVenda.Location = new System.Drawing.Point(9, 170);
            this.dGVItensVenda.Name = "dGVItensVenda";
            this.dGVItensVenda.ReadOnly = true;
            this.dGVItensVenda.Size = new System.Drawing.Size(727, 314);
            this.dGVItensVenda.TabIndex = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeProduto.Width = 250;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quant.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor Uni.";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorUnitario.Width = 130;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorTotal.Width = 150;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(608, 551);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(107, 36);
            this.bntSair.TabIndex = 29;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(495, 551);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(107, 36);
            this.bntSalvar.TabIndex = 28;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Compra de Produtos";
            // 
            // VendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 610);
            this.Controls.Add(this.bntNovoProduto);
            this.Controls.Add(this.bntNovoFornecedor);
            this.Controls.Add(this.bntNovoFuncionario);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxCliente);
            this.Controls.Add(this.cBoxFuncionario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F);
            this.Controls.Add(this.bntAdicionarProduto);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVItensVenda);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGVItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNovoProduto;
        private System.Windows.Forms.Button bntNovoFornecedor;
        private System.Windows.Forms.Button bntNovoFuncionario;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxCliente;
        private System.Windows.Forms.ComboBox cBoxFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Button bntAdicionarProduto;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Label label1;
    }
}