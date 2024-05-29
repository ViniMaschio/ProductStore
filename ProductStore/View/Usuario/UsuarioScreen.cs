using ProductStore.Controler.Login;
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

        void CarregarDataGrid()
        {
            LoginControler loginControler = new LoginControler();

            DataTable lista = loginControler.BuscarTodosLogin();

            dGWUsuario.DataSource = lista;

        }
    }
}