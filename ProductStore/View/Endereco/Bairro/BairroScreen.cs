using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Endereco.Bairro
{
    public partial class BairroScreen : Form
    {
        public BairroScreen()
        {
            InitializeComponent();

            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            BairroControler bairroControler = new BairroControler();

            dGVBairro.DataSource = bairroControler.BuscarTodosBairro();
            dGVBairro.Columns[0].Width = 50;
            dGVBairro.Columns[1].Width = 280;
        }

        private BairroEntidade BucarLinhaDataGird()
        {
            BairroEntidade bairroEntidade = new BairroEntidade() { Id = 0 };

            if (dGVBairro.Rows.Count > 0)
            {
                bairroEntidade.Id = (int)dGVBairro.CurrentRow.Cells[0].Value;
                bairroEntidade.Bairro = (string)dGVBairro.CurrentRow.Cells[1].Value;
            }

            return bairroEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            BairroForm bairroForm = new BairroForm(0);
            bairroForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            BairroEntidade bairroEntidade = BucarLinhaDataGird();
            if (bairroEntidade.Id != 0)
            {
                BairroForm bairroForm = new BairroForm(bairroEntidade.Id);
                bairroForm.ShowDialog();
                CarregarDataGrid();
            }
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {

            BairroEntidade bairroEntidade = BucarLinhaDataGird();

            if (bairroEntidade.Id != 0)
            {
                BairroControler bairroControler = new BairroControler();
                bairroControler.RemoverBairro(bairroEntidade);

                CarregarDataGrid();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
