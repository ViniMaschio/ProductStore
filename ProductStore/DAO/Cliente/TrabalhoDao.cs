using ProductStore.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Cliente
{
    public class TrabalhoDao :ConfiguraBD
    {
        public TrabalhoDao() { }

        public void Add(TrabalhoEntidade trabalhoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into trabalho(nometrabalho) values(upper(@codtrabalho));";
                    cmd.Parameters.AddWithValue("@codtrabalho", trabalhoEntidade.NomeTrabalho);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
                }
                conn.Close();
            }
        }

        public void Updade(TrabalhoEntidade trabalhoEntidade)
        {
            using(SqlConnection conn = new SqlConnection(_stringconnetion)) 
            { 
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update trabalho set nometrabalho = upper(@trabalho) where codtrabalho = @codtrabalho;";
                    cmd.Parameters.AddWithValue("@trabalho", trabalhoEntidade.NomeTrabalho);
                    cmd.Parameters.AddWithValue("@codtrabalho", trabalhoEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
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
                    cmd.CommandText = "delete from tabalho where codtrabalho = @codtrabalho";
                    cmd.Parameters.AddWithValue("@codtrabalho", id);

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

        public List<TrabalhoEntidade> BuscarTodosTrabalho()
        {
            List<TrabalhoEntidade> listTrabalhoEntidade = null;

            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from trabalho;";
                    
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                       
                        while (reader.Read())
                        {
                            listTrabalhoEntidade.Add(new TrabalhoEntidade()
                            {
                                Id = (int)reader["codtrabalho"],
                                NomeTrabalho = (string)reader["nometrabalho"]
                            });
                        }
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return listTrabalhoEntidade;
        }

        public TrabalhoEntidade BuscarTrabalhoPorId(int id)
        {
            TrabalhoEntidade trabalhoEntidade = null;

            using(SqlConnection conn =new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using( SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from trabalho where codtrabalho = @codtrabalho";
                    cmd.Parameters.AddWithValue("@codtrabalho", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        trabalhoEntidade.Id = (int)reader["codtrabalho"];
                        trabalhoEntidade.NomeTrabalho = (string)reader["nometrabalho"];
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return trabalhoEntidade;


        }
    }
}
