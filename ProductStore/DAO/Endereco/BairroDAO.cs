using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Endereco
{
    public class BairroDAO : ConfiguraBD
    {
        public BairroDAO() { }

        public void Add(BairroEntidade bairroEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into bairro(nomebairro) values(upper(@nomebairro));";
                    cmd.Parameters.AddWithValue("@nomebairro", bairroEntidade.Bairro);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Adicionar Bairro"); }
                }
                conn.Close();
            }
        }

        public void Update(BairroEntidade bairroEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update bairro set nomebairro = upper(@nomebairro) where codbairro = @codbairro;";
                    cmd.Parameters.AddWithValue("@nomebairro", bairroEntidade.Bairro);
                    cmd.Parameters.AddWithValue("@codbairro", bairroEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Alterar Bairro"); }
                }

                conn.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from bairro where codbairro = @codbairro;";

                    cmd.Parameters.AddWithValue("@codbairro", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Deletar Bairro"); }
                }

                conn.Close();
            }
        }

        public List<BairroEntidade> BuscarTodosBairro()
        {
            List<BairroEntidade> listaBairro = new List<BairroEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from bairro order by codbairro";



                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaBairro.Add(new BairroEntidade() { Id = (int)reader["codbairro"], Bairro = (string)reader["nomebairro"] });
                        }

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Bairro"); }
                }

                conn.Close();
            }
            return listaBairro;
        }

        public string BuscarPorID(int id)
        {
            string bairro = "";

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from bairro where codbairro = @codbairro";

                    cmd.Parameters.AddWithValue("@codbairro", id);


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        bairro = (string)reader["nomebairro"];


                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Bairro"); }
                }

                conn.Close();
            }

            return bairro;
        }
    }
}
