using ProductStore.DAO.Funcionario;
using ProductStore.Entidades.Funcionario;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Funcionario
{
    public class LojaControler
    {

        public LojaControler() { }

        public void AdicionarLoja(LojaEntidade lojaEntidade)
        {
            LojaDAO lojaDAO = new LojaDAO();
            lojaDAO.Add(lojaEntidade);
            MessageBox.Show("Loja salva com sucesso!", "Salvar Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AlterarLoja(LojaEntidade lojaEntidade)
        {
            LojaDAO lojaDAO = new LojaDAO();
            lojaDAO.Alterar(lojaEntidade);
            MessageBox.Show("Loja alterada com sucesso!", "Alterar Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void DeletarLoja(LojaEntidade lojaEntidade)
        {
            LojaDAO lojaDAO = new LojaDAO();
            if (MessageBox.Show("Tem certeza que deseja excluir a Loja: \n" + lojaEntidade.Id + " - " + lojaEntidade.NomeLoja,
                "Excluir Loja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lojaDAO.Deletar(lojaEntidade.Id);
                MessageBox.Show("Loja excluir com sucesso!", "excluir Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasLojas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome Loja", typeof(string));
            dataTable.Columns.Add("CNPJ", typeof(string));
            dataTable.Columns.Add("Nome Fantasia", typeof(string));
            dataTable.Columns.Add("Razao Social", typeof(string));

            LojaDAO lojaDAO = new LojaDAO();

            List<LojaEntidade> listLojaEntidade = lojaDAO.BuscarTodasLojas();

            for (int i = 0; i < listLojaEntidade.Count && listLojaEntidade != null; i++)
            {
                dataTable.Rows.Add(listLojaEntidade[i].Id, listLojaEntidade[i].NomeLoja, listLojaEntidade[i].Cnpj,
                    listLojaEntidade[i].NomeFantasia, listLojaEntidade[i].RazaoSocial);
            }

            return dataTable;
        }

        public LojaEntidade BuscarLojaPorId(int id)
        {
            LojaDAO lojaDAO = new LojaDAO();

            return lojaDAO.BuscarLojaPorId(id);
        }
    }
}
