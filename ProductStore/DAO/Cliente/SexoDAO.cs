using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Pessoa
{
    public class SexoDAO:ConfiguraBD
    {
        public SexoDAO() { }

        public List<SexoEntidade> BuscarTodosSexo()
        {
            List<SexoEntidade> sexoEntidades = new List<SexoEntidade>();
            SqlDataReader reader;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from sexo;";

                    try
                    {
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            sexoEntidades.Add(new SexoEntidade()
                            {
                                Id = (int)reader["codsexo"],
                                Sexo = (string)reader["nomesexo"]

                            });
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Buscar Sexo");
                    }
                }
                conn.Close();
            }

            return sexoEntidades;
        }
        public string BuscarSexoPorID(int id)
        {
            string nome = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select nomesexo from sexo where codsexo = @codsexo;";
                    cmd.Parameters.AddWithValue("@codsexo", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();
                        nome = (string)reader["nomesexo"];
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Buscar Sexo por Id");
                    }
                }
                conn.Close();

             }

            return nome;
        }
    }
}
