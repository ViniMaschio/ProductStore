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
    public class TipoControler
    {

        public TipoControler() { }

        public DataTable BuscarTodosTipos()
        {

            TipoDAO tiponDAO = new TipoDAO();
            DataTable tipo = new DataTable();
            List<TipoEntidade> TipoEntidadeList = tiponDAO.PesquisarTodos();

            tipo.Columns.Add("ID", typeof(int));
            tipo.Columns.Add("Tipo", typeof(string));
            
                int i = 0;
                while (TipoEntidadeList != null && i < TipoEntidadeList.Count)
                {
                    tipo.Rows.Add(TipoEntidadeList[i].Id, TipoEntidadeList[i].Tipo);
                    i++;
                }

            return tipo;
        }

        public string BuscarId(int id)
        {
            TipoDAO tipoDAO = new TipoDAO();
            TipoEntidade tipoEntidade = tipoDAO.BuscarId(id);

            return tipoEntidade.Tipo;
        }

        public void RemoverTipo(TipoEntidade tipoEntidade)
        {
            TipoDAO tipoDAO=new TipoDAO();

            if(MessageBox.Show("Tem certeza que deseja excluir: \n " + tipoEntidade.Id + " - " + tipoEntidade.Tipo, "Excluir Tipo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipoDAO.Remover(tipoEntidade.Id);
                MessageBox.Show("Tipo Removido com sucesso!", "Remover Tipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void AlterarTipo(TipoEntidade tipoEntidade)
        {
            TipoDAO tipoDAO = new TipoDAO();
            tipoDAO.Alterar(tipoEntidade);

            MessageBox.Show("Tipo alterado com sucesso!","Alterar Tipo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        public void Add(TipoEntidade tipoEntidade)
        {
            TipoDAO tipoDAO = new TipoDAO();

            tipoDAO.Add(tipoEntidade.Tipo);

            MessageBox.Show("Tipo adicionado com sucesso!", "Adiciona Tipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
