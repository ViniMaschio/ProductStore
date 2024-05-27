using ProductStore.DAO.Telefone;
using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Telefone
{
    public class TelefoneControler
    {
        public TelefoneControler() { }

        public void AddTelefone(TelefoneEntidade telefoneEntidade)
        {
            TelefoneDao telefoneDao = new TelefoneDao();
            telefoneDao.Add(telefoneEntidade);

            MessageBox.Show("Telefone Adicionado com sucesso!", "Adicionar Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AlterarTelefone(TelefoneEntidade telefoneEntidade)
        {
            TelefoneDao telefoneDao = new TelefoneDao();
            telefoneDao.Update(telefoneEntidade);

            MessageBox.Show("Telefone Alterado com sucesso!", "Alterar Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void DeletarTelefone(TelefoneEntidade telefoneEntidade)
        {
            TelefoneDao telefoneDao = new TelefoneDao();

            if (MessageBox.Show("Realmente deseja excluir o telefone\n" + telefoneEntidade.Id +
                " - " + telefoneEntidade.Telefone, "Excluir Telefone", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                telefoneDao.Delete(telefoneEntidade.Id);
                MessageBox.Show("Telefone Adicionado com sucesso!", "Adicionar Telefone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosTelefone()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Telefone", typeof(string));


            TelefoneDao telefoneDao = new TelefoneDao();

            List<TelefoneEntidade> listTelefoneEntidade = telefoneDao.BuscarTodosTelefone();

            for (int i = 0; i < listTelefoneEntidade.Count; i++)
            {
                dataTable.Rows.Add(listTelefoneEntidade[i].Id,
                    listTelefoneEntidade[i].Telefone
                    );
            }

            return dataTable;
        }

        public TelefoneEntidade BuscarTelefonePorID(int id)
        {
            TelefoneDao telefoneDao = new TelefoneDao();

            return telefoneDao.BuscarTelefonePorId(id);
        }
    }
}
