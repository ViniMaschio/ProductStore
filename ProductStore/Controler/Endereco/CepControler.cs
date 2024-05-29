using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Endereco
{
    public class CepControler
    {
        public CepControler() { }

        public void AddCep(CepEntidade cepEntidade)
        {
            CepDAO cepDAO = new CepDAO();
            cepDAO.Add(cepEntidade);
            MessageBox.Show("Cep Adicionado com Sucesso!", "Adicionar Cep", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AltercarCep(CepEntidade cepEntidade)
        {

            CepDAO cepDAO = new CepDAO();
            cepDAO.Update(cepEntidade);
            MessageBox.Show("Cep Alterado com Sucesso!", "Alterar Cep", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void ApagarCep(CepEntidade cepEntidade)
        {
            CepDAO cepDAO = new CepDAO();
            if (MessageBox.Show("Tem Certeza que deseja apagar o cep:\n" + cepEntidade.Id + " - " + cepEntidade.Cep, "Apagar Cep", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cepDAO.Update(cepEntidade);
                MessageBox.Show("Cep Alterado com Sucesso!", "Alterar Cep", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public DataTable BuscarTodosCep()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("CEP", typeof(string));

            CepDAO cepDAO = new CepDAO();
            List<CepEntidade> listaCepEntidade = cepDAO.BuscarTodosCep();

            for (int i = 0; i < listaCepEntidade.Count && listaCepEntidade != null; i++)
            {
                dataTable.Rows.Add(listaCepEntidade[i].Id, listaCepEntidade[i].Cep);
            }
            return dataTable;
        }

        public string BuscarCepPorId(int id)
        {
            CepDAO cepDAO = new CepDAO();

            return cepDAO.BuscarCepPorId(id);
        }
    }
}
