using ProductStore.Controler.Login;
using ProductStore.Entidades.Login;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.View.Usuario
{
    public partial class UsuarioScreen : Form
    {
        public UsuarioScreen()
        {
            InitializeComponent();
        }

        private void UsuarioScreen_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            LoginControler loginControler = new LoginControler();

            dGVLogins.DataSource = loginControler.BuscarTodosLogin();
            dGVLogins.Columns[0].Width = 50;
            dGVLogins.Columns[1].Width = 250;
            dGVLogins.Columns[2].Width = 150;
            dGVLogins.Columns[3].Width = 250;

        }

        private LoginEntidade BuscarLinhaDataGrid()
        {
            LoginEntidade loginEntidade = new LoginEntidade() { Id = 0 };

            if (dGVLogins.Rows.Count > 0)
            {
                loginEntidade.Id = (int)dGVLogins.CurrentRow.Cells[0].Value;
                loginEntidade.Usuario = dGVLogins.CurrentRow.Cells[1].Value.ToString();
            }

            return loginEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(0);
            loginForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            LoginEntidade loginEntidade = BuscarLinhaDataGrid();
            LoginControler loginControler = new LoginControler();   
            loginControler.ApagarLogin(loginEntidade);
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            LoginEntidade LoginEntidade = BuscarLinhaDataGrid();
            if (LoginEntidade.Id != 0)
            {
                LoginForm loginForm = new LoginForm(LoginEntidade.Id);
                loginForm.ShowDialog();
                CarregarDataGrid();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntHistorico_Click(object sender, EventArgs e)
        {
            LoginEntidade loginEntidade = BuscarLinhaDataGrid();
            HistoricoLoginScreen historicoLoginScreen = new HistoricoLoginScreen(loginEntidade.Id);
            historicoLoginScreen.ShowDialog();
        }
    }
}