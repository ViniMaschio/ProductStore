using ProductStore.Controler.Funcionario;
using ProductStore.Controler.Login;
using ProductStore.Entidades.Funcionario;
using ProductStore.Entidades.Login;
using ProductStore.View.BoletosCompra;
using ProductStore.View.BoletosVenda;
using ProductStore.View.Cliente.Cliente;
using ProductStore.View.Cliente.Trabalho;
using ProductStore.View.Compra;
using ProductStore.View.Endereco;
using ProductStore.View.Endereco.Bairro;
using ProductStore.View.Endereco.Cep;
using ProductStore.View.Fornecedor;
using ProductStore.View.Funcionario.Funcao;
using ProductStore.View.Funcionario.Funcionario;
using ProductStore.View.Funcionario.Loja;
using ProductStore.View.Produto;
using ProductStore.View.Produto.Marca;
using ProductStore.View.Produto.Produto;
using ProductStore.View.Usuario;
using ProductStore.View.Venda;
using System;
using System.Windows.Forms;


namespace ProductStore.View
{
    public partial class HomeScreen : Form
    {
        public HomeScreen(LoginEntidade loginEntidade)
        {
            InitializeComponent();
            CarregarInformacao(loginEntidade);
            CarregarMenus(loginEntidade);
        }

        private void CarregarInformacao(LoginEntidade loginEntidade)
        {
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(loginEntidade.Funcionario);
            stripUsuario.Text = funcionarioEntidade.NomeFuncionario;
        }

        private void CarregarMenus(LoginEntidade loginEntidade)
        {
            ItensAcessoLoginControler itensAcessoLoginControler =  new ItensAcessoLoginControler();
            int acesso = itensAcessoLoginControler.BuscarAcessoPorLogin(loginEntidade.Id);

            switch (acesso)
            {
                case 1:
                    
                    break;
                case 2:
                    mnuCliente.Visible = false;
                    mnuProduto.Visible = false;
                    mnuVenda.Visible = false;
                    mnuCompra.Visible = false;
                    mnuFornecedor.Visible = false;
                    mnuFuncionario.Visible = false;
                    mnuUsuairo.Visible = false;
                    break;
                case 3:
                   
                    mnuCompra.Visible = false;
                    mnuFornecedor.Visible = false;
                    mnuFuncionario.Visible = false;
                    mnuUsuairo.Visible = false;
                    break;
                case 4:
                    mnuCliente.Visible = false;
                    mnuVenda.Visible = false;
                    mnuFuncionario.Visible = false;
                    mnuUsuairo.Visible = false;
                    break;
            }
        }

        private void menuStripTipo_Click(object sender, EventArgs e)
        {
            TipoScreen tipoScreen = new TipoScreen();
            tipoScreen.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            UsuarioScreen usuarioScreen = new UsuarioScreen();
            usuarioScreen.ShowDialog();
        }

        private void cadastroMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcaScreen marcaScreen = new MarcaScreen();
            marcaScreen.ShowDialog();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoScreen produtoScreen = new ProdutoScreen();
            produtoScreen.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrabalhoScreen trabalhoScreen = new TrabalhoScreen();
            trabalhoScreen.ShowDialog();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteScreen clienteScreen = new ClienteScreen();
            clienteScreen.ShowDialog();
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuaScrean ruaScrean = new RuaScrean();
            ruaScrean.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BairroScreen bairroScreen = new BairroScreen();
            bairroScreen.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CepScreen cepScreen = new CepScreen();
            cepScreen.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LojaScreen lojaScreen = new LojaScreen();
            lojaScreen.ShowDialog();
        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioScreen funcionarioScreen = new FuncionarioScreen();
            funcionarioScreen.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncaoScreen funcaoScreen = new FuncaoScreen();
            funcaoScreen.ShowDialog();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorScreen fornecedorScreen = new FornecedorScreen();
            fornecedorScreen.ShowDialog();
        }

        private void ruaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RuaScrean ruaScrean = new RuaScrean();
            ruaScrean.ShowDialog();
        }

        private void bairroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BairroScreen bairroScreen = new BairroScreen();
            bairroScreen.ShowDialog();
        }

        private void cepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CepScreen cepScreen = new CepScreen();
            cepScreen.ShowDialog();
        }

        private void ruaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RuaScrean ruaScrean = new RuaScrean();
            ruaScrean.ShowDialog();
        }

        private void bairroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BairroScreen bairroScreen = new BairroScreen();
            bairroScreen.ShowDialog();
        }

        private void cepToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CepScreen cepScreen = new CepScreen();
            cepScreen.ShowDialog();
        }

        private void entradaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraScreen compraScreen = new CompraScreen();
            compraScreen.ShowDialog();
        }

        private void vendaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaScreen vendaScreen = new VendaScreen();
            vendaScreen.ShowDialog();
        }

        private void boletosParaPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoletosCompraScreen boletosCompraScreen = new BoletosCompraScreen();
            boletosCompraScreen.ShowDialog();

        }

        private void boletosParaReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoletosVendaScreen boletosVendaScreen = new BoletosVendaScreen();
            boletosVendaScreen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stripHora.Text = DateTime.Now.ToString();
        }
    }
}
