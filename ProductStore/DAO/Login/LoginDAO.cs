using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Login
{
    public class LoginDAO : ConfiguraBD
    {
        public LoginDAO() { }


        public int Add(LoginEntidade loginEntidade)
        {
            int codLogin = 0;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into login(usuario,senha,codfuncionario_fk) values(@usuario,@senha,@codfuncionario)SELECT SCOPE_IDENTITY() as codLogin;";
                    cmd.Parameters.AddWithValue("@usuario",loginEntidade.Usuario);
                    cmd.Parameters.AddWithValue("@senha",loginEntidade.Senha);
                    cmd.Parameters.AddWithValue("@codfuncionario",loginEntidade.Funcionario);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        codLogin = int.Parse(reader["codLogin"].ToString());
                    }
                }

                conn.Close();

            }

            return codLogin;
        }

        public void Alterar(LoginEntidade loginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
               
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update login set  usuario = @usuario, senha = @senha, codfuncionario_fk = @funcionario where codlogin = @codlogin;";
                    cmd.Parameters.AddWithValue("@usuario", loginEntidade.Usuario);
                    cmd.Parameters.AddWithValue("@senha",loginEntidade.Senha);
                    cmd.Parameters.AddWithValue("@funcionario", loginEntidade.Funcionario);
                    cmd.Parameters.AddWithValue("@codlogin", loginEntidade.Id);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void Remover(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from login where codlogin = @codlogin; ";
                    cmd.Parameters.AddWithValue("@codlogin", id);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }

        public List<LoginEntidade> PesquisarTodos()
        {
            List<LoginEntidade> listaLogin = new List<LoginEntidade>();
 
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from login;";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaLogin.Add(new LoginEntidade()
                        {
                            Id = (int)reader["codlogin"],
                            Usuario = reader["usuario"].ToString(),
                            Senha = reader["senha"].ToString(),
                            Funcionario = (int)reader["codfuncionario_fk"]
                        });
                    }
                }
            }

            return listaLogin;
        }

        public LoginEntidade PesquisarUsuarioSenha(string usuario, string senha)
        {
            LoginEntidade loginEntidade = new LoginEntidade();
            

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                string query = "select codlogin, usuario , codfuncionario_fk from login where usuario = '" + usuario + "' and senha = '" + senha + "';";
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from login where usuario = @usuario and senha = @senha";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        loginEntidade.Id = (int)reader["codlogin"];
                        loginEntidade.Senha = reader["senha"].ToString();
                        loginEntidade.Usuario = reader["usuario"].ToString();
                        loginEntidade.Funcionario = (int)reader["codfuncionario_fk"];
                    }
                }

                conn.Close();
            }

            return loginEntidade;
        }

        public LoginEntidade BuscarLoginPorId(int codLogin)
        {
            LoginEntidade loginEntidade = new LoginEntidade();

            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from login where codlogin = @codlogin;";
                    cmd.Parameters.AddWithValue("@codlogin",codLogin);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        loginEntidade.Id = (int)reader["codlogin"];
                        loginEntidade.Senha = reader["senha"].ToString();
                        loginEntidade.Funcionario = (int)reader["codfuncionario_fk"] ;
                        loginEntidade.Usuario = reader["usuario"].ToString() ;

                    }
                }
                conn.Close();
            }

            return loginEntidade ;
        }
    }
}
