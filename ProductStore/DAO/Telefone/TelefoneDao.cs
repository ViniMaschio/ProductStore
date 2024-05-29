using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Telefone
{
    public class TelefoneDao : ConfiguraBD
    {
        public TelefoneDao() { }

        public void Add(TelefoneEntidade telefoneEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into telefone(numero,codoperadora_fk) values(@numero,@codoperadora);";
                    cmd.Parameters.AddWithValue("@numero", telefoneEntidade.Telefone);
                    cmd.Parameters.AddWithValue("@codoperadora", telefoneEntidade.CodOperadora);

                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }

                }

                conn.Close();
            }
        }

        public void Update(TelefoneEntidade telefoneEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update telefone set numero = @numero, codoperadora_fk = @codoperadora where codtelefone = @codtelefone;";
                    cmd.Parameters.AddWithValue("@numero", telefoneEntidade.Telefone);
                    cmd.Parameters.AddWithValue("@codoperadora", telefoneEntidade.CodOperadora);
                    cmd.Parameters.AddWithValue("@codtelefone", telefoneEntidade.Id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                    cmd.CommandText = "Delete from telefone where codtelefone = @codtelefone;";
                    cmd.Parameters.AddWithValue("@codtelefone", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }
                conn.Close();
            }
        }

        public List<TelefoneEntidade> BuscarTodosTelefone()
        {
            List<TelefoneEntidade> listTelefoneEntidade = new List<TelefoneEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = " select * from telefone;";

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listTelefoneEntidade.Add(new TelefoneEntidade()
                            {
                                Id = (int)reader["codtelefone"],
                                Telefone = (string)reader["numero"],
                                CodOperadora = (int)reader["codoperadora_fk"]
                            });
                        }
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                conn.Close();

            }

            return listTelefoneEntidade;
        }

        public TelefoneEntidade BuscarTelefonePorId(int id)
        {
            TelefoneEntidade telefoneEntidade = new TelefoneEntidade();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from telefone where codtelefone = @codtelefone;";
                    cmd.Parameters.AddWithValue("@codtelefone", id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        telefoneEntidade = new TelefoneEntidade()
                        {
                            Id = (int)reader["codtelefone"],
                            Telefone = (string)reader["numero"],
                            CodOperadora = (int)reader["codoperadora_fk"]
                        };
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                conn.Close();

            }
            return telefoneEntidade;
        }
    }
}
