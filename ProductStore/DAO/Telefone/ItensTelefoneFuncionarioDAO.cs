using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Telefone
{
    public class ItensTelefoneFuncionarioDAO : ConfiguraBD
    {
        public void Add(ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand()) 
                {
                    cmd.CommandText = "insert into itenstelefonefuncionario(codfuncionario_fk,codtelefone_fk) values(@codfuncionario,@codtelefone);";
                    cmd.Parameters.AddWithValue("@codfuncionario", itensTelefoneFuncionarioEntidade.CodFuncionario);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFuncionarioEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }
        }

        public void Deletar(ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itenstelefonefuncionario where codfuncionario_fk = @codfuncionario and codtelefone_fk = @codtelefone);";
                    cmd.Parameters.AddWithValue("@codfuncionario", itensTelefoneFuncionarioEntidade.CodFuncionario);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFuncionarioEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }
        }

        public List<ItensTelefoneFuncionarioEntidade> BuscarTodosTelefonePorFuncionario(int id)
        {
            List<ItensTelefoneFuncionarioEntidade> listItensTelefoneFuncionarioEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itenstelefonefuncionario where codfuncionario_fk = @codfuncionario;";
                    cmd.Parameters.AddWithValue("@codfuncionario", id);
                    

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listItensTelefoneFuncionarioEntidade.Add(new ItensTelefoneFuncionarioEntidade()
                            {
                                CodFuncionario = (int)reader["codfuncionario_fk"],
                                CodTelefone = (int)reader["codtelefone_fk"]
                            });
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }

            return listItensTelefoneFuncionarioEntidade;
        }
    }
}
