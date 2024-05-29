using ProductStore.Controler.Endereco;
using ProductStore.DAO.Funcionario;
using ProductStore.Entidades.Endereco;
using ProductStore.Entidades.Funcionario;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Funcionario
{
    public class FuncionarioControler
    {
        public FuncionarioControler() { }

        public void AddFuncionario(FuncionarioEntidade funcionarioEntidade)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.Add(funcionarioEntidade);
            MessageBox.Show("Funcionario Adicionado com sucesso!", "Adicionar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AlterarFuncionario(FuncionarioEntidade funcionarioEntidade)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.Alterar(funcionarioEntidade);
            MessageBox.Show("Funcionario Altearado com sucesso!", "Alterar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void DeletarFuncionario(FuncionarioEntidade funcionarioEntidade)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            if (MessageBox.Show("Deseja excluir o funcionario: \n" + funcionarioEntidade.Id + " - " + funcionarioEntidade.NomeFuncionario,
                "Excluir Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionarioDAO.Deletar(funcionarioEntidade.Id);
                MessageBox.Show("Funcionario Adicionado com sucesso!", "Adicionar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosFuncionarios()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome Funcionario");
            dataTable.Columns.Add("Loja");
            dataTable.Columns.Add("Funcao");
            dataTable.Columns.Add("Salario");
            dataTable.Columns.Add("Rua");
            dataTable.Columns.Add("Numero");
            dataTable.Columns.Add("Bairro");
            dataTable.Columns.Add("Cidade");
            dataTable.Columns.Add("CEP");

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            LojaControler lojaControler = new LojaControler();
            LojaEntidade lojaEntidade = null;

            FuncaoControler funcaoControler = new FuncaoControler();

            RuaControler ruaControler = new RuaControler();
            BairroControler bairroControler = new BairroControler();
            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = null;
            CepControler cepControler = new CepControler();

            List<FuncionarioEntidade> listFuncionarioEntidade = funcionarioDAO.BuscarTodosFuncionarios();

            for (int i = 0; i < listFuncionarioEntidade.Count && listFuncionarioEntidade != null; i++)
            {
                lojaEntidade = lojaControler.BuscarLojaPorId(listFuncionarioEntidade[i].CodLoja);
                cidadeEntidade = cidadeControler.BuscarCidadePorId(listFuncionarioEntidade[i].CodCidade);

                dataTable.Rows.Add(listFuncionarioEntidade[i].Id,
                    listFuncionarioEntidade[i].NomeFuncionario,
                    lojaEntidade.NomeLoja,
                    funcaoControler.BuscarFuncaoPorId(listFuncionarioEntidade[i].CodFuncao),
                    listFuncionarioEntidade[i].Salario,
                    ruaControler.BuscarPorId(listFuncionarioEntidade[i].CodRua),
                    listFuncionarioEntidade[i].NumeroCasa,
                    bairroControler.BuscarPorId(listFuncionarioEntidade[i].CodBairro),
                    cidadeEntidade.Nomecidade,
                    cepControler.BuscarCepPorId(listFuncionarioEntidade[i].CodCep)
                    );

            }
            return dataTable;
        }

        public FuncionarioEntidade BuscarFuncionarioPorId(int id)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            return funcionarioDAO.BuscarFuncionarioPorId(id);
        }
    }
}
