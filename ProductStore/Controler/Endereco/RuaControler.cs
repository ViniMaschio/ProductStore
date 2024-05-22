using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Endereco
{
    public class RuaControler
    {
        public RuaControler() { }   

        public void NovaRua(RuaEntidade ruaEntidade)
        {
            RuaDAO rauDAO = new RuaDAO();
            rauDAO.Add(ruaEntidade);
            MessageBox.Show("Produto Adicionado com Sucesso!", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void AlterarRua(RuaEntidade ruaEntidade)
        {
            RuaDAO rauDAO = new RuaDAO();
            rauDAO.Update(ruaEntidade);
            MessageBox.Show("Produto Alterado com Sucesso!", "Alterar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void DeletarRua(RuaEntidade ruaEntidade)
        {
            RuaDAO rauDAO = new RuaDAO();
            if (MessageBox.Show("Deseja Excluir a rua:\n"+ruaEntidade.Id+" - "+ ruaEntidade.Rua,"Deletar Rua",MessageBoxButtons.YesNo)== DialogResult.Yes) {
                rauDAO.Delete(ruaEntidade.Id);
                MessageBox.Show("Produto Alterado com Sucesso!", "Alterar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BuscarTodasRuas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Rua");

            RuaDAO ruaDAO = new RuaDAO();
            List<RuaEntidade> listRua = ruaDAO.BuscarTodos();

            for(int i = 0; i < listRua.Count && listRua != null; i++)
            {
                dt.Rows.Add(listRua[i].Id, listRua[i].Rua);
            }

            return dt;
        }

        public string BuscarPorId(int id)
        {
            RuaDAO ruaDAO=new RuaDAO();

            return ruaDAO.BuscarPorID(id);
        }
    }
}
