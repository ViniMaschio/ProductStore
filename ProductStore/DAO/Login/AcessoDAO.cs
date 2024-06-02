using ProductStore.Entidades.Login;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Login
{
    public class AcessoDAO : ConfiguraBD
    {

        public AcessoDAO() { }

        public List<AcessoEntidade> BuscarTodosAcesso()
        {

            List<AcessoEntidade> listAcessoEntidade = new List<AcessoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from acesso";


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listAcessoEntidade.Add(new AcessoEntidade()
                            {
                                Id = (int)reader["codacesso"],
                                NomeAcesso = (string)reader["nomeacesso"]
                            });
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return listAcessoEntidade;
        }

        public string BuscarAcessoPorId(int id)
        {
            string acesso = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from acesso where codacesso = @codacesso";
                    cmd.Parameters.AddWithValue("@codacesso", id);


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        acesso = (string)reader["nomeacesso"];

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return acesso;
        }
    }
}
