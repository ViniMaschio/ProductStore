using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Login
{
    public class ControleLogSistemaDAO : ConfiguraBD
    {
        public ControleLogSistemaDAO() { }

        public void Add(int codLogin)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {   
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into controlelogsistema(codlogin_fk,datalog,hora) values(@codlogin,@datalog,@hora)";
                    cmd.Parameters.AddWithValue("@codlogin", codLogin);
                    cmd.Parameters.AddWithValue("@datalog", DateTime.Today.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now.TimeOfDay);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    
                }
            }
        }

        public List<ControleLogSistemaEntidade> BuscarLogPorLogin(int id)
        {
            List<ControleLogSistemaEntidade> listControleLogSistemaEntidade = null;

            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand()) 
                {
                    cmd.CommandText = "select * from controlelogsistema where codlogin_fk = @codlogin;";
                    cmd.Parameters.AddWithValue("@codlogin",id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listControleLogSistemaEntidade.Add(new ControleLogSistemaEntidade()
                            {
                                CodLogin = (int)reader["codlogin_fk"],
                                Id = (int)reader["codcontrole"],
                                DataLog = (DateTime)reader["datalog"],
                                Hora = (TimeSpan)reader["hora"]
                            });
                        }
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                conn.Close();
            }

            return listControleLogSistemaEntidade;
        }
    }
}
