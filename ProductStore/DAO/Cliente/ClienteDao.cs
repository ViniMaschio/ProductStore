﻿using ProductStore.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Cliente
{
    public class ClienteDao : ConfiguraBD
    {
        public ClienteDao() { }

        public void Add(ClienteEntidade clienteEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into cliente(nomecliente,foto,datanasc,codsexo_fk,codrua_fk,codbairro_fk,codcep_fk,codcidade_fk,salario,codtrabalho_fk,numerocasa)" +
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
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public void Update(ClienteEntidade clienteEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update cliente set nomecliente = upper(@nomecliente), foto = @foto, datanasc = @datanasc , codsexo_fk = @codsex," +
                        "codrua_fk = @codrua, codbairro_fk = @codbairro , codcep_fk = @codcep , codcidade_fk = @codcidade , salario = @salario," +
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
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            List<ClienteEntidade> listClienteEntidade = new List<ClienteEntidade>();

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
                                NomeCliente = reader["nomecliente"].ToString(),
                                Datanasc = (DateTime)reader["datanasc"],
                                CodBairro = (int)reader["codbairro_fk"],
                                CodCep = (int)reader["codcep_fk"],
                                CodCidade = (int)reader["codcidade_fk"],
                                CodRua = (int)reader["codrua_fk"],
                                CodSexo = (int)reader["codsexo_fk"],
                                CodTrabalho = (int)reader["codtrabalho_fk"],
                                NumeroCasa = reader["numerocasa"].ToString(),
                                Salario = double.Parse(reader["salario"].ToString())
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro DAO");
                    }
                }

                conn.Close();
            }

            return listClienteEntidade;
        }

        public ClienteEntidade BuscarClientePorId(int id)
        {
            ClienteEntidade clienteEntidade = new ClienteEntidade();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from cliente where codcliente = @codcliente;";

                    cmd.Parameters.AddWithValue("@codcliente", id);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        clienteEntidade = new ClienteEntidade()
                        {
                            Foto = (byte[])reader["foto"],
                            Id = (int)reader["codcliente"],
                            NomeCliente = reader["nomecliente"].ToString(),
                            Datanasc = (DateTime)reader["datanasc"],
                            CodBairro = (int)reader["codbairro_fk"],
                            CodCep = (int)reader["codcep_fk"],
                            CodCidade = (int)reader["codcidade_fk"],
                            CodRua = (int)reader["codrua_fk"],
                            CodSexo = (int)reader["codsexo_fk"],
                            CodTrabalho = (int)reader["codtrabalho_fk"],
                            NumeroCasa = reader["numerocasa"].ToString(),
                            Salario = double.Parse(reader["salario"].ToString())
                        };

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Buscar Por ID"); }
                }

                conn.Close();

            }

            return clienteEntidade;

        }
    }
}
