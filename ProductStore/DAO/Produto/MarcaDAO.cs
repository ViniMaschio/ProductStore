using ProductStore.Entidades.Produto;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Produto
{
    public class MarcaDAO : ConfiguraBD
    {
        public MarcaDAO() { }

        public void Add(string marca)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "insert into marca(nomemarca) values(upper(@nomemarca));";

                    cmd.Parameters.AddWithValue("@nomemarca", marca);

                    cmd.ExecuteNonQuery();

                }

                conn.Close();
            }
        }

        public void Alterar(MarcaEntidade marca)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update marca set nomemarca = upper(@marca) where codmarca = @codmarca";

                    cmd.Parameters.AddWithValue("@marca", marca.Marca);
                    cmd.Parameters.AddWithValue("codmarca", marca.Id);


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



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from marca where codmarca = @codmarca";

                    cmd.Parameters.AddWithValue("@codmarca", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                conn.Close();

            }

        }

        public List<MarcaEntidade> PesquisarTodos()
        {
            List<MarcaEntidade> listaMarca = new List<MarcaEntidade>();
            SqlDataReader reader;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                string query = "select * from marca;";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaMarca.Add(new MarcaEntidade()
                    {
                        Id = (int)reader["codmarca"],
                        Marca = (string)reader["nomemarca"]

                    });
                }
                conn.Close();

            }

            return listaMarca;
        }

        public MarcaEntidade BuscarId(int id)
        {

            MarcaEntidade marca = new MarcaEntidade();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select codmarca, nomemarca from marca where codmarca = @codmarca";

                    cmd.Parameters.AddWithValue("@codmarca", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    marca.Id = (int)reader["codmarca"];
                    marca.Marca = (string)reader["nomemarca"];


                }

                conn.Close();

            }
            return marca;
        }



    }
}
