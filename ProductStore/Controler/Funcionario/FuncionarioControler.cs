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
                MessageBox.Show("Funcionario Deletado com sucesso!", "Deletar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosFuncionarios()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nome Funcionario", typeof(string));
            dataTable.Columns.Add("Loja", typeof(string));
            dataTable.Columns.Add("Funcao", typeof(string));
            dataTable.Columns.Add("Salario", typeof(double));
            dataTable.Columns.Add("Rua", typeof(string));
            dataTable.Columns.Add("Numero", typeof(string));
            dataTable.Columns.Add("Bairro", typeof(string));
            dataTable.Columns.Add("Cidade", typeof(string));
            dataTable.Columns.Add("CEP", typeof(string));

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

            for (int i = 0; i < listFuncionarioEntidade.Count; i++)
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
