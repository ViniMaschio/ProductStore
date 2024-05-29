using ProductStore.Controler.Produto;
using ProductStore.DAO.Compra;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Produto;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Compra
{
    public class ItensCompraProdutoControler
    {
        public ItensCompraProdutoControler() { }

        public void AddProdutos(List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade)
        {
            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();
            itensCompraProdutoDAO.Add(listItensCompraProdutoEntidade);
        }

        public void DeletarProdutos(List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade)
        {
            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();
            itensCompraProdutoDAO.Delete(listItensCompraProdutoEntidade);
        }

        public DataTable BuscarTodosProdutosPorVenda(int codVenda)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod");
            dataTable.Columns.Add("Produto");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Valor Unitario");

            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();

            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = itensCompraProdutoDAO.BuscarTodosProdutoPorCompra(codVenda);

            ProdutoControler produtoControler = new ProdutoControler();

            for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
            {
                ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId(listItensCompraProdutoEntidade[i].CodProduto);

                dataTable.Rows.Add(
                    listItensCompraProdutoEntidade[i].CodProduto,
                    produtoEntidade.Nomeproduto,
                    listItensCompraProdutoEntidade[i].Quantidade,
                    listItensCompraProdutoEntidade[i].Valorc
                    );
            }

            return dataTable;
        }
    }
}
