using ProductStore.Entidades.Boletos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Boletos
{
    public class SituacaoDAO : ConfiguraBD
    {
        public SituacaoDAO() { }

        public List<SituacaoEntidade> BuscarTodasSituacao()
        {
            List<SituacaoEntidade> listSituacaoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from situacao;";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listSituacaoEntidade.Add(new SituacaoEntidade()
                        {
                            Id = (int)reader["codsituacao"],
                            NomeSituacao = (string)reader["nomesituacao"]
                        });
                    }
                }

                conn.Close();
            }

            return listSituacaoEntidade;
        }

        public SituacaoEntidade BuscaoSituacaoPorId(int codSituacao)
        {
            SituacaoEntidade situacaoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from situacao where codsituacao = @codsituacao;";
                    cmd.Parameters.AddWithValue("@codsituacao", codSituacao);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        situacaoEntidade = new SituacaoEntidade()
                        {
                            Id = (int)reader["codsituacao"],
                            NomeSituacao = (string)reader["nomesituacao"]
                        };
                    }
                }

                conn.Close();
            }

            return situacaoEntidade;
        }
    }
}
