using ProductStore.Controler.Venda;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Venda
{
    public partial class ItensVendaScreen : Form
    {
        public ItensVendaScreen(int codVenda)
        {
            InitializeComponent();
            CarregarDataGird(codVenda);
        }

        private void CarregarDataGird(int codVenda)
        {
            ItensVendaProdutoControler itensVendaProdutoControler = new ItensVendaProdutoControler();

            dGVProdutosCompra.DataSource = itensVendaProdutoControler.BuscarVendaProdutosPorVenda(codVenda);
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
