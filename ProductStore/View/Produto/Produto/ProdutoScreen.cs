using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using ProductStore.View.Produto.Imagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Produto.Produto
{
    public partial class ProdutoScreen : Form
    {
        public ProdutoScreen()
        {
            InitializeComponent();
        }
        
        private void ProdutoScreen_Load(object sender, EventArgs e)
        {
            CarregarDadosDataGrid();
        }

        private void CarregarDadosDataGrid()
        {
            ProdutoControler produtoControler = new ProdutoControler();

            DataTable dataTable = produtoControler.BuscarTodosProdutos();

            dGVProduto.DataSource = dataTable;
            dGVProduto.Columns[0].Width = 50;
            dGVProduto.Columns[1].Width = 270;
            dGVProduto.Columns[2].Width = 70;
            dGVProduto.Columns[3].Width = 70;
            dGVProduto.Columns[4].Width = 200;
            dGVProduto.Columns[5].Width = 200;
            


        }

        private ProdutoEntidade BuscarIdLinhaDataGrid()
        {
            ProdutoEntidade produtoEntidade = new ProdutoEntidade();

            if(dGVProduto.Rows.Count > 0)
            {
                produtoEntidade.Id = (int)dGVProduto.CurrentRow.Cells[0].Value;

                produtoEntidade.Nomeproduto=  (string)dGVProduto.CurrentRow.Cells[1].Value;

                return produtoEntidade;
            }
            produtoEntidade.Id = 0;

            return produtoEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
                ProdutoEntidade produtoEntidade = new ProdutoEntidade() { Id = 0 };

            
                ProdutoFormulario produtoFormulario = new ProdutoFormulario(produtoEntidade);
                produtoFormulario.ShowDialog();
                CarregarDadosDataGrid();
           
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            ProdutoEntidade produtoEntidade = BuscarIdLinhaDataGrid();
            if (produtoEntidade.Id != 0)
            {
                ProdutoFormulario produtoFormulario = new ProdutoFormulario(produtoEntidade);
                produtoFormulario.ShowDialog();
                CarregarDadosDataGrid();
            }
            else
            {
                MessageBox.Show("Não tem produto para editar!", "Editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            ProdutoEntidade produtoEntidade = BuscarIdLinhaDataGrid();

            if(produtoEntidade.Id != 0)
            {
                ProdutoControler produtoControler = new ProdutoControler();
                produtoControler.RemoverProduto(produtoEntidade);
                CarregarDadosDataGrid();
            }
            else
            {
                MessageBox.Show("Não tem produto para remover!", "Remover Produto",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntImagem_Click(object sender, EventArgs e)
        {
            ProdutoEntidade produtoEntidade = BuscarIdLinhaDataGrid();
            if (produtoEntidade.Id != 0)
            {
                ImagemScreen imagemScreen = new ImagemScreen(produtoEntidade.Id);
                imagemScreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem produto selecionado!", "Foto Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
