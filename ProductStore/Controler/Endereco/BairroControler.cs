using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Endereco
{
    public class BairroControler
    {
        public BairroControler() { }

        public void AddBairro(BairroEntidade bairroEntidade)
        {

            BairroDAO bairroDAO = new BairroDAO();

            bairroDAO.Add(bairroEntidade);
            MessageBox.Show("Bairro Adicionado com sucesso!", "Adicionar Bairro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void AlterarBairro(BairroEntidade bairroEntidade)
        {
            BairroDAO bairroDAO = new BairroDAO();

            bairroDAO.Update(bairroEntidade);
            MessageBox.Show("Bairro Alterado com sucesso!", "Alterar Bairro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public void RemoverBairro(BairroEntidade bairroEntidade)
        {
            BairroDAO bairroDAO = new BairroDAO();
            if (MessageBox.Show("Tem certeza que deseja excluir o bairro\n" + bairroEntidade.Id + " - " + bairroEntidade.Bairro, "Excluir Bairro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bairroDAO.Delete(bairroEntidade.Id);
                MessageBox.Show("Bairro Deletado com sucesso!", "Deletar Bairro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BuscarTodosBairro()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Bairro", typeof(string));

            BairroDAO bairoDAO = new BairroDAO();

            List<BairroEntidade> listaBairroEntidade = bairoDAO.BuscarTodosBairro();

            for (int i = 0; i < listaBairroEntidade.Count && listaBairroEntidade != null; i++)
            {
                dataTable.Rows.Add(listaBairroEntidade[i].Id, listaBairroEntidade[i].Bairro);
            }
            return dataTable;
        }

        public string BuscarPorId(int id)
        {
            BairroDAO bairroDAO = new BairroDAO();

            return bairroDAO.BuscarPorID(id);
        }
    }
}
