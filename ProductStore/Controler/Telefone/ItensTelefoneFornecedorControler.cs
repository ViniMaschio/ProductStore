using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Telefone
{
    internal class ItensTelefoneFornecedorControler
    {
        public ItensTelefoneFornecedorControler() { }

        public void AddTelefone(ItensTelefoneFornecedorEntidade itensTelefoneFornecedorEntidade) 
        { 
            ItensTelefoneFornecedorDAO itensTelefoneFornecedorDAO = new ItensTelefoneFornecedorDAO();
            itensTelefoneFornecedorDAO.Add(itensTelefoneFornecedorEntidade);
        }

        public void RemoverTelefone(ItensTelefoneFornecedorEntidade itensTelefoneFornecedorEntidade)
        {
            ItensTelefoneFornecedorDAO itensTelefoneFornecedorDAO = new ItensTelefoneFornecedorDAO();
            itensTelefoneFornecedorDAO.Delete(itensTelefoneFornecedorEntidade);
        }

        public List<ItensTelefoneFornecedorEntidade> AddTelefone(int codFornecedor)
        {
            ItensTelefoneFornecedorDAO itensTelefoneFornecedorDAO = new ItensTelefoneFornecedorDAO();
            return itensTelefoneFornecedorDAO.BuscarTodosTelefonePorFornecedor(codFornecedor);
        }
    }
}
