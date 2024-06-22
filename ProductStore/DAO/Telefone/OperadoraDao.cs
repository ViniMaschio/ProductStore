using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Telefone
{
    public class OperadoraDao : ConfiguraBD
    {
        public OperadoraDao() { }

        public List<OperadoraEntidade> BuscarTodasOperadora()
        {
            List<OperadoraEntidade> listOperadoraEntidade = new List<OperadoraEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from operadora;";

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listOperadoraEntidade.Add(new OperadoraEntidade() { Id = (int)reader["codoperadora"], NomeOperadora = (string)reader["nomeoperadora"] });
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return listOperadoraEntidade;

        }

        public string BuscarOperadoraPorId(int id)
        {
            string operadora = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from operadora where codoperadora = @codoperadora ;";
                    cmd.Parameters.AddWithValue("@codoperadora", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();
                        operadora = (string)reader["nomeoperadora"];
                    }

                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }
                conn.Close();
            }

            return operadora;
        }
    }
}
