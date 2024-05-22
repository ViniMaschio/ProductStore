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
    public class CidadeDao : ConfiguraBD
    {
        public CidadeDao() { }

        public List<CidadeEntidade> BuscarCidadesPorUf(int ufId)
        {
            List < CidadeEntidade > listCidadeEntidade = null;
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cidade where coduf_fk = @coduf";
                    cmd.Parameters.AddWithValue("@coduf",ufId);



                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listCidadeEntidade.Add(new CidadeEntidade()
                            {
                                Id = (int)reader["codcidade"],
                                Nomecidade = (string)reader["nomecidade"],
                                Coduf = (int)reader["coduf_fk"]
                            });
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Cidade Por Uf"); }
                }

                conn.Close();
            }
            return listCidadeEntidade;
        }

        public CidadeEntidade BuscarCidadePorID(int id)
        {
            CidadeEntidade cidadeEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cidade where codcidade = @codcidade";
                    cmd.Parameters.AddWithValue("@codcidade", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        cidadeEntidade = new CidadeEntidade()
                        {
                            Id = (int)reader["codcidade"],
                            Nomecidade = (string)reader["nomecidade"],
                            Coduf = (int)reader["coduf_fk"]
                        };
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Buscar Cidade Por Id"); }
                }
                conn.Close();
            }

            return cidadeEntidade;
        }
    }
}
