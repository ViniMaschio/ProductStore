using ProductStore.Controler.Compra;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Compra
{
    public partial class ProdutosCompraScreen : Form
    {
        public ProdutosCompraScreen(int codCompra)
        {
            InitializeComponent();
            CarregarDataGrid(codCompra);
        }

        private void CarregarDataGrid(int codCompra)
        {
            ItensCompraProdutoControler itensCompraProdutoControler = new ItensCompraProdutoControler();
            dGVProdutosCompra.DataSource = itensCompraProdutoControler.BuscarTodosProdutosPorCompra(codCompra);
            dGVProdutosCompra.Columns[0].Width = 50;
            dGVProdutosCompra.Columns[1].Width = 250;
            dGVProdutosCompra.Columns[2].Width = 90;
            dGVProdutosCompra.Columns[3].Width = 130;
            dGVProdutosCompra.Columns[4].Width = 130;
            double total = 0;
            for (int i = 0; i < dGVProdutosCompra.Rows.Count; i++)
            {
                total += double.Parse(dGVProdutosCompra.Rows[i].Cells[4].Value.ToString());
            }
            txtValorTotal.Text = total.ToString();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
