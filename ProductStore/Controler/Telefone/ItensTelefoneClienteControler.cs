using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Telefone
{
    public class ItensTelefoneClienteControler
    {

        public void AddTelefoneCliente(ItensTelefoneClienteEntidade itensTelefoneClienteEntidade) {
            ItensTelefoneClienteDAO itensTelefoneClienteDAO = new ItensTelefoneClienteDAO();

            itensTelefoneClienteDAO.Add(itensTelefoneClienteEntidade);
            MessageBox.Show("Telefone Adicionado com Sucesso!", "Adicionar Telefone Cliente",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public List<ItensTelefoneClienteEntidade> BuscarTodosTelefonePorCliente(int id)
        {
            ItensTelefoneClienteDAO itensTelefoneClienteDAO = new ItensTelefoneClienteDAO();

            return itensTelefoneClienteDAO.BuscarClienteTelefonePorCliente(id);
        }

    }
}
