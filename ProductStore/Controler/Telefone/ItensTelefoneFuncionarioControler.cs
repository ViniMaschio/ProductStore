using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<ItensTelefoneFuncionarioEntidade> BuscarTelefonePorFuncionario(int id)
        {
            ItensTelefoneFuncionarioDAO itensTelefoneFuncionarioDAO = new ItensTelefoneFuncionarioDAO();

            return itensTelefoneFuncionarioDAO.BuscarTodosTelefonePorFuncionario(id);
        }
    }
}
