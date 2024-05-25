using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAO.Login
{
    public class ItensAcessoLoginDAO :ConfiguraBD
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
            ItensAcessoLoginEntidade itensAcessoLoginEntidade = null;   

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itensacessologin where codlogin_fk = @codlogin;";
                    cmd.Parameters.AddWithValue("@codlogin", itensAcessoLoginEntidade.CodLogin);
                    

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    itensAcessoLoginEntidade = new ItensAcessoLoginEntidade()
                    {
                        CodAcesso = (int)reader["codacesso_fk"],
                        CodLogin = (int)reader["codlogin_fk"]
                    };
                }
                conn.Close();
            }

            return itensAcessoLoginEntidade;

        }
    }
}
