using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Telefone
{
    public class ItensTelefoneFuncionarioControler
    {
        public void AdicionarTelefone(ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade)
        {
            ItensTelefoneFuncionarioDAO itensTelefoneFuncionarioDAO = new ItensTelefoneFuncionarioDAO();
            itensTelefoneFuncionarioDAO.Add(itensTelefoneFuncionarioEntidade);
        }

        public void RemoverTelefone(ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade)
        {
            ItensTelefoneFuncionarioDAO itensTelefoneFuncionarioDAO = new ItensTelefoneFuncionarioDAO();
            itensTelefoneFuncionarioDAO.Deletar(itensTelefoneFuncionarioEntidade);
        }

        public DataTable BuscarTelefonePorFuncionario(int id)
        {
            ItensTelefoneFuncionarioDAO itensTelefoneFuncionarioDAO = new ItensTelefoneFuncionarioDAO();

            List<ItensTelefoneFuncionarioEntidade> listItensTelefoneFuncionario = itensTelefoneFuncionarioDAO.BuscarTodosTelefonePorFuncionario(id);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Telefone");

            TelefoneControler telefoneControler = new TelefoneControler();

            for (int i = 0;i<listItensTelefoneFuncionario.Count;i++)
            {
                TelefoneEntidade telefoneEntidade = telefoneControler.BuscarTelefonePorID(listItensTelefoneFuncionario[i].CodTelefone);

                dataTable.Rows.Add(telefoneEntidade.Id,telefoneEntidade.Telefone);
            }
            return dataTable;
        }
    }
}
