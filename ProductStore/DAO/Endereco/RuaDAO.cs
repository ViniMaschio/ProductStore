using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Endereco
{
    public class RuaDAO : ConfiguraBD
    {
        public RuaDAO() { }

        public void Add(RuaEntidade ruaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into rua(nomerua) values(upper(@nomerua));";
                    cmd.Parameters.AddWithValue("@nomerua", ruaEntidade.Rua);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Adicionar Rua"); }
                }

                conn.Close();
            }

        }

        public void Update(RuaEntidade ruaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update rua set nomerua = upper(@nomerua) where codrua = @codrua;";
                    cmd.Parameters.AddWithValue("@nomerua", ruaEntidade.Rua);
                    cmd.Parameters.AddWithValue("@codrua", ruaEntidade.Id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Alterar Rua");
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
                    cmd.CommandText = "delete from rua where codrua = @id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Deletar Rua"); }
                }

                conn.Close();
            }
        }

        public List<RuaEntidade> BuscarTodos()
        {
            List<RuaEntidade> RuaEntidade = new List<RuaEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from rua;";

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            RuaEntidade.Add(new RuaEntidade { Id = (int)reader["codrua"], Rua = (string)reader["nomerua"] });
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Todas Ruas"); }
                }

                conn.Close();

            }

            return RuaEntidade;
        }

        public string BuscarPorID(int id)
        {
            string rua = null;
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from rua where codrua = @codrua;";
                    cmd.Parameters.AddWithValue("@codrua", id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        rua = (string)reader["nomerua"];
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Todas Ruas"); }
                }

                conn.Close();

            }

            return rua;
        }
    }
}
