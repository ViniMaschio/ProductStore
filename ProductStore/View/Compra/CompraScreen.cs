using ProductStore.Controler.Compra;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Compra
{
    public partial class CompraScreen : Form
    {
        public CompraScreen()
        {
            InitializeComponent();

            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            CompraProdutoControler compraProdutoControler = new CompraProdutoControler();

            dGVCompraProduto.DataSource = compraProdutoControler.BuscarTodasCompras();
            dGVCompraProduto.Columns[0].Width = 50;
            dGVCompraProduto.Columns[1].Width = 250;
            dGVCompraProduto.Columns[2].Width = 250;
            dGVCompraProduto.Columns[3].Width = 150;
            dGVCompraProduto.Columns[4].Width = 140;
        }

        private int BuscarLinhaDataGrid()
        {
            int codCompra = 0;

            if (dGVCompraProduto.Rows.Count > 0)
            {
                codCompra = (int)dGVCompraProduto.CurrentRow.Cells[0].Value;

            }
            return codCompra;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            bntAdicionar compraForm = new bntAdicionar(0);
            compraForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntItens_Click(object sender, EventArgs e)
        {
            int codCompra = BuscarLinhaDataGrid();
            ProdutosCompraScreen produtosCompraScreen = new ProdutosCompraScreen(codCompra);
            produtosCompraScreen.ShowDialog();

        }


        private void Deletar_Click(object sender, EventArgs e)
        {
            int codCompra = BuscarLinhaDataGrid();
            CompraProdutoControler compraProdutoControler = new CompraProdutoControler();
            compraProdutoControler.DeletarCompra(codCompra);
            CarregarDataGrid();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
