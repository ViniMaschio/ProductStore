using ProductStore.DAO.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Produto
{
    public class MarcaControler
    {
        public MarcaControler() { }


        public DataTable BuscarTodosMarca()
        {

            MarcaDAO marcaDAO = new MarcaDAO();
            DataTable marca = new DataTable();
            List<MarcaEntidade> marcaEntidadeList = marcaDAO.PesquisarTodos();

            marca.Columns.Add("ID", typeof(int));
            marca.Columns.Add("Marca", typeof(string));

            int i = 0;
            while (marcaEntidadeList != null && i < marcaEntidadeList.Count)
            {
                marca.Rows.Add(marcaEntidadeList[i].Id, marcaEntidadeList[i].Marca);
                i++;
            }

            return marca;
        }

        public string BuscarId(int id)
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            MarcaEntidade marcaEntidade = marcaDAO.BuscarId(id);

            return marcaEntidade.Marca;
        }

        public void ExcluirMarca(MarcaEntidade marcaEntidade)
        {
            MarcaDAO marcaDAO =new MarcaDAO();
            if (MessageBox.Show("Tem certeza que deseja excluir: \n " + marcaEntidade.Id + " - " + marcaEntidade.Marca, "Excluir Marca",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marcaDAO.Remover(marcaEntidade.Id);
                MessageBox.Show("Marca Removido com sucesso!", "Remover Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AddMarca(MarcaEntidade marcaEntidade)
        {
            MarcaDAO marcaDAO=new MarcaDAO();
            marcaDAO.Add(marcaEntidade.Marca);

            MessageBox.Show("Marca adicionado com sucesso!", "Adiciona Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditarMarca(MarcaEntidade marcaEntidade)
        {
            MarcaDAO marcaDAO = new MarcaDAO();

            marcaDAO.Alterar(marcaEntidade);

            MessageBox.Show("Marca alterada com sucesso!", "Alterar Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
