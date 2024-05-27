using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Telefone
{
    public class ItensTelefoneTrabalhoControler
    {
        public void AdicionarTelefone(ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade)
        {
            ItensTelefoneTrabalhoDAO itensTelefoneTrabalhoDAO = new ItensTelefoneTrabalhoDAO();

            itensTelefoneTrabalhoDAO.Add(itensTelefoneTrabalhoEntidade);
        }

        public void RemoverTelefone(ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade)
        {
            ItensTelefoneTrabalhoDAO itensTelefoneTrabalhoDAO = new ItensTelefoneTrabalhoDAO();

            itensTelefoneTrabalhoDAO.Delete(itensTelefoneTrabalhoEntidade);
        }

        public DataTable BuscarTodosTelefonePorCliente(int codCliente)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Telefone", typeof(string));

            ItensTelefoneTrabalhoDAO itensTelefoneTrabalhoDAO = new ItensTelefoneTrabalhoDAO();

            List<ItensTelefoneTrabalhoEntidade> listItensTelefoneTrabalhoEntidade = itensTelefoneTrabalhoDAO.BuscarTelefonesPorTrabalho(codCliente);
            TelefoneControler telefoneControler = new TelefoneControler();
            TelefoneEntidade telefoneEntidade;

            for (int i = 0; i < listItensTelefoneTrabalhoEntidade.Count; i++)
            {

                telefoneEntidade = telefoneControler.BuscarTelefonePorID(listItensTelefoneTrabalhoEntidade[i].CodTelefone);

                dataTable.Rows.Add(listItensTelefoneTrabalhoEntidade[i].CodTelefone, telefoneEntidade.Telefone);
            }

            return dataTable;
        }
    }
}
