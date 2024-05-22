using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Endereco
{
    public class CidadeControler
    {
        public CidadeControler() { }

        public DataTable BuscarCidadePorUF (int uf)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Cidade");

            CidadeDao cidadeDao = new CidadeDao();  

            List<CidadeEntidade> listCidadeEntidade = cidadeDao.BuscarCidadesPorUf (uf);

            for (int i = 0;i < listCidadeEntidade.Count && listCidadeEntidade != null; i++)
            {
                dataTable.Rows.Add(listCidadeEntidade[i].Id, listCidadeEntidade[i].Nomecidade);
            }

            return dataTable;
        }

        public CidadeEntidade BuscarCidadePorId(int id)
        {
            CidadeDao cidadeDao =new CidadeDao();

            return cidadeDao.BuscarCidadePorID(id);
        }

        
    }
}
