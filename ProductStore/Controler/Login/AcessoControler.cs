using ProductStore.DAO.Login;
using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Login
{
    public class AcessoControler
    {
        public AcessoControler() { }

        public DataTable BuscarTodosAcesso()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Acesso",typeof(string));

            AcessoDAO acessoDAO = new AcessoDAO();
            List<AcessoEntidade> listAcessoEntidade = acessoDAO.BuscarTodosAcesso();

            for (int i = 0; i < listAcessoEntidade.Count; i++)
            {
                dataTable.Rows.Add(listAcessoEntidade[i].Id, listAcessoEntidade[i].NomeAcesso);
            }

            return dataTable;
        }

        public string BuscarAcessoPorId(int id)
        {
            AcessoDAO acessoDAO = new AcessoDAO();

            return acessoDAO.BuscarAcessoPorId(id);
        }
    }
}
