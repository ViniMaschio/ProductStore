using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.View.Produto.Marca
{
    public partial class MarcaScreen : Form
    {
        public MarcaScreen()
        {
            InitializeComponent();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            MarcaEntidade marcaEntidade = new MarcaEntidade() { Id = 0, Marca = "" };

            MarcaForm marcaForm = new MarcaForm(marcaEntidade);

            marcaForm.ShowDialog();

            CarregarDataGrid();

        }

        private void MarcaScreen_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
        private void CarregarDataGrid()
        {
            MarcaControler marcaControler = new MarcaControler();
            DataTable dataTable = marcaControler.BuscarTodosMarca();

            dGVMarca.DataSource = dataTable;

            dGVMarca.Columns[0].Width = 50;
            dGVMarca.Columns[1].Width = 370;

        }

        private MarcaEntidade BuscarLinhaDataGrid()
        {
            MarcaEntidade marcaEntidade = new MarcaEntidade();

            if (dGVMarca.RowCount != 0)
            {
                marcaEntidade.Id = (int)dGVMarca.CurrentRow.Cells[0].Value;
                marcaEntidade.Marca = dGVMarca.CurrentRow.Cells[1].Value.ToString();
                return marcaEntidade;
            }
            return null;



        }

        private void bntEditar_Click(object sender, EventArgs e)
        {


            MarcaEntidade marcaEntidade = BuscarLinhaDataGrid();
            if (marcaEntidade != null)
            {

                MarcaForm marcaForm = new MarcaForm(marcaEntidade);

                marcaForm.ShowDialog();

                CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Não tem marca para editar", "Erro Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            MarcaControler marcaControler = new MarcaControler();

            MarcaEntidade marcaEntidade = BuscarLinhaDataGrid();
            if (marcaEntidade != null)
            {
                marcaControler.ExcluirMarca(marcaEntidade);

                CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Não tem marca para Excluir", "Erro Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
