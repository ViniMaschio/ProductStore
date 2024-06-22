using ProductStore.Controler.Funcionario;
using ProductStore.Controler.Login;
using ProductStore.Entidades.Login;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Usuario
{
    public partial class LoginForm : Form
    {
        public LoginForm(int codLogin)
        {
            InitializeComponent();

            CarregarFuncionario();
            CarregarAcesso();
            txtCod.Text = codLogin.ToString();
            if (codLogin != 0)
            {
                CarregarLogin(codLogin);
            }
        }

        private void CarregarFuncionario()
        {
            FuncionarioControler funcionarioControler = new FuncionarioControler();

            cBoxFuncionario.DataSource = funcionarioControler.BuscarTodosFuncionarios();
            cBoxFuncionario.DisplayMember = "Nome Funcionario";
            cBoxFuncionario.ValueMember = "ID";
            cBoxFuncionario.DropDownWidth = 200;
        }

        private void CarregarAcesso()
        {
            AcessoControler acessoControler = new AcessoControler();

            cBoxAcesso.DataSource = acessoControler.BuscarTodosAcesso();
            cBoxAcesso.DisplayMember = "Acesso";
            cBoxAcesso.ValueMember = "ID";
            cBoxAcesso.DropDownWidth = 200;
        }

        private void CarregarLogin(int codLogin)
        {
            LoginControler loginControler = new LoginControler();
            LoginEntidade loginEntidade = loginControler.BuscarLoginPorId(codLogin);

            ItensAcessoLoginControler itensAcessoLoginControler = new ItensAcessoLoginControler();

            txtUsuario.Text = loginEntidade.Usuario;
            txtSenha.Text = loginEntidade.Senha;
            cBoxFuncionario.SelectedValue = loginEntidade.Funcionario;
            cBoxAcesso.SelectedValue = itensAcessoLoginControler.BuscarAcessoPorLogin(codLogin);
        }

        private LoginEntidade BuscarEntidade()
        {
            LoginEntidade loginEntidade = new LoginEntidade();

            loginEntidade.Id = int.Parse(txtCod.Text.ToString());
            loginEntidade.Usuario = txtUsuario.Text;
            loginEntidade.Senha = txtSenha.Text;
            loginEntidade.Funcionario = int.Parse(cBoxFuncionario.SelectedValue.ToString());

            return loginEntidade;
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            LoginEntidade loginEntidade = BuscarEntidade();

            LoginControler loginControler = new LoginControler();

            if (loginEntidade.Id == 0)
            {

                loginControler.AdicionarLogin(loginEntidade, int.Parse(cBoxAcesso.SelectedValue.ToString()));
            }
            else
            {
                loginControler.AlterarLogin(loginEntidade, int.Parse(cBoxAcesso.SelectedValue.ToString()));
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
