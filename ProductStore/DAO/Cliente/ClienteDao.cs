using ProductStore.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Cliente
{
    public class ClienteDao : ConfiguraBD
    {
        public ClienteDao() { }

        public void Add(ClienteEntidade clienteEntidade)
        {
            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into cliente(nomecliente,foto,datanasc,codsex_fk,codrua_fk,codbairro_fk,codcep_fk,codcidade_fk,salario,codtrabalho_fk,numerocasa)" +
                        "values (upper(@nomecliente),@foto,@datanasc,@codsex,@codrua,@codbairro, @codcep, @codcidade,@salario,@codtrabalho,@numerocasa);";
                   
                    cmd.Parameters.AddWithValue("@nomecliente", clienteEntidade.NomeCliente);
                    cmd.Parameters.AddWithValue("@foto", clienteEntidade.Foto);
                    cmd.Parameters.AddWithValue("@datanasc", clienteEntidade.Datanasc);
                    cmd.Parameters.AddWithValue("@codsex", clienteEntidade.CodSexo);
                    cmd.Parameters.AddWithValue("@codrua", clienteEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", clienteEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcep", clienteEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@codcidade", clienteEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@salario", clienteEntidade.Salario);
                    cmd.Parameters.AddWithValue("@codtrabalho", clienteEntidade.CodTrabalho);
                    cmd.Parameters.AddWithValue("@numerocasa", clienteEntidade.NumeroCasa);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public void Update(ClienteEntidade clienteEntidade)
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "update cliente set nomecliente = @nomecliente, foto = @foto, datanasc = @datanasc , codsex_fk = @codsex," +
                        "codrua_fk = @codrua, codbairro_fk = @codbairro , codcep_fk = @codcep , codcidade_fk = @codcidade , salario = @codsalario," +
                        "codtrabalho_fk = @codtrabalho , numerocasa = @numerocasa where codcliente = @codcliente;";

                    cmd.Parameters.AddWithValue("@nomecliente", clienteEntidade.NomeCliente);
                    cmd.Parameters.AddWithValue("@foto", clienteEntidade.Foto);
                    cmd.Parameters.AddWithValue("@datanasc", clienteEntidade.Datanasc);
                    cmd.Parameters.AddWithValue("@codsex", clienteEntidade.CodSexo);
                    cmd.Parameters.AddWithValue("@codrua", clienteEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", clienteEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcep", clienteEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@codcidade", clienteEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@salario", clienteEntidade.Salario);
                    cmd.Parameters.AddWithValue("@codtrabalho", clienteEntidade.CodTrabalho);
                    cmd.Parameters.AddWithValue("@numerocasa", clienteEntidade.NumeroCasa);
                    cmd.Parameters.AddWithValue("@codcliente", clienteEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex) {  MessageBox.Show(ex.Message); }
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
                    cmd.CommandText = "delete from cliente where codcliente = @codcliente;";

                    cmd.Parameters.AddWithValue("@codcliente", id);

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

        public List<ClienteEntidade> BuscarTodosCliente()
        {
            List<ClienteEntidade> listClienteEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cliente;";

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listClienteEntidade.Add(new ClienteEntidade()
                            {
                                Id = (int)reader["codcliente"],
                                NomeCliente = (string)reader["nomecliente"],
                                Foto = (byte[])reader["foto"],
                                Datanasc = (DateTime)reader["datanasc"],
                                CodBairro = (int)reader["codbairro_fk"],
                                CodCep = (int)reader["codcep_fk"],
                                CodCidade = (int)reader["codcidade_fk"],
                                CodRua = (int)reader["codrua_fk"],
                                CodSexo = (int)reader["codsexo_fk"],
                                CodTrabalho = (int)reader["codtrabalho_fk"],
                                NumeroCasa = (string)reader["numerocasa"],
                                Salario = (double)reader["salario"]
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

            return listClienteEntidade;
        }

        public ClienteEntidade BuscarClientePorId(int id)
        {
            ClienteEntidade clienteEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select * from cliente where codcliente = @codcliente;";

                    cmd.Parameters.AddWithValue("@codcliente", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        clienteEntidade = new ClienteEntidade()
                        {
                            Id = (int)reader["codcliente"],
                            NomeCliente = (string)reader["nomecliente"],
                            Foto = (byte[])reader["foto"],
                            Datanasc = (DateTime)reader["datanasc"],
                            CodBairro = (int)reader["codbairro_fk"],
                            CodCep = (int)reader["codcep_fk"],
                            CodCidade = (int)reader["codcidade_fk"],
                            CodRua = (int)reader["codrua_fk"],
                            CodSexo = (int)reader["codsexo_fk"],
                            CodTrabalho = (int)reader["codtrabalho_fk"],
                            NumeroCasa = (string)reader["numerocasa"],
                            Salario = (double)reader["salario"]
                        };

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }

            return clienteEntidade;

        }
    }
}
