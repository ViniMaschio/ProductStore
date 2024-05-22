using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Telefone
{
    public class OperadoraControler
    {

        public OperadoraControler() { } 

        public DataTable BuscarTodasOperadora()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Operadora",  typeof(string));

            OperadoraDao operadoraDao = new OperadoraDao();
            List<OperadoraEntidade> listaOperadoraEntidade = operadoraDao.BuscarTodasOperadora();

            for(int i = 0; i< listaOperadoraEntidade.Count && listaOperadoraEntidade != null; i++)
            {
                dataTable.Rows.Add(listaOperadoraEntidade[i].Id, listaOperadoraEntidade[i].NomeOperadora);
            }



            return dataTable;
        }

        public string BuscarOperaoraPorId(int id)
        {
            OperadoraDao operadoraDao=new OperadoraDao();

            return operadoraDao.BuscarOperadoraPorId(id);
        }
    }
}
