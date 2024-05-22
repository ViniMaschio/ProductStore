using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Telefone
{
    public class ItensTelefoneTrabalhoDAO :ConfiguraBD
    {
        public void Add(ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into itenstelefonetrabalho(codtrabalho_fk,codtelefone_fk) values (@codtrabalho,@codtelefone);";
                    cmd.Parameters.AddWithValue("@codtrabalho",itensTelefoneTrabalhoEntidade.CodTrabalho);
                    cmd.Parameters.AddWithValue("@codtelefone",itensTelefoneTrabalhoEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public void Delete(ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itenstelefonetrabalho where codtrabalho_fk = @codtrabalho and codtelefone_fk = @codtelefone;";
                    cmd.Parameters.AddWithValue("@codtrabalho", itensTelefoneTrabalhoEntidade.CodTrabalho);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneTrabalhoEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public List<ItensTelefoneTrabalhoEntidade> BuscarTelefonesPorTrabalho(int trabalho)
        {
            List<ItensTelefoneTrabalhoEntidade> listaItensTelefoneTrabalhoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itenstelefonetrabalho where codtrabalho_fk = @codtrabalho;";
                    cmd.Parameters.AddWithValue("@codtrabalho",trabalho);
                    
                    try
                    {
                        
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaItensTelefoneTrabalhoEntidade.Add(new ItensTelefoneTrabalhoEntidade()
                            {
                                CodTelefone = (int)reader["codtelefone_fk"],
                                CodTrabalho = (int)reader["codtrabalho_fk"]
                            });
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return listaItensTelefoneTrabalhoEntidade;
        }
    }
}
