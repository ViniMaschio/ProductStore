using ProductStore.DAO.Login;
using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Login
{
    public class ControleLogSistemaControler
    {
        public void NovoLogin(int id)
        {
            ControleLogSistemaDAO controleLogSistemaDAO = new ControleLogSistemaDAO();

            controleLogSistemaDAO.Add(id);
        }

        public DataTable BuscarTodosLogPorLogin(int login)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Data");
            dataTable.Columns.Add("Hora");

            ControleLogSistemaDAO controleLogSistemaDAO = new ControleLogSistemaDAO();
            List<ControleLogSistemaEntidade> listLogSistemaEntidades = controleLogSistemaDAO.BuscarLogPorLogin(login);

            for (int i = 0; i < listLogSistemaEntidades.Count && listLogSistemaEntidades != null; i++)
            {
                dataTable.Rows.Add(listLogSistemaEntidades[i].Id, 
                    listLogSistemaEntidades[i].DataLog.Date.ToString("dd:MM:yyyy"),
                    listLogSistemaEntidades[i].Hora.ToString());
            }

            return dataTable;
        }
    }
}
