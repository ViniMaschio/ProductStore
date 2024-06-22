using ProductStore.Controler.Cliente;
using ProductStore.Controler.Funcionario;
using ProductStore.Controler.Produto;
using ProductStore.Controler.Venda;
using ProductStore.Entidades.Boletos;
using ProductStore.Entidades.Produto;
using ProductStore.Entidades.Venda;
using ProductStore.View.Cliente.Cliente;
using ProductStore.View.Funcionario.Funcionario;
using ProductStore.View.Produto.Produto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductStore.View.Venda
{
    public partial class VendaForm : Form
    {
        public VendaForm(int codVenda)
        {
            InitializeComponent();

            txtCod.Text = codVenda.ToString();
            CarregarCliente();
            CarregarFuncionario();
            CarregarProduto();
            CarregarValorProduto();
        }

        private double _ValorTotal = 0;

        private void CarregarCliente()
        {
            ClienteControler clienteControler = new ClienteControler();
            cBoxCliente.DataSource = clienteControler.BuscarTodosCliente();
            cBoxCliente.DisplayMember = "Nome";
            cBoxCliente.ValueMember = "ID";
            cBoxCliente.DropDownWidth = 200;
        }

        private void CarregarFuncionario()
        {
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            cBoxFuncionario.DataSource = funcionarioControler.BuscarTodosFuncionarios();
            cBoxFuncionario.ValueMember = "ID";
            cBoxFuncionario.DisplayMember = "Nome Funcionario";
            cBoxFuncionario.DropDownWidth = 200;
        }

        private void CarregarProduto()
        {
            ProdutoControler produtoControler = new ProdutoControler();
            cBoxProdutos.DataSource = produtoControler.BuscarTodosProdutos();
            cBoxProdutos.ValueMember = "ID";
            cBoxProdutos.DisplayMember = "Nome Produto";
            cBoxProdutos.DropDownWidth = 200;
        }

        private void CarregarValorProduto()
        {
            ProdutoControler produtoControler = new ProdutoControler();
            ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId((int)cBoxProdutos.SelectedValue);
            txtValorUnit.Text = produtoEntidade.Valor.ToString();
        }

        private void cBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarValorProduto();
        }

        private void bntAdicionarProduto_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtValorUnit.Text);
            int id = (int)cBoxProdutos.SelectedValue;

            _ValorTotal += quantidade * valor;

            txtTotalVenda.Text = _ValorTotal.ToString();

            bool ProdutoAdicionado = true;

            for (int i = 0; i < dGVItensVenda.Rows.Count; i++)
            {
                int _id = (int)dGVItensVenda.Rows[i].Cells[0].Value;
                if (_id == id)
                {
                    ProdutoAdicionado = false;
                    quantidade += double.Parse(dGVItensVenda.Rows[i].Cells[2].Value.ToString());
                    dGVItensVenda.Rows[i].Cells[2].Value = quantidade;
                    dGVItensVenda.Rows[i].Cells[4].Value = valor * quantidade;
                }
            }
            if (ProdutoAdicionado)
            {
                dGVItensVenda.Rows.Add(id, cBoxProdutos.Text, quantidade, valor, (quantidade * valor));
            }
            txtQuantidade.Text = "1";
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {

            if (dGVItensVenda.Rows.Count > 0)
            {
                dGVItensVenda.Rows.Remove(dGVItensVenda.CurrentRow);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            PagamentoVendaScreen boletosVendaScreen = new PagamentoVendaScreen(_ValorTotal);
            boletosVendaScreen.ShowDialog();

            if (boletosVendaScreen.DialogResult == DialogResult.Yes)
            {
                VendaProdutoEntidade vendaProdutoEntidade = new VendaProdutoEntidade()
                {
                    CodCliente = (int)cBoxCliente.SelectedValue,
                    CodFuncionario = (int)cBoxFuncionario.SelectedValue,
                    Id = int.Parse(txtCod.Text),
                    DataVenda = dataVenda.Value
                };

                List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = new List<ItensVendaProdutoEntidade>();

                for (int i = 0; i < dGVItensVenda.Rows.Count; i++)
                {
                    listItensVendaProdutoEntidade.Add(new ItensVendaProdutoEntidade()
                    {
                        CodProduto = int.Parse(dGVItensVenda.Rows[i].Cells[0].Value.ToString()),
                        Quantidade = double.Parse(dGVItensVenda.Rows[i].Cells[2].Value.ToString()),
                        Valor = double.Parse(dGVItensVenda.Rows[i].Cells[3].Value.ToString())
                    });
                }

                VendaProdutoControler vendaProdutoControler = new VendaProdutoControler();

                List<ParcelaVendaEntidade> listParcelaVendaEntidades = boletosVendaScreen.listParcelaVendaEntidade;

                vendaProdutoControler.AddVenda(vendaProdutoEntidade, listItensVendaProdutoEntidade, listParcelaVendaEntidades);

                this.Close();
            }

        }

        private void bntNovoFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioForm funcionarioForm = new FuncionarioForm(0);
            funcionarioForm.ShowDialog();
            CarregarFuncionario();
        }

        private void bntNovoFornecedor_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(0);
            clienteForm.ShowDialog();
            CarregarCliente();
        }

        private void bntNovoProduto_Click(object sender, EventArgs e)
        {
            ProdutoFormulario produtoFormulario = new ProdutoFormulario(0);
            produtoFormulario.ShowDialog();
            CarregarProduto();
        }
    }
}
