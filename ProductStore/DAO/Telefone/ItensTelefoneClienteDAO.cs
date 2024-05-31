using ProductStore.Entidades.Telefone;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Telefone
{
    public class ItensTelefoneClienteDAO : ConfiguraBD
    {
        public void Add(ItensTelefoneClienteEntidade itensTelefoneClienteEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into itenstelefonecliente(codtelefone_fk,codcliente_fk) values (@codtelefone,@codcliente);";
                    cmd.Parameters.AddWithValue("@codcliente", itensTelefoneClienteEntidade.CodCliente);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneClienteEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                conn.Close();
            }
        }

        public void Delete(ItensTelefoneClienteEntidade itensTelefoneClienteEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itenstelefonecliente where codtelefone_fk =@codtelefone and codcliente_fk = @codcliente ;";
                    cmd.Parameters.AddWithValue("@codcliente", itensTelefoneClienteEntidade.CodCliente);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneClienteEntidade.CodTelefone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                conn.Close();
            }
        }

        public List<ItensTelefoneClienteEntidade> BuscarClienteTelefonePorCliente(int id)
        {
            List<ItensTelefoneClienteEntidade> listaItensTelefoneClienteEntidade = new List<ItensTelefoneClienteEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from itenstelefonecliente where  codcliente_fk = @codcliente ;";
                    cmd.Parameters.AddWithValue("@codcliente", id);


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaItensTelefoneClienteEntidade.Add(new ItensTelefoneClienteEntidade()
                            {
                                CodCliente = (int)reader["codcliente_fk"],
                                CodTelefone = (int)reader["codtelefone_fk"]
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                conn.Close();
            }

            return listaItensTelefoneClienteEntidade;

        }
    }
}
