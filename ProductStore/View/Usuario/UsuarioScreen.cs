using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStore.Controler.Login;
using ProductStore.Entidades.Login;

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