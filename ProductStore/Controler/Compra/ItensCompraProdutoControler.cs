using ProductStore.DAO.Compra;
using ProductStore.Entidades.Compra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dataTable.Columns.Add("Cod Produto");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Valor Compra");

            ItensCompraProdutoDAO itensCompraProdutoDAO = new ItensCompraProdutoDAO();

            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = itensCompraProdutoDAO.BuscarTodosProdutoPorCompra(codVenda);

            for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
            {
                dataTable.Rows.Add(
                    listItensCompraProdutoEntidade[i].CodProduto,
                    listItensCompraProdutoEntidade[i].Quantidade,
                    listItensCompraProdutoEntidade[i].Valorc
                    );
            }

            return dataTable;
        }
    }
}
