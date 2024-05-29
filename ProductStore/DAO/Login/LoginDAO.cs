using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Login
{
    public class LoginDAO : ConfiguraBD
    {
        public LoginDAO() { }




        public void Add(LoginEntidade loginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                string querry = "inset into login(usuario,senha,codfuncionario_fk) values " +
                "('" + loginEntidade.Usuario + "','" + loginEntidade.Senha + "'," + loginEntidade.Funcionario + "); ";

                //string querry = "insert into login(usuario,senha,codfuncionario_fk) values('@usuario','@senha', @codfuncionario);";

                SqlCommand cmd = new SqlCommand(querry, conn);

                //cmd.Parameters["@usuario"].Value = loginEntidade.Usuario;
                // cmd.Parameters["@senha"].Value = loginEntidade.Senha;
                // cmd.Parameters["@codfuncionario"].Value = loginEntidade.Funcionario;

                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        public void Alterar(LoginEntidade loginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                string query = "update login usuario = '" + loginEntidade.Usuario + "', senha = '" + loginEntidade.Senha + "', codfuncionario_fk = " + loginEntidade.Funcionario + " where codlogin = " + loginEntidade.Id + ";";

                //string querry = "update login usuario = '@usuario', senha = '@senha', codfuncionario_fk = @funcionario where codlogin = @codlogin;";

                SqlCommand cmd = new SqlCommand(query, conn);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Remover(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                string query = "delete from login where codlogin = " + id + ";";



                SqlCommand cmd = new SqlCommand(query, conn);



                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        public List<LoginEntidade> PesquisarTodos()
        {
            List<LoginEntidade> listaLogin = new List<LoginEntidade>();
            SqlDataReader reader;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                string query = "select * from login;";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaLogin.Add(new LoginEntidade()
                    {
                        Id = (int)reader["codlogin"],
                        Usuario = (string)reader["usuario"],
                        Senha = (string)reader["senha"],
                        Funcionario = (int)reader["codfuncionario_fk"]
                    });
                }

            }

            return listaLogin;
        }

        public LoginEntidade PesquisarUsuarioSenha(string usuario, string senha)
        {
            LoginEntidade loginEntidade = new LoginEntidade();
            SqlDataReader reader;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                string query = "select codlogin, usuario , codfuncionario_fk from login where usuario = '" + usuario + "' and senha = '" + senha + "';";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                // cmd.Parameters["@usuario"].Value = usuario;
                // cmd.Parameters["@senha"].Value = senha;

                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    loginEntidade.Id = (int)reader["codlogin"];
                    loginEntidade.Senha = null;
                    loginEntidade.Usuario = (string)reader["usuario"];
                    loginEntidade.Funcionario = (int)reader["codfuncionario_fk"];

                }
                conn.Close();
            }

            return loginEntidade;
        }
    }
}
