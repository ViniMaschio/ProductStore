namespace ProductStore.View
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enderecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enderecoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enderecoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuairo = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosParaPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosParaReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProduto,
            this.mnuCliente,
            this.mnuVenda,
            this.mnuCompra,
            this.mnuFornecedor,
            this.mnuFinanceiro,
            this.mnuFuncionario,
            this.mnuUsuairo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuProduto
            // 
            this.mnuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripTipo,
            this.cadastroMarcaToolStripMenuItem,
            this.cadastroDeProdutoToolStripMenuItem});
            this.mnuProduto.Name = "mnuProduto";
            this.mnuProduto.Size = new System.Drawing.Size(62, 20);
            this.mnuProduto.Text = "Produto";
            // 
            // menuStripTipo
            // 
            this.menuStripTipo.Name = "menuStripTipo";
            this.menuStripTipo.Size = new System.Drawing.Size(183, 22);
            this.menuStripTipo.Text = "Cadastro de Tipo";
            this.menuStripTipo.Click += new System.EventHandler(this.menuStripTipo_Click);
            // 
            // cadastroMarcaToolStripMenuItem
            // 
            this.cadastroMarcaToolStripMenuItem.Name = "cadastroMarcaToolStripMenuItem";
            this.cadastroMarcaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cadastroMarcaToolStripMenuItem.Text = "Cadastro de Marca";
            this.cadastroMarcaToolStripMenuItem.Click += new System.EventHandler(this.cadastroMarcaToolStripMenuItem_Click);
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutoToolStripMenuItem_Click);
            // 
            // mnuCliente
            // 
            this.mnuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabalhoToolStripMenuItem,
            this.cadastroClienteToolStripMenuItem,
            this.enderecoToolStripMenuItem});
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(56, 20);
            this.mnuCliente.Text = "Cliente";
            // 
            // trabalhoToolStripMenuItem
            // 
            this.trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            this.trabalhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trabalhoToolStripMenuItem.Text = "Trabalho";
            this.trabalhoToolStripMenuItem.Click += new System.EventHandler(this.trabalhoToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // enderecoToolStripMenuItem
            // 
            this.enderecoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruaToolStripMenuItem,
            this.bairroToolStripMenuItem,
            this.cepToolStripMenuItem});
            this.enderecoToolStripMenuItem.Name = "enderecoToolStripMenuItem";
            this.enderecoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enderecoToolStripMenuItem.Text = "Endereco";
            // 
            // ruaToolStripMenuItem
            // 
            this.ruaToolStripMenuItem.Name = "ruaToolStripMenuItem";
            this.ruaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ruaToolStripMenuItem.Text = "Rua";
            this.ruaToolStripMenuItem.Click += new System.EventHandler(this.ruaToolStripMenuItem_Click);
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bairroToolStripMenuItem.Text = "Bairro";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.bairroToolStripMenuItem_Click);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.cepToolStripMenuItem.Text = "Cep";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.cepToolStripMenuItem_Click);
            // 
            // mnuFuncionario
            // 
            this.mnuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaToolStripMenuItem,
            this.cadastroFuncionarioToolStripMenuItem,
            this.funçãoToolStripMenuItem,
            this.enderecoToolStripMenuItem1});
            this.mnuFuncionario.Name = "mnuFuncionario";
            this.mnuFuncionario.Size = new System.Drawing.Size(82, 20);
            this.mnuFuncionario.Text = "Funcionario";
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.lojaToolStripMenuItem.Text = "Loja";
            this.lojaToolStripMenuItem.Click += new System.EventHandler(this.lojaToolStripMenuItem_Click);
            // 
            // cadastroFuncionarioToolStripMenuItem
            // 
            this.cadastroFuncionarioToolStripMenuItem.Name = "cadastroFuncionarioToolStripMenuItem";
            this.cadastroFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastroFuncionarioToolStripMenuItem.Text = "Cadastro Funcionario";
            this.cadastroFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroFuncionarioToolStripMenuItem_Click);
            // 
            // funçãoToolStripMenuItem
            // 
            this.funçãoToolStripMenuItem.Name = "funçãoToolStripMenuItem";
            this.funçãoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.funçãoToolStripMenuItem.Text = "Função";
            this.funçãoToolStripMenuItem.Click += new System.EventHandler(this.funçãoToolStripMenuItem_Click);
            // 
            // enderecoToolStripMenuItem1
            // 
            this.enderecoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruaToolStripMenuItem1,
            this.bairroToolStripMenuItem1,
            this.cepToolStripMenuItem1});
            this.enderecoToolStripMenuItem1.Name = "enderecoToolStripMenuItem1";
            this.enderecoToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.enderecoToolStripMenuItem1.Text = "Endereco";
            // 
            // ruaToolStripMenuItem1
            // 
            this.ruaToolStripMenuItem1.Name = "ruaToolStripMenuItem1";
            this.ruaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.ruaToolStripMenuItem1.Text = "Rua";
            this.ruaToolStripMenuItem1.Click += new System.EventHandler(this.ruaToolStripMenuItem1_Click);
            // 
            // bairroToolStripMenuItem1
            // 
            this.bairroToolStripMenuItem1.Name = "bairroToolStripMenuItem1";
            this.bairroToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.bairroToolStripMenuItem1.Text = "Bairro";
            this.bairroToolStripMenuItem1.Click += new System.EventHandler(this.bairroToolStripMenuItem1_Click);
            // 
            // cepToolStripMenuItem1
            // 
            this.cepToolStripMenuItem1.Name = "cepToolStripMenuItem1";
            this.cepToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.cepToolStripMenuItem1.Text = "Cep";
            this.cepToolStripMenuItem1.Click += new System.EventHandler(this.cepToolStripMenuItem1_Click);
            // 
            // mnuCompra
            // 
            this.mnuCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeProdutoToolStripMenuItem});
            this.mnuCompra.Name = "mnuCompra";
            this.mnuCompra.Size = new System.Drawing.Size(62, 20);
            this.mnuCompra.Text = "Compra";
            // 
            // entradaDeProdutoToolStripMenuItem
            // 
            this.entradaDeProdutoToolStripMenuItem.Name = "entradaDeProdutoToolStripMenuItem";
            this.entradaDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entradaDeProdutoToolStripMenuItem.Text = "Entrada de Produto";
            this.entradaDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProdutoToolStripMenuItem_Click);
            // 
            // mnuVenda
            // 
            this.mnuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaDeProdutoToolStripMenuItem});
            this.mnuVenda.Name = "mnuVenda";
            this.mnuVenda.Size = new System.Drawing.Size(51, 20);
            this.mnuVenda.Text = "Venda";
            // 
            // vendaDeProdutoToolStripMenuItem
            // 
            this.vendaDeProdutoToolStripMenuItem.Name = "vendaDeProdutoToolStripMenuItem";
            this.vendaDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendaDeProdutoToolStripMenuItem.Text = "Venda de Produto";
            this.vendaDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.vendaDeProdutoToolStripMenuItem_Click);
            // 
            // mnuFornecedor
            // 
            this.mnuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFornecedorToolStripMenuItem,
            this.enderecoToolStripMenuItem2});
            this.mnuFornecedor.Name = "mnuFornecedor";
            this.mnuFornecedor.Size = new System.Drawing.Size(79, 20);
            this.mnuFornecedor.Text = "Fornecedor";
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // enderecoToolStripMenuItem2
            // 
            this.enderecoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruaToolStripMenuItem2,
            this.bairroToolStripMenuItem2,
            this.cepToolStripMenuItem2});
            this.enderecoToolStripMenuItem2.Name = "enderecoToolStripMenuItem2";
            this.enderecoToolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.enderecoToolStripMenuItem2.Text = "Endereco";
            // 
            // ruaToolStripMenuItem2
            // 
            this.ruaToolStripMenuItem2.Name = "ruaToolStripMenuItem2";
            this.ruaToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.ruaToolStripMenuItem2.Text = "Rua";
            this.ruaToolStripMenuItem2.Click += new System.EventHandler(this.ruaToolStripMenuItem2_Click);
            // 
            // bairroToolStripMenuItem2
            // 
            this.bairroToolStripMenuItem2.Name = "bairroToolStripMenuItem2";
            this.bairroToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.bairroToolStripMenuItem2.Text = "Bairro";
            this.bairroToolStripMenuItem2.Click += new System.EventHandler(this.bairroToolStripMenuItem2_Click);
            // 
            // cepToolStripMenuItem2
            // 
            this.cepToolStripMenuItem2.Name = "cepToolStripMenuItem2";
            this.cepToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.cepToolStripMenuItem2.Text = "Cep";
            this.cepToolStripMenuItem2.Click += new System.EventHandler(this.cepToolStripMenuItem2_Click);
            // 
            // mnuUsuairo
            // 
            this.mnuUsuairo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1});
            this.mnuUsuairo.Name = "mnuUsuairo";
            this.mnuUsuairo.Size = new System.Drawing.Size(59, 20);
            this.mnuUsuairo.Text = "Usuario";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // mnuFinanceiro
            // 
            this.mnuFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletosParaPagarToolStripMenuItem,
            this.boletosParaReceberToolStripMenuItem});
            this.mnuFinanceiro.Name = "mnuFinanceiro";
            this.mnuFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.mnuFinanceiro.Text = "Financeiro";
            // 
            // boletosParaPagarToolStripMenuItem
            // 
            this.boletosParaPagarToolStripMenuItem.Name = "boletosParaPagarToolStripMenuItem";
            this.boletosParaPagarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.boletosParaPagarToolStripMenuItem.Text = "Boletos para Pagar";
            this.boletosParaPagarToolStripMenuItem.Click += new System.EventHandler(this.boletosParaPagarToolStripMenuItem_Click);
            // 
            // boletosParaReceberToolStripMenuItem
            // 
            this.boletosParaReceberToolStripMenuItem.Name = "boletosParaReceberToolStripMenuItem";
            this.boletosParaReceberToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.boletosParaReceberToolStripMenuItem.Text = "Boletos para Receber";
            this.boletosParaReceberToolStripMenuItem.Click += new System.EventHandler(this.boletosParaReceberToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stripHora,
            this.toolStripStatusLabel2,
            this.stripUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 18);
            this.toolStripStatusLabel1.Text = "Data / Hora:";
            // 
            // stripHora
            // 
            this.stripHora.Name = "stripHora";
            this.stripHora.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(77, 18);
            this.toolStripStatusLabel2.Text = "Usuario:";
            // 
            // stripUsuario
            // 
            this.stripUsuario.Name = "stripUsuario";
            this.stripUsuario.Size = new System.Drawing.Size(0, 18);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuStripTipo;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuairo;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enderecoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enderecoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enderecoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCompra;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVenda;
        private System.Windows.Forms.ToolStripMenuItem vendaDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem boletosParaPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosParaReceberToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stripUsuario;
    }
}