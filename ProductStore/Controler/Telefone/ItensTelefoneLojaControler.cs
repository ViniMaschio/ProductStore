using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (MessageBox.Show("Tem certeza que deseja retirar o telefone?","Retirar Telefone",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes) 
            {
                itensTelefoneLojaDAO.Deletar(itensTelefoneLojaEntidade);
            }
        }

        public DataTable BuscarTodosTelfonePorLoja(int idLoja)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("T", typeof(int));

            ItensTelefoneLojaDAO itensTelefoneLojaDAO = new ItensTelefoneLojaDAO();
            
        }
    }
}
