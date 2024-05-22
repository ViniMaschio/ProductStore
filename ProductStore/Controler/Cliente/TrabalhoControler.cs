using ProductStore.DAO.Cliente;
using ProductStore.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Cliente
{
    public class TrabalhoControler
    {
        public TrabalhoControler() { }

        public void AddTrabalho(TrabalhoEntidade trabalhoEntidade)
        {
            TrabalhoDao trabalhoDao = new TrabalhoDao();
            trabalhoDao.Add(trabalhoEntidade);
            MessageBox.Show("Trabalho Adicionado com sucesso!","Adicionar Trabalho",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlterarTrabalho(TrabalhoEntidade trabalhoEntidade)
        {
            TrabalhoDao trabalhoDao = new TrabalhoDao();
            trabalhoDao.Updade(trabalhoEntidade);
            MessageBox.Show("Trabalho Alterado com sucesso!", "Alterado Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarTrabalho(TrabalhoEntidade trabalhoEntidade)
        {
            TrabalhoDao trabalhoDao = new TrabalhoDao();
            if (MessageBox.Show("Tem certeza que deseja excluir o trabalho: \n" + trabalhoEntidade.Id + " - " + trabalhoEntidade.NomeTrabalho, "Excluir Trabalho",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trabalhoDao.Delete(trabalhoEntidade.Id);
                MessageBox.Show("Trabalho Excluido com sucesso!", "Excluir Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosTrabalho()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Trabalho");

            TrabalhoDao trabalhoDao = new TrabalhoDao();

            List<TrabalhoEntidade> listTrabalhoEntidade = trabalhoDao.BuscarTodosTrabalho();

            for(int i = 0; i<listTrabalhoEntidade.Count && listTrabalhoEntidade != null; i++)
            {
                dataTable.Rows.Add(listTrabalhoEntidade[i].Id, listTrabalhoEntidade[i].NomeTrabalho);
            }

            return dataTable;
        }

        public string BuscarTrabalhoPorId(int id)
        {   
            
            TrabalhoDao trabalhoDao = new TrabalhoDao();
            TrabalhoEntidade trabalhoEntidade = trabalhoDao.BuscarTrabalhoPorId(id);

            return trabalhoEntidade.NomeTrabalho;
        }
    }
}
