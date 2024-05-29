using ProductStore.DAO.Produto;
using ProductStore.Entidades.Produto;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Produto
{
    public class ProdutoControler
    {
        public ProdutoControler() { }

        public void AdicionarProduto(ProdutoEntidade produto)
        {

            ProdutoDAO produtoDAO = new ProdutoDAO();

            produtoDAO.AddProduto(produto);

            MessageBox.Show("Produto Adicionado com Sucesso!", "Adicionar Produto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AlterarProduto(ProdutoEntidade produtoEntidade)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            produtoDAO.AlterarProduto(produtoEntidade);

            MessageBox.Show("Produto Alterado com Sucesso!", "Alterar Produto",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(produtoEntidade.Id + "\n" + produtoEntidade.Nomeproduto + "\n" + produtoEntidade.Valor +
            //"\n" + produtoEntidade.Quantidade + "\n"+ produtoEntidade.Codigomarca+"\n"+ produtoEntidade.Codigotipo);

        }

        public void RemoverProduto(ProdutoEntidade produtoEntidade)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            if (MessageBox.Show("Tem certeza que deseja excluir o produto: /n" + produtoEntidade.Nomeproduto,
                "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoDAO.RemoverProduto(produtoEntidade.Id);

                MessageBox.Show("Produto Removido com Sucesso!", "Remover Produto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosProdutos()
        {
            DataTable reader = new DataTable();

            ProdutoDAO produtoDAO = new ProdutoDAO();

            TipoControler tipoControler = new TipoControler();

            MarcaControler marcaControler = new MarcaControler();

            List<ProdutoEntidade> produtoEntidades = produtoDAO.BuscarTodosProdutos();

            reader.Columns.Add("Id", typeof(int));
            reader.Columns.Add("Nome Produto", typeof(string));
            reader.Columns.Add("Quantidade", typeof(double));
            reader.Columns.Add("Valor", typeof(double));
            reader.Columns.Add("Marca", typeof(string));
            reader.Columns.Add("Tipo", typeof(string));

            for (int i = 0; produtoEntidades != null && i < produtoEntidades.Count; i++)
            {
                reader.Rows.Add(produtoEntidades[i].Id, produtoEntidades[i].Nomeproduto,
                    produtoEntidades[i].Quantidade, produtoEntidades[i].Valor,
                    marcaControler.BuscarId(produtoEntidades[i].Codigomarca),
                    tipoControler.BuscarId(produtoEntidades[i].Codigotipo));
            }



            return reader;
        }

        public ProdutoEntidade BuscarPorId(int id)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            return produtoDAO.BuscarProdutoPorId(id);
        }
    }
}
