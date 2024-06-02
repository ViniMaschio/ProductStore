using ProductStore.Entidades.Login;
using System.Data.SqlClient;

namespace ProductStore.DAO.Login
{
    public class ItensAcessoLoginDAO : ConfiguraBD
    {
        public ItensAcessoLoginDAO() { }

        public void Add(ItensAcessoLoginEntidade itensAcessoLoginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into itensacessologin(codlogin_fk,codacesso_fk) values(@codlogin,@codacesso);";
                    cmd.Parameters.AddWithValue("@codlogin", itensAcessoLoginEntidade.CodLogin);
                    cmd.Parameters.AddWithValue("@codacesso", itensAcessoLoginEntidade.CodAcesso);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Alterar(ItensAcessoLoginEntidade itensAcessoLoginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            { 
                conn.Open(); 

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update itensacessologin set codacesso_fk = @codacesso where codlogin_fk = @codlogin;";
                    cmd.Parameters.AddWithValue("@codacesso", itensAcessoLoginEntidade.CodAcesso);
                    cmd.Parameters.AddWithValue("@codlogin", itensAcessoLoginEntidade.CodLogin);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Delete(ItensAcessoLoginEntidade itensAcessoLoginEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itensacessologin where codlogin_fk = @codlogin and codacesso_fk = @codacesso);";
                    cmd.Parameters.AddWithValue("@codlogin", itensAcessoLoginEntidade.CodLogin);
                    cmd.Parameters.AddWithValue("@codacesso", itensAcessoLoginEntidade.CodAcesso);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public ItensAcessoLoginEntidade BuscarAcessoPorLogin(int idLogin)
        {
            ItensAcessoLoginEntidade itensAcessoLoginEntidade = new ItensAcessoLoginEntidade();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itensacessologin where codlogin_fk = @codlogin;";
                    cmd.Parameters.AddWithValue("@codlogin", idLogin);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        itensAcessoLoginEntidade = new ItensAcessoLoginEntidade()
                        {
                            CodAcesso = (int)reader["codacesso_fk"],
                            CodLogin = (int)reader["codlogin_fk"]
                        };
                    }
                }
                conn.Close();
            }

            return itensAcessoLoginEntidade;

        }
    }
}
