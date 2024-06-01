using ProductStore.Controler.Compra;
using ProductStore.Controler.Funcionario;
using ProductStore.Controler.Produto;
using ProductStore.Entidades.Boletos;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Endereco;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Compra
{
    public partial class bntAdicionar : Form
    {
        public bntAdicionar(int CodCompra)
        {
            InitializeComponent();

            txtCod.Text = CodCompra.ToString(); 

            CarregarFornecedor();
            CarregarFuncionario();
            CarregarProduto();
            CarregarValorProduto();
        }

        private double _ValorTotal = 0;

        private void CarregarFornecedor()
        {
            FornecedorControler fornecedorControler = new FornecedorControler();
            cBoxFornecedor.DataSource = fornecedorControler.BuscarTodosFornecedor();
            cBoxFornecedor.ValueMember = "ID";
            cBoxFornecedor.DisplayMember = "Nome Fornecedor";
            cBoxFornecedor.DropDownWidth = 200;
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
            double quantidade  =  double.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtValorUnit.Text);
            int id = (int)cBoxProdutos.SelectedValue;

            _ValorTotal += quantidade * valor;

            txtTotalCompra.Text = _ValorTotal.ToString();

            bool ProdutoAdicionado = true;

            for (int i = 0; i < dGVItensCompra.Rows.Count; i++)
            {
                int _id = (int)dGVItensCompra.Rows[i].Cells[0].Value;
                if (_id == id)
                {
                    ProdutoAdicionado = false;
                    quantidade += double.Parse(dGVItensCompra.Rows[i].Cells[2].Value.ToString());
                    dGVItensCompra.Rows[i].Cells[2].Value = quantidade;
                    dGVItensCompra.Rows[i].Cells[4].Value = valor * quantidade;
                }
            }
            if (ProdutoAdicionado)
            {
                dGVItensCompra.Rows.Add(id, cBoxProdutos.Text, quantidade, valor, (quantidade * valor));
            }
            txtQuantidade.Text = "1";
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {

            if (dGVItensCompra.Rows.Count > 0)
            {
                dGVItensCompra.Rows.Remove(dGVItensCompra.CurrentRow);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            BoletosCompra boletosCompra = new BoletosCompra(_ValorTotal);
            boletosCompra.ShowDialog();
            
            if (boletosCompra.DialogResult == DialogResult.Yes)
            {
                CompraProdutoEntidade compraProdutoEntidade = new CompraProdutoEntidade()
                {
                    CodFornecedor = (int)cBoxFornecedor.SelectedValue,
                    CodFuncionario = (int)cBoxFuncionario.SelectedValue,
                    Id = int.Parse(txtCod.Text),
                    DataCompra = dataCompra.Value
                };
                List<ItensCompraProdutoEntidade> itensCompraProdutoEntidades = new List<ItensCompraProdutoEntidade>();

                for (int i = 0; i < dGVItensCompra.Rows.Count; i++)
                {
                    itensCompraProdutoEntidades.Add(new ItensCompraProdutoEntidade()
                    {
                        CodProduto = (int)dGVItensCompra.Rows[i].Cells[0].Value,
                        Valorc = double.Parse(dGVItensCompra.Rows[i].Cells[3].Value.ToString()),
                        Quantidade = double.Parse(dGVItensCompra.Rows[i].Cells[2].Value.ToString())
                    });
                }
                CompraProdutoControler compraProdutoControler = new CompraProdutoControler();

                List<ParcelaCompraEntidade> listparcelacompra = boletosCompra._listParcelaCompraEntidade;

                compraProdutoControler.AddCompra(compraProdutoEntidade, itensCompraProdutoEntidades, listparcelacompra);

                this.Close();
            }
        }
    }
}
