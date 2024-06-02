namespace ProductStore.View.Compra
{
    partial class bntAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.dGVItensCompra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.bntAdicionarProduto = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.cBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.bntRemover = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataCompra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.bntNovoFuncionario = new System.Windows.Forms.Button();
            this.bntNovoFornecedor = new System.Windows.Forms.Button();
            this.bntNovoProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItensCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Produtos";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(463, 553);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(107, 36);
            this.bntSalvar.TabIndex = 1;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(576, 553);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(107, 36);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // dGVItensCompra
            // 
            this.dGVItensCompra.AllowUserToAddRows = false;
            this.dGVItensCompra.AllowUserToDeleteRows = false;
            this.dGVItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeProduto,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal});
            this.dGVItensCompra.Location = new System.Drawing.Point(12, 170);
            this.dGVItensCompra.Name = "dGVItensCompra";
            this.dGVItensCompra.ReadOnly = true;
            this.dGVItensCompra.Size = new System.Drawing.Size(727, 314);
            this.dGVItensCompra.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Itens da Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produtos:";
            // 
            // cBoxProdutos
            // 
            this.cBoxProdutos.FormattingEnabled = true;
            this.cBoxProdutos.Location = new System.Drawing.Point(754, 198);
            this.cBoxProdutos.Name = "cBoxProdutos";
            this.cBoxProdutos.Size = new System.Drawing.Size(427, 31);
            this.cBoxProdutos.TabIndex = 6;
            this.cBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.cBoxProdutos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1060, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(785, 298);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 31);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(1064, 298);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(117, 31);
            this.txtValorUnit.TabIndex = 10;
            this.txtValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntAdicionarProduto
            // 
            this.bntAdicionarProduto.Location = new System.Drawing.Point(841, 371);
            this.bntAdicionarProduto.Name = "bntAdicionarProduto";
            this.bntAdicionarProduto.Size = new System.Drawing.Size(119, 36);
            this.bntAdicionarProduto.TabIndex = 11;
            this.bntAdicionarProduto.Text = "Adicionar";
            this.bntAdicionarProduto.UseVisualStyleBackColor = true;
            this.bntAdicionarProduto.Click += new System.EventHandler(this.bntAdicionarProduto_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(174, 67);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(131, 23);
            this.F.TabIndex = 12;
            this.F.Text = "Funcionario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fornecedor:";
            // 
            // cBoxFuncionario
            // 
            this.cBoxFuncionario.FormattingEnabled = true;
            this.cBoxFuncionario.Location = new System.Drawing.Point(178, 93);
            this.cBoxFuncionario.Name = "cBoxFuncionario";
            this.cBoxFuncionario.Size = new System.Drawing.Size(317, 31);
            this.cBoxFuncionario.TabIndex = 14;
            // 
            // cBoxFornecedor
            // 
            this.cBoxFornecedor.FormattingEnabled = true;
            this.cBoxFornecedor.Location = new System.Drawing.Point(581, 93);
            this.cBoxFornecedor.Name = "cBoxFornecedor";
            this.cBoxFornecedor.Size = new System.Drawing.Size(353, 31);
            this.cBoxFornecedor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Compra:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(611, 484);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(128, 31);
            this.txtTotalCompra.TabIndex = 17;
            this.txtTotalCompra.Text = "0";
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(966, 371);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(119, 36);
            this.bntRemover.TabIndex = 18;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1026, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data Compra:";
            // 
            // dataCompra
            // 
            this.dataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataCompra.Location = new System.Drawing.Point(1016, 93);
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.Size = new System.Drawing.Size(154, 31);
            this.dataCompra.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Codigo:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(34, 93);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(68, 31);
            this.txtCod.TabIndex = 22;
            // 
            // bntNovoFuncionario
            // 
            this.bntNovoFuncionario.Location = new System.Drawing.Point(300, 63);
            this.bntNovoFuncionario.Name = "bntNovoFuncionario";
            this.bntNovoFuncionario.Size = new System.Drawing.Size(24, 30);
            this.bntNovoFuncionario.TabIndex = 24;
            this.bntNovoFuncionario.Text = "+";
            this.bntNovoFuncionario.UseVisualStyleBackColor = true;
            this.bntNovoFuncionario.Click += new System.EventHandler(this.bntNovoFuncionario_Click);
            // 
            // bntNovoFornecedor
            // 
            this.bntNovoFornecedor.Location = new System.Drawing.Point(709, 63);
            this.bntNovoFornecedor.Name = "bntNovoFornecedor";
            this.bntNovoFornecedor.Size = new System.Drawing.Size(24, 30);
            this.bntNovoFornecedor.TabIndex = 25;
            this.bntNovoFornecedor.Text = "+";
            this.bntNovoFornecedor.UseVisualStyleBackColor = true;
            this.bntNovoFornecedor.Click += new System.EventHandler(this.bntNovoFornecedor_Click);
            // 
            // bntNovoProduto
            // 
            this.bntNovoProduto.Location = new System.Drawing.Point(859, 165);
            this.bntNovoProduto.Name = "bntNovoProduto";
            this.bntNovoProduto.Size = new System.Drawing.Size(24, 30);
            this.bntNovoProduto.TabIndex = 26;
            this.bntNovoProduto.Text = "+";
            this.bntNovoProduto.UseVisualStyleBackColor = true;
            this.bntNovoProduto.Click += new System.EventHandler(this.bntNovoProduto_Click);
            // 
            // bntAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 617);
            this.Controls.Add(this.bntNovoProduto);
            this.Controls.Add(this.bntNovoFornecedor);
            this.Controls.Add(this.bntNovoFuncionario);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxFornecedor);
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
            this.Controls.Add(this.dGVItensCompra);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bntAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGVItensCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.DataGridView dGVItensCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Button bntAdicionarProduto;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxFuncionario;
        private System.Windows.Forms.ComboBox cBoxFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dataCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button bntNovoFuncionario;
        private System.Windows.Forms.Button bntNovoFornecedor;
        private System.Windows.Forms.Button bntNovoProduto;
    }
}