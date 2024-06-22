using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Telefone
{
    public class ItensTelefoneLojaDAO : ConfiguraBD
    {

        public void Add(ItensTelefoneLojaEntidade itensTelefoneLojaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into itenstelefoneloja(codloja_fk,codtelefone_fk) values (@codloja,@codtelefone);";
                    cmd.Parameters.AddWithValue("@codloja", itensTelefoneLojaEntidade.CodLoja);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneLojaEntidade.CodTelefone);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Deletar(ItensTelefoneLojaEntidade itensTelefoneLojaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itenstelefoneloja where codloja_fk = @codloja and codtelefone_fk = @codtelefone;";
                    cmd.Parameters.AddWithValue("@codloja", itensTelefoneLojaEntidade.CodLoja);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneLojaEntidade.CodTelefone);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<ItensTelefoneLojaEntidade> BuscarTelefonePorLoja(int idLoja)
        {

            List<ItensTelefoneLojaEntidade> listItensTelefoneLojaEntidades = new List<ItensTelefoneLojaEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itenstelefoneloja where codloja_fk = @codloja";
                    cmd.Parameters.AddWithValue("@codloja", idLoja);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensTelefoneLojaEntidades.Add(new ItensTelefoneLojaEntidade()
                        {
                            CodLoja = (int)reader["codloja_fk"],
                            CodTelefone = (int)reader["codtelefone_fk"]
                        });
                    }

                }
                conn.Close();
            }

            return listItensTelefoneLojaEntidades;
        }
    }
}
