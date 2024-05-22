using ProductStore.Entidades.Endereco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Endereco
{
    public class UfDao : ConfiguraBD
    {
        public UfDao() { }

        public List<UfEntidade> BuscarTodosUf()
        {
            List < UfEntidade > listaUfEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from uf";



                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaUfEntidade.Add(new UfEntidade() { Id = (int)reader["coduf"],Nomeuf = (string)reader["nomeuf"], Sigla = (string)reader["sigla"] });
                        }

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Uf"); }
                }

                conn.Close();

            }

            return listaUfEntidade;
        }

        public UfEntidade BuscarUfPorIf(int id)
        {
            UfEntidade ufEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from uf where coduf = @coduf";
                    cmd.Parameters.AddWithValue("@coduf", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();
                        ufEntidade = new UfEntidade() { Id = (int)reader["coduf"], Nomeuf = (string)reader["nomeuf"], Sigla = (string)reader["sigla"] };
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Uf por Id"); }
                }

                conn.Close();
            }

            return ufEntidade;
        }
    }
}
