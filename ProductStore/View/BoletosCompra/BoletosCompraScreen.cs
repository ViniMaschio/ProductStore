using ProductStore.Controler.Boletos;
using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.BoletosCompra
{
    public partial class BoletosCompraScreen : Form
    {
        public BoletosCompraScreen()
        {
            InitializeComponent();
            CarregarDataGirdEmAberto();
        }

        private void CarregarDataGirdEmAberto()
        {
            ParcelaCompraControler parcelaCompraControler = new ParcelaCompraControler();
            dGVBoletoFornecedor.DataSource = parcelaCompraControler.BuscarTodasParcelasEmAberto();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;

        }

        private void CarregarDataGridPagas()
        {
            ParcelaCompraControler parcelaCompraControler = new ParcelaCompraControler();
            dGVBoletoFornecedor.DataSource = parcelaCompraControler.BuscarTodasParcelasPagas();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;

        }

        private void CarregarDataGridTodasParcelas()
        {
            ParcelaCompraControler parcelaCompraControler = new ParcelaCompraControler();
            dGVBoletoFornecedor.DataSource = parcelaCompraControler.BuscarTodasParcelas();
            dGVBoletoFornecedor.Columns[0].Width = 100;
            dGVBoletoFornecedor.Columns[1].Width = 100;
            dGVBoletoFornecedor.Columns[2].Width = 150;
            dGVBoletoFornecedor.Columns[3].Width = 120;
            dGVBoletoFornecedor.Columns[4].Width = 170;
        }

        private ParcelaCompraEntidade BuscarLinhaDataGird()
        {
            ParcelaCompraEntidade parcelaCompraEntidade = new ParcelaCompraEntidade() { CodCompra = 0,CodParcela = 0};

            if(dGVBoletoFornecedor.Rows.Count > 0)
            {
                parcelaCompraEntidade.CodParcela = int.Parse(dGVBoletoFornecedor.CurrentRow.Cells[0].Value.ToString());
                parcelaCompraEntidade.CodCompra = int.Parse(dGVBoletoFornecedor.CurrentRow.Cells[1].Value.ToString());
            }
            return parcelaCompraEntidade;
        }

        private void radioAbertos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGirdEmAberto();
        }

        private void radioTodosPagos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridPagas();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridTodasParcelas();
        }

        private void bntPagar_Click(object sender, EventArgs e)
        {
            ParcelaCompraEntidade parcelaCompraEntidade = BuscarLinhaDataGird();
            ParcelaCompraControler parcelaCompraControler = new ParcelaCompraControler();
            parcelaCompraControler.PagarBoleto(parcelaCompraEntidade);

            radioAbertos.Select();
            CarregarDataGirdEmAberto();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
