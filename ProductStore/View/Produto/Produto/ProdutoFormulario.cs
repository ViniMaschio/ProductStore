using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using ProductStore.View.Produto.Marca;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.View.Produto.Produto
{
    public partial class ProdutoFormulario : Form
    {

        public ProdutoFormulario(int codProduto)
        {
            InitializeComponent();

            CarregarMarca();
            CarregarTipo();

            if (codProduto == 0)
            {
                txtCodigo.Text = codProduto.ToString();
            }
            else
            {
                ProdutoControler produtoControler = new ProdutoControler();

                ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId(codProduto);

                txtCodigo.Text = produtoEntidade.Id.ToString();
                txtProduto.Text = produtoEntidade.Nomeproduto.ToString();
                txtValor.Text = produtoEntidade.Valor.ToString();
                txtQuantidade.Text = produtoEntidade.Quantidade.ToString();
                cbBoxMarca.SelectedValue = produtoEntidade.Codigomarca;
                cbBoxTipo.SelectedValue = produtoEntidade.Codigotipo;
            }
        }

        private void CarregarMarca()
        {


            MarcaControler marcaControler = new MarcaControler();
            DataTable marca = marcaControler.BuscarTodosMarca();

            cbBoxMarca.DataSource = marca;
            cbBoxMarca.DisplayMember = "Marca";
            cbBoxMarca.ValueMember = "ID";
        }

        private void CarregarTipo()
        {
            //cbBoxTipo.Items.Clear();
            TipoControler tipoControler = new TipoControler();
            DataTable tipo = tipoControler.BuscarTodosTipos();

            cbBoxTipo.DataSource = tipo;
            cbBoxTipo.DisplayMember = "Tipo";
            cbBoxTipo.ValueMember = "ID";

        }

        private Boolean VerificaCampos()
        {
            if (txtProduto.Text.Trim().Length == 0)
            {

                MessageBox.Show("Digite o nome do produto!", "Adicionar Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite o valor do produto!", "Adicionar Produto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;

            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;

            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtQuantidade.Text);

            txtQuantidade.Text = quantidade.ToString();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text.Length > 0)
            {
                double valor = double.Parse(txtValor.Text);

                txtValor.Text = valor.ToString();
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {

            if (VerificaCampos())
            {

                ProdutoControler produtoControler = new ProdutoControler();

                ProdutoEntidade produtoEntidade = new ProdutoEntidade()
                {
                    Id = int.Parse(txtCodigo.Text),
                    Nomeproduto = txtProduto.Text,
                    Quantidade = double.Parse(txtQuantidade.Text),
                    Valor = double.Parse(txtValor.Text),
                    Codigomarca =
                int.Parse(cbBoxMarca.SelectedValue.ToString()),
                    Codigotipo =
                int.Parse(cbBoxTipo.SelectedValue.ToString())
                };
                if (produtoEntidade.Id != 0)
                {
                    produtoControler.AlterarProduto(produtoEntidade);
                }
                else
                {
                    produtoControler.AdicionarProduto(produtoEntidade);
                }


                this.Close();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntNovoMarca_Click(object sender, EventArgs e)
        {
            MarcaEntidade marcaEntidade = new MarcaEntidade() { Id = 0, Marca = "" };

            MarcaForm marcaForm = new MarcaForm(marcaEntidade);

            marcaForm.ShowDialog();

            CarregarMarca();

        }

        private void bntNovoTipo_Click(object sender, EventArgs e)
        {
            TipoEntidade tipoEntidade = new TipoEntidade() { Id = 0, Tipo = "" };

            TipoForm tipoForm = new TipoForm(tipoEntidade);

            tipoForm.ShowDialog();

            CarregarTipo();
        }
    }
}
