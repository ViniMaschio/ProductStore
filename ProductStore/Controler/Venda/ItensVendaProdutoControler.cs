using ProductStore.Controler.Produto;
using ProductStore.DAO.Venda;
using ProductStore.Entidades.Produto;
using ProductStore.Entidades.Venda;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Venda
{
    public class ItensVendaProdutoControler
    {
        public ItensVendaProdutoControler() { }

        public void AddProduto(List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade)
        {
            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();
            itensVendaProdutoDAO.Add(listItensVendaProdutoEntidade);
        }

        public void DeletarProduto(List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade)
        {
            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();
            itensVendaProdutoDAO.Deletar(listItensVendaProdutoEntidade);
        }

        public DataTable BuscarVendaProdutosPorVenda(int codVenda)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod");
            dataTable.Columns.Add("Produto");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Valor Unitario");

            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();

            List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = itensVendaProdutoDAO.BuscarTodosProdutoPorVenda(codVenda);

            ProdutoControler produtoControler = new ProdutoControler();

            for (int i = 0; i < listItensVendaProdutoEntidade.Count; i++)
            {
                ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId(listItensVendaProdutoEntidade[i].CodProduto);

                dataTable.Rows.Add(listItensVendaProdutoEntidade[i].CodProduto,
                    produtoEntidade.Nomeproduto,
                    listItensVendaProdutoEntidade[i].Quantidade,
                    listItensVendaProdutoEntidade[i].Valor
                    );
            }

            return dataTable;
        }
    }
}
