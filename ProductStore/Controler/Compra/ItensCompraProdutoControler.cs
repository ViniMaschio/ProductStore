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

        public void DeletarProdutos(int codCompra)
        {
            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();

            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = itensCompraProdutoDAO.BuscarTodosProdutoPorCompra(codCompra);
            
            itensCompraProdutoDAO.Delete(listItensCompraProdutoEntidade);
        }

        

        public DataTable BuscarTodosProdutosPorCompra(int codCompra)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod",typeof(int));
            dataTable.Columns.Add("Produto",typeof(string));
            dataTable.Columns.Add("Quant.",typeof(double));
            dataTable.Columns.Add("Valor Uni.",typeof(double));
            dataTable.Columns.Add("Valor Total", typeof(double));

            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();

            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = itensCompraProdutoDAO.BuscarTodosProdutoPorCompra(codCompra);

            ProdutoControler produtoControler = new ProdutoControler();

            for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
            {
                ProdutoEntidade produtoEntidade = produtoControler.BuscarPorId(listItensCompraProdutoEntidade[i].CodProduto);

                dataTable.Rows.Add(
                    listItensCompraProdutoEntidade[i].CodProduto,
                    produtoEntidade.Nomeproduto,
                    listItensCompraProdutoEntidade[i].Quantidade,
                    listItensCompraProdutoEntidade[i].Valorc,
                    listItensCompraProdutoEntidade[i].Quantidade * listItensCompraProdutoEntidade[i].Valorc
                    );
            }

            return dataTable;
        }

        public double BuscarValorTotalPorCompra(int codCompra)
        {
            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();

            return itensCompraProdutoDAO.BuscarTotalCompraPorId(codCompra);
        }
    }
}
