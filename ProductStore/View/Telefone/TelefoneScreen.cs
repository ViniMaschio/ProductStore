using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Telefone
{
    public partial class TelefoneScreen : Form
    {
        public TelefoneScreen()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            TelefoneControler telefoneControler = new TelefoneControler();
            dGVTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            dGVTelefone.Columns[0].Width = 50;
            dGVTelefone.Columns[1].Width = 150;
            dGVTelefone.Columns[2].Width = 100;
        }

        private TelefoneEntidade BuscarLinhaDataGrid()
        {
            TelefoneEntidade telefoneEntidade = new TelefoneEntidade() { Id = 0 };
            if (dGVTelefone.Rows.Count > 0)
            {
                telefoneEntidade.Id = (int)dGVTelefone.CurrentRow.Cells[0].Value;
                telefoneEntidade.Telefone = dGVTelefone.CurrentRow.Cells[1].Value.ToString();
            }

            return telefoneEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            TelefoneForm telefoneForm = new TelefoneForm(0);
            telefoneForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            TelefoneEntidade telefoneEntidade = BuscarLinhaDataGrid();

            if (telefoneEntidade.Id != 0)
            {
                TelefoneControler telefoneControler = new TelefoneControler();
                telefoneControler.DeletarTelefone(telefoneEntidade);
            }
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            TelefoneEntidade telefoneEntidade = BuscarLinhaDataGrid();

            if (telefoneEntidade.Id != 0)
            {
                TelefoneForm telefoneForm1 = new TelefoneForm(telefoneEntidade.Id);
                telefoneForm1.ShowDialog();
            }
            CarregarDataGrid();

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
