using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Telefone
{
    public class ItensTelefoneClienteControler
    {

        public void AddTelefoneCliente(ItensTelefoneClienteEntidade itensTelefoneClienteEntidade)
        {
            ItensTelefoneClienteDAO itensTelefoneClienteDAO = new ItensTelefoneClienteDAO();

            itensTelefoneClienteDAO.Add(itensTelefoneClienteEntidade);
            MessageBox.Show("Telefone Adicionado com Sucesso!", "Adicionar Telefone Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarTelefoneCliente(ItensTelefoneClienteEntidade itensTelefoneClienteEntidade)
        {
            ItensTelefoneClienteDAO itensTelefoneClienteDAO = new ItensTelefoneClienteDAO();
            if (MessageBox.Show("Tem certeza que deseja retirar esse numero?", "Remover Telefone Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                itensTelefoneClienteDAO.Delete(itensTelefoneClienteEntidade);
                MessageBox.Show("Telefone Removido com Sucesso!", "Remover Telefone Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosTelefonePorCliente(int id)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Telefone", typeof(string));

            ItensTelefoneClienteDAO itensTelefoneClienteDAO = new ItensTelefoneClienteDAO();
            List<ItensTelefoneClienteEntidade> listItensTelefoneEntidade = itensTelefoneClienteDAO.BuscarClienteTelefonePorCliente(id);

            TelefoneControler telefoneControler = new TelefoneControler();

            for (int i = 0; i < listItensTelefoneEntidade.Count; i++)
            {
                TelefoneEntidade telefoneEntidade = telefoneControler.BuscarTelefonePorID(listItensTelefoneEntidade[i].CodTelefone);

                dataTable.Rows.Add(listItensTelefoneEntidade[i].CodTelefone, telefoneEntidade.Telefone);
            }


            return dataTable;
        }

    }
}
