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

        public void DeletarProduto(int codVenda)
        {
            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();

            List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = itensVendaProdutoDAO.BuscarTodosProdutoPorVenda(codVenda);

            itensVendaProdutoDAO.Deletar(listItensVendaProdutoEntidade);
        }

        public DataTable BuscarVendaProdutosPorVenda(int codVenda)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod", typeof(int));
            dataTable.Columns.Add("Produto", typeof(string));
            dataTable.Columns.Add("Quant", typeof(double));
            dataTable.Columns.Add("Valor Unit", typeof(double));
            dataTable.Columns.Add("Total", typeof(double));

            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();

            List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = itensVendaProdutoDAO.BuscarTodosProdutoPorVenda(codVenda);

            ProdutoControler produtoControler = new ProdutoControler();

            for (int i = 0; i < listItensVendaProdutoEntidade.Count; i++)
            {
                ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId(listItensVendaProdutoEntidade[i].CodProduto);

                dataTable.Rows.Add(listItensVendaProdutoEntidade[i].CodProduto,
                    produtoEntidade.Nomeproduto,
                    listItensVendaProdutoEntidade[i].Quantidade,
                    listItensVendaProdutoEntidade[i].Valor,
                    (listItensVendaProdutoEntidade[i].Quantidade * listItensVendaProdutoEntidade[i].Valor)
                    );
            }

            return dataTable;
        }

        public double BuscarTotalPorVenda(int codVenda)
        {
            ItensVendaProdutoDAO itensVendaProdutoDAO = new ItensVendaProdutoDAO();

            return itensVendaProdutoDAO.BuscarTotalVenda(codVenda);
        }
    }
}
