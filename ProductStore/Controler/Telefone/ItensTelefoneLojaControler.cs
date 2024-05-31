using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Telefone
{
    public class ItensTelefoneLojaControler
    {
        public ItensTelefoneLojaControler() { }

        public void AddTelefone(ItensTelefoneLojaEntidade itensTelefoneLojaEntidade)
        {
            ItensTelefoneLojaDAO itensTelefoneLojaDAO = new ItensTelefoneLojaDAO();
            itensTelefoneLojaDAO.Add(itensTelefoneLojaEntidade);
        }

        public void DeletarTelefone(ItensTelefoneLojaEntidade itensTelefoneLojaEntidade)
        {
            ItensTelefoneLojaDAO itensTelefoneLojaDAO = new ItensTelefoneLojaDAO();

            itensTelefoneLojaDAO.Deletar(itensTelefoneLojaEntidade);

        }

        public DataTable BuscarTodosTelfonePorLoja(int idLoja)
        {
            ItensTelefoneLojaDAO itensTelefoneLojaDAO = new ItensTelefoneLojaDAO();

            List<ItensTelefoneLojaEntidade> listItensTelefoneLojaEntidade = itensTelefoneLojaDAO.BuscarTelefonePorLoja(idLoja);
            TelefoneControler telefoneControler = new TelefoneControler();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Telfone",typeof(string));

            for (int i = 0;i< listItensTelefoneLojaEntidade.Count;i++)
            {
                TelefoneEntidade telefoneEntidade = telefoneControler.BuscarTelefonePorID(listItensTelefoneLojaEntidade[i].CodTelefone);

                dataTable.Rows.Add(telefoneEntidade.Id, telefoneEntidade.Telefone);
            }

            return dataTable;
        }
    }
}
