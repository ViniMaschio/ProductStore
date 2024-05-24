using ProductStore.DAO.Funcionario;
using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Funcionario
{
    public class FuncaoControler
    {
        public FuncaoControler() { }    

        public void AdicionarFuncao(FuncaoEntidade funcaoEntidade)
        {
            FuncaoDAO funcaoDAO = new FuncaoDAO();  
            funcaoDAO.Add(funcaoEntidade);
            MessageBox.Show("Funcao Adicionada com sucesso!", "Adicionar Funcao",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public void AlterarFuncao(FuncaoEntidade funcaoEntidade)
        {
            FuncaoDAO funcaoDAO = new FuncaoDAO();
            funcaoDAO.Alterar(funcaoEntidade);
            MessageBox.Show("Funcao Alterada com sucesso!", "Alterar Funcao", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void RemoverFuncao(FuncaoEntidade funcaoEntidade)
        {
            FuncaoDAO funcaoDAO = new FuncaoDAO();
            if (MessageBox.Show("Tem certeza que deseja excluir a funcao: \n" + funcaoEntidade.Id + " - " + funcaoEntidade.NomeFuncao,
                "Remover Funcao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcaoDAO.Delete(funcaoEntidade.Id);
                MessageBox.Show("Funcao Removida com sucesso!", "Remover Funcao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasFuncao()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Funcao");

            FuncaoDAO funcaoDAO = new FuncaoDAO();

            List<FuncaoEntidade> listFuncaoEntidade = funcaoDAO.BuscarTodasFuncao();

            for (int i = 0; i < listFuncaoEntidade.Count && listFuncaoEntidade != null; i++) 
            {
                dataTable.Rows.Add(listFuncaoEntidade[i].Id, listFuncaoEntidade[i].NomeFuncao);
            }
            return dataTable;
        }

        public string BuscarFuncaoPorId(int id)
        {
            FuncaoDAO funcaoDAO = new FuncaoDAO();

            FuncaoEntidade funcaoEntidade = funcaoDAO.BuscarFuncaoPorId(id);

            return funcaoEntidade.NomeFuncao;
        }
    }
}
