using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Login;
using ProductStore.Entidades.Funcionario;
using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ProductStore.Controler.Login
{
    public class LoginControler
    {

        public LoginControler() { }

        public void AdicionarLogin(LoginEntidade loginEntidade, int codAcesso)
        {
            LoginDAO loginDAO = new LoginDAO();

            int codLogin = loginDAO.Add(loginEntidade);

            ItensAcessoLoginEntidade itensAcessoLoginEntidade = new ItensAcessoLoginEntidade() { CodAcesso = codAcesso, CodLogin = codLogin };

            ItensAcessoLoginControler itensAcessoLoginControler = new ItensAcessoLoginControler();
            itensAcessoLoginControler.AddAcesso(itensAcessoLoginEntidade);

            MessageBox.Show("Login Adicionado com sucesso!", "Adicionar Login", MessageBoxButtons.OK);

        }

        public void AlterarLogin(LoginEntidade loginEntidade, int codAcesso)
        {
            LoginDAO loginDAO = new LoginDAO();

            loginDAO.Alterar(loginEntidade);

            ItensAcessoLoginEntidade itensAcessoLoginEntidade = new ItensAcessoLoginEntidade() { CodAcesso = codAcesso, CodLogin = loginEntidade.Id };

            ItensAcessoLoginControler itensAcessoLoginControler = new ItensAcessoLoginControler();
            itensAcessoLoginControler.AlterarAcesso(itensAcessoLoginEntidade);

            MessageBox.Show("Login Alterado com sucesso!", "Alterar Login", MessageBoxButtons.OK);
        }

        public void ApagarLogin(LoginEntidade loginEntidade)
        {
            LoginDAO loginDAO = new LoginDAO();
            if (MessageBox.Show("Tem certeza que desejar remover o login: \n" + loginEntidade.Id + " - " + loginEntidade.Usuario, "Remover Login", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginDAO.Remover(loginEntidade.Id);
                MessageBox.Show("Removido com Sucesso!", "Remover Login", MessageBoxButtons.OK);
            }
        }

        public LoginEntidade VerificarLogin(string username, string password)
        {
            LoginDAO loginDAO = new LoginDAO();
            return loginDAO.PesquisarUsuarioSenha(username, password);
        }

        public DataTable BuscarTodosLogin()
        {

            LoginDAO loginDAO = new LoginDAO();
            List<LoginEntidade> loginEntidadeList = loginDAO.PesquisarTodos();

            FuncionarioControler funcionarioControler = new FuncionarioControler();

            DataTable usuariosLogin = new DataTable();
            usuariosLogin.Columns.Add("ID", typeof(int));
            usuariosLogin.Columns.Add("Usuario", typeof(string));
            usuariosLogin.Columns.Add("Password", typeof(string));
            usuariosLogin.Columns.Add("Funcionario", typeof(string));

            for (int i = 0; i < loginEntidadeList.Count; i++)
            {
                FuncionarioEntidade loginEntidade = funcionarioControler.BuscarFuncionarioPorId(loginEntidadeList[i].Funcionario);

                usuariosLogin.Rows.Add(loginEntidadeList[i].Id, loginEntidadeList[i].Usuario, "*******", loginEntidade.NomeFuncionario);

            }

            return usuariosLogin;
        }

        public LoginEntidade BuscarLoginPorId(int codLogin)
        {
            LoginDAO loginDAO = new LoginDAO();
            return loginDAO.BuscarLoginPorId(codLogin);
        }
    }
}
