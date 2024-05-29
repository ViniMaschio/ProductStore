
using ProductStore.Entidades.Produto;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Produto
{
    public class TipoDAO : ConfiguraBD
    {
        public TipoDAO() { }


        public void Add(string tipo)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into tipo(nometipo) values(upper(@tipo));";
                    cmd.Parameters.AddWithValue("@tipo", tipo);

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

        public void Alterar(TipoEntidade tipo)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update tipo set nometipo = upper(@tipo) where codtipo = @codtipo;";

                    cmd.Parameters.AddWithValue("@tipo", tipo.Tipo);
                    cmd.Parameters.AddWithValue("@codtipo", tipo.Id);

                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Alterar");
                    }

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
                    cmd.CommandText = "delete from tipo where codtipo = @codtipo;";
                    cmd.Parameters.AddWithValue("@codtipo", id);

                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Remover");
                    }
                }
                conn.Close();
            }

        }

        public List<TipoEntidade> PesquisarTodos()
        {
            List<TipoEntidade> listaTipo = new List<TipoEntidade>();
            SqlDataReader reader;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tipo;";

                    try
                    {
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listaTipo.Add(new TipoEntidade()
                            {
                                Id = (int)reader["codtipo"],
                                Tipo = (string)reader["nometipo"]

                            });
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Remover");
                    }
                }
                conn.Close();
            }

            return listaTipo;
        }

        public TipoEntidade BuscarId(int id)
        {

            TipoEntidade tipo = new TipoEntidade();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select codtipo, nometipo from tipo where codtipo = @codtipo;";
                    cmd.Parameters.AddWithValue("@codtipo", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        tipo.Id = (int)reader["codtipo"];
                        tipo.Tipo = (string)reader["nometipo"];
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Erro Buscar por ID"); }
                }
                conn.Close();
            }
            return tipo;
        }

        public int BuscarNameRetunId(string name)
        {
            int id = 0;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select codtipo from tipo where nometipo = upper(@nometipo);";
                    cmd.Parameters.AddWithValue("@nometipo", name);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        id = (int)reader["codtipo"];
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Erro Buscar por Nome"); }
                }
                conn.Close();
            }

            return id;
        }
    }
}
