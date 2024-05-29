using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Endereco
{
    public class CepDAO : ConfiguraBD
    {
        public CepDAO() { }

        public void Add(CepEntidade cepEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into cep(numerocep) values(@numerocep);";
                    cmd.Parameters.AddWithValue("@numerocep", cepEntidade.Cep);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Adicionar Cep"); }
                }
                conn.Close();
            }
        }

        public void Update(CepEntidade cepEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update cep set numerocep = @nomebairro where codcep = @codcep;";
                    cmd.Parameters.AddWithValue("@nomebairro", cepEntidade.Cep);
                    cmd.Parameters.AddWithValue("@codcep", cepEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Alterar Cep"); }
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
                    cmd.CommandText = "delete from cep where codcep = @codcep;";

                    cmd.Parameters.AddWithValue("@codcep", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Deletar Cep"); }
                }
                conn.Close();
            }
        }

        public List<CepEntidade> BuscarTodosCep()
        {
            List<CepEntidade> cepEntidade = new List<CepEntidade>();
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cep";



                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cepEntidade.Add(new CepEntidade() { Id = (int)reader["codcep"], Cep = (string)reader["numerocep"] });
                        }

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Cep"); }
                }
                conn.Close();
            }
            return cepEntidade;
        }

        public string BuscarCepPorId(int id)
        {
            string cep = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cep where codcep = @codcep";

                    cmd.Parameters.AddWithValue("@codcep", id);


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        cep = (string)reader["numerocep"];


                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Cep por Id"); }
                }

                conn.Close();
            }

            return cep;
        }
    }
}
