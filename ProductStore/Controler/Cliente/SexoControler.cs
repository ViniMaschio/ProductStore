using ProductStore.DAO.Pessoa;
using ProductStore.Entidades.Cliente;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Cliente
{
    public class SexoControler
    {
        public SexoControler() { }

        public DataTable BuscarSexo()
        {
            DataTable sexo = new DataTable();
            sexo.Columns.Add("ID", typeof(int));
            sexo.Columns.Add("Sexo", typeof(string));

            SexoDAO sexoDAO = new SexoDAO();

            List<SexoEntidade> listaSexo = sexoDAO.BuscarTodosSexo();

            int i = 0;
            while (listaSexo != null && i < listaSexo.Count)
            {
                sexo.Rows.Add(listaSexo[i].Id, listaSexo[i].Sexo);
                i++;
            }

            return sexo;
        }

        public string BuscarSexoPorId(int id)
        {
            SexoDAO sexoDAO = new SexoDAO();

            return sexoDAO.BuscarSexoPorID(id);
        }
    }
}
