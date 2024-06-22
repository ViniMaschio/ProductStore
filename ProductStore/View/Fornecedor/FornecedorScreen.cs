using ProductStore.Controler.Compra;
using ProductStore.Entidades.Compra;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Fornecedor
{
    public partial class FornecedorScreen : Form
    {
        public FornecedorScreen()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            FornecedorControler fornecedorControler = new FornecedorControler();

            dGVFornecedor.DataSource = fornecedorControler.BuscarTodosFornecedor();
            dGVFornecedor.Columns[0].Width = 50;
            dGVFornecedor.Columns[1].Width = 250;
            dGVFornecedor.Columns[2].Width = 100;
            dGVFornecedor.Columns[3].Width = 200;
            dGVFornecedor.Columns[4].Width = 200;
            dGVFornecedor.Columns[5].Width = 200;
            dGVFornecedor.Columns[6].Width = 150;
        }

        private FornecedorEntidade BuscarLinhaDataGrid()
        {
            FornecedorEntidade fornecedorEntidade = new FornecedorEntidade() { Id = 0 };

            if (dGVFornecedor.Rows.Count > 0)
            {
                fornecedorEntidade.Id = (int)dGVFornecedor.CurrentRow.Cells[0].Value;
                fornecedorEntidade.NomeFornecedor = dGVFornecedor.CurrentRow.Cells[1].Value.ToString();
            }

            return fornecedorEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {

            FornecedorForm fornecedorForm = new FornecedorForm(0);
            fornecedorForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {


            FornecedorEntidade fornecedorEntidade = BuscarLinhaDataGrid();

            FornecedorForm fornecedorForm = new FornecedorForm(fornecedorEntidade.Id);
            fornecedorForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntTelefone_Click(object sender, EventArgs e)
        {
            FornecedorEntidade fornecedorEntidade = BuscarLinhaDataGrid();

            TelefoneFornecedorScreen telefoneFornecedorScreen = new TelefoneFornecedorScreen(fornecedorEntidade.Id);
            telefoneFornecedorScreen.ShowDialog();

            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            FornecedorEntidade fornecedorEntidade = BuscarLinhaDataGrid();

            FornecedorControler fornecedorControler = new FornecedorControler();
            fornecedorControler.RemoverFornecedor(fornecedorEntidade);

            CarregarDataGrid();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
