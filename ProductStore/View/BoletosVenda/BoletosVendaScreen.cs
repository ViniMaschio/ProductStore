using ProductStore.Controler.Boletos;
using ProductStore.Entidades.Boletos;
using System;
using System.Windows.Forms;

namespace ProductStore.View.BoletosVenda
{
    public partial class BoletosVendaScreen : Form
    {
        public BoletosVendaScreen()
        {
            InitializeComponent();
            CarregarDataGridEmAberto();
        }

        private void CarregarDataGridEmAberto()
        {
            ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();

            dGVBoletoFornecedor.DataSource = parcelaVendaControler.BuscarParcelasEmAberto();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;

        }

        private void CarregarDataGridPagas()
        {
            ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();

            dGVBoletoFornecedor.DataSource = parcelaVendaControler.BuscarParcelasPagas();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;
        }

        private void CarregarDataGridTodas()
        {
            ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();

            dGVBoletoFornecedor.DataSource = parcelaVendaControler.BuscarTodasParcelas();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;
        }

        private ParcelaVendaEntidade BuscarLinhadaDataGird()
        {
            ParcelaVendaEntidade parcelaVendaEntidade = new ParcelaVendaEntidade() { CodParcela = 0, CodVenda = 0 };

            if (dGVBoletoFornecedor.Rows.Count > 0)
            {
                parcelaVendaEntidade.CodParcela = (int)dGVBoletoFornecedor.CurrentRow.Cells[0].Value;
                parcelaVendaEntidade.CodVenda = (int)dGVBoletoFornecedor.CurrentRow.Cells[1].Value;
            }

            return parcelaVendaEntidade;
        }

        private void radioAbertos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridEmAberto();
        }

        private void radioTodosPagos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridPagas();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridTodas();
        }

        private void bntPagar_Click(object sender, EventArgs e)
        {
            ParcelaVendaEntidade parcelaVendaEntidade = BuscarLinhadaDataGird();

            if (parcelaVendaEntidade.CodVenda != 0)
            {
                ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();
                parcelaVendaControler.Pagar(parcelaVendaEntidade);

                CarregarDataGridEmAberto();
                radioAbertos.Select();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntReceber_Click(object sender, EventArgs e)
        {
            ParcelaVendaEntidade parcelaVendaEntidade = BuscarLinhadaDataGird();

            if (parcelaVendaEntidade.CodVenda != 0)
            {
                ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();
                parcelaVendaControler.Pagar(parcelaVendaEntidade);

                CarregarDataGridEmAberto();
                radioAbertos.Select();
            }
        }
    }
}

