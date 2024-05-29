using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Endereco
{
    public class UfControler
    {
        public UfControler() { }

        public DataTable BuscarTodosUf()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("UF", typeof(string));

            UfDao ufDao = new UfDao();

            List<UfEntidade> listUfEntidade = ufDao.BuscarTodosUf();

            for (int i = 0; i < listUfEntidade.Count && listUfEntidade != null; i++)
            {
                dataTable.Rows.Add(listUfEntidade[i].Id, listUfEntidade[i].Nomeuf + " - " + listUfEntidade[i].Sigla);
            }

            return dataTable;
        }

        public UfEntidade BuscarUfPorId(int id)
        {
            UfDao ufDao = new UfDao();

            return ufDao.BuscarUfPorIf(id);
        }
    }
}
