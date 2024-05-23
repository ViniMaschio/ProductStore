using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<ItensTelefoneTrabalhoEntidade> BuscarTodosTelefonePorCliente(int codCliente)
        {
            ItensTelefoneTrabalhoDAO itensTelefoneTrabalhoDAO = new ItensTelefoneTrabalhoDAO();

            return itensTelefoneTrabalhoDAO.BuscarTelefonesPorTrabalho(codCliente);
        }
    }
}
