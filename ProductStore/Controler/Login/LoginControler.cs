using ProductStore.DAO.Login;
using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data;
namespace ProductStore.Controler.Login
{
    public class LoginControler
    {

        public LoginControler() { }


        public LoginEntidade VerificarLogin(string username, string password)
        {
            LoginDAO loginDAO = new LoginDAO();
            return loginDAO.PesquisarUsuarioSenha(username, password);
        }

        public DataTable BuscarTodosLogin()
        {

            LoginDAO loginDAO = new LoginDAO();
            DataTable usuariosLogin = new DataTable();
            List<LoginEntidade> loginEntidadeList = loginDAO.PesquisarTodos();

            usuariosLogin.Columns.Add("ID", typeof(int));
            usuariosLogin.Columns.Add("Usuario", typeof(string));
            usuariosLogin.Columns.Add("Password", typeof(string));
            usuariosLogin.Columns.Add("Funcionario", typeof(string));
            int i = 0;
            while (loginEntidadeList != null && i < loginEntidadeList.Count)
            {
                usuariosLogin.Rows.Add(loginEntidadeList[i].Id, loginEntidadeList[i].Usuario, loginEntidadeList[i].Senha, loginEntidadeList[i].Funcionario);
                i++;
            }

            return usuariosLogin;
        }
    }
}
