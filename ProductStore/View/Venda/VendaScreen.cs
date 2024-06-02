using ProductStore.Controler.Venda;
using ProductStore.Entidades.Venda;
using System.Windows.Forms;

namespace ProductStore.View.Venda
{
    public partial class VendaScreen : Form
    {
        public VendaScreen()
        {
            InitializeComponent();

            CarregarDataGird();
        }

        private void CarregarDataGird()
        {
            VendaProdutoControler vendaProdutoControler = new VendaProdutoControler();
            dGVVendaProduto.DataSource = vendaProdutoControler.BuscarTodasVendas();
            dGVVendaProduto.Columns[0].Width = 50;
            dGVVendaProduto.Columns[1].Width = 250;
            dGVVendaProduto.Columns[2].Width = 250;
            dGVVendaProduto.Columns[3].Width = 150;
            dGVVendaProduto.Columns[4].Width = 150;
        }

        private VendaProdutoEntidade BuscarLinhaDataGrid()
        {
            VendaProdutoEntidade vendaProdutoEntidade = new VendaProdutoEntidade() { Id = 0 };

            if (dGVVendaProduto.Rows.Count > 0)
            {
                vendaProdutoEntidade.Id = (int)dGVVendaProduto.CurrentRow.Cells[0].Value;
            }
            return vendaProdutoEntidade;
        }

        private void bntNovo_Click(object sender, System.EventArgs e)
        {
            VendaForm vendaForm = new VendaForm(0);
            vendaForm.ShowDialog();
            CarregarDataGird();
        }

        private void bntItens_Click(object sender, System.EventArgs e)
        {
            VendaProdutoEntidade vendaProdutoEntidade = BuscarLinhaDataGrid();

            if(vendaProdutoEntidade.Id != 0)
            {
                ItensVendaScreen itensVendaScreen = new ItensVendaScreen(vendaProdutoEntidade.Id);
                itensVendaScreen.ShowDialog();
            }

        }

        private void bntDeletar_Click(object sender, System.EventArgs e)
        {
            VendaProdutoControler vendaProdutoControler = new VendaProdutoControler();
            VendaProdutoEntidade vendaProdutoEntidade = BuscarLinhaDataGrid();
            vendaProdutoControler.DeletarVenda(vendaProdutoEntidade);
            CarregarDataGird();
        }

        private void bntSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
