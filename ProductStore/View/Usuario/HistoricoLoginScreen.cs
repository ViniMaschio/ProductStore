using ProductStore.Controler.Login;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Usuario
{
    public partial class HistoricoLoginScreen : Form
    {
        public HistoricoLoginScreen(int codLogin)
        {
            InitializeComponent();

            CarregarDataGrid(codLogin);
        }

        private void CarregarDataGrid(int codLogin)
        {
            ControleLogSistemaControler controleLogSistemaControler = new ControleLogSistemaControler();
            dGVControleLogin.DataSource = controleLogSistemaControler.BuscarTodosLogPorLogin(codLogin);
            dGVControleLogin.Columns[0].Width = 50;
            dGVControleLogin.Columns[1].Width = 250;
            dGVControleLogin.Columns[2].Width = 150;
            dGVControleLogin.Columns[3].Width = 200;
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
