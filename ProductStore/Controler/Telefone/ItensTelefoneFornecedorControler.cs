using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;

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

        public DataTable BuscarTelefonePorFornecedor(int codFornecedor)
        {
            ItensTelefoneFornecedorDAO itensTelefoneFornecedorDAO = new ItensTelefoneFornecedorDAO();
            List<ItensTelefoneFornecedorEntidade> listItensTelefoneFornecedorEntidade = itensTelefoneFornecedorDAO.BuscarTodosTelefonePorFornecedor(codFornecedor);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Telefone", typeof(string));

            TelefoneControler telefoneControler = new TelefoneControler();

            for(int i = 0;i< listItensTelefoneFornecedorEntidade.Count; i++)
            {
                TelefoneEntidade telefoneEntidade = telefoneControler.BuscarTelefonePorID(listItensTelefoneFornecedorEntidade[i].CodTelefone);

                dataTable.Rows.Add(telefoneEntidade.Id,telefoneEntidade.Telefone);
            }

            return dataTable;
        }
    }
}
