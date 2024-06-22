using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Endereco.Cep
{
    public partial class CepScreen : Form
    {
        public CepScreen()
        {
            InitializeComponent();

            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            CepControler cepControler = new CepControler();

            dGVcep.DataSource = cepControler.BuscarTodosCep();
            dGVcep.Columns[0].Width = 50;
            dGVcep.Columns[1].Width = 150;
        }

        private CepEntidade BuscarLinhaDataGrid()
        {
            CepEntidade cepEntidade = new CepEntidade() { Id = 0 };

            if (dGVcep.RowCount > 0)
            {
                cepEntidade.Id = int.Parse(dGVcep.CurrentRow.Cells[0].Value.ToString());
                cepEntidade.Cep = dGVcep.CurrentRow.Cells[1].Value.ToString();
            }

            return cepEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            CepForm cepForm = new CepForm(0);
            cepForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            CepEntidade cepEntidade = BuscarLinhaDataGrid();

            CepForm cepForm = new CepForm(cepEntidade.Id);
            cepForm.ShowDialog();

            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            CepEntidade cepEntidade = BuscarLinhaDataGrid();
            CepControler cepControler = new CepControler();

            cepControler.ApagarCep(cepEntidade);

            CarregarDataGrid();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
