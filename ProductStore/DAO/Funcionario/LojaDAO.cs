using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Funcionario
{
    public class LojaDAO : ConfiguraBD
    {
        public LojaDAO() { }

        public void Add(LojaEntidade lojaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into loja(nomeloja,cnpj,nomefantasia,razaosocial) values(upper(@nomeloja),@cnpj,upper(@nomefantasia),upper(@razaosocial));";
                    cmd.Parameters.AddWithValue("@nomeloja", lojaEntidade.NomeLoja);
                    cmd.Parameters.AddWithValue("@cnpj", lojaEntidade.Cnpj);
                    cmd.Parameters.AddWithValue("@nomefantasia", lojaEntidade.NomeFantasia);
                    cmd.Parameters.AddWithValue("@razaosocial", lojaEntidade.RazaoSocial);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                conn.Close();

            }
        }

        public void Alterar(LojaEntidade lojaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update loja set nomeloja = upper(@nomeloja) ,cnpj = @cnpj ,nomefantasia = upper(@nomefantasia),razaosocial = upper(@razaosocial) where codloja = @codloja;";
                    cmd.Parameters.AddWithValue("@nomeloja", lojaEntidade.NomeLoja);
                    cmd.Parameters.AddWithValue("@cnpj", lojaEntidade.Cnpj);
                    cmd.Parameters.AddWithValue("@nomefantasia", lojaEntidade.NomeFantasia);
                    cmd.Parameters.AddWithValue("@razaosocial", lojaEntidade.RazaoSocial);
                    cmd.Parameters.AddWithValue("@codloja", lojaEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                conn.Close();
            }


        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from loja where codloja = @codloja;";

                    cmd.Parameters.AddWithValue("@codloja", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                conn.Close();

            }
        }

        public List<LojaEntidade> BuscarTodasLojas()
        {
            List<LojaEntidade> listLojaEntidade = new List<LojaEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from loja;";


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listLojaEntidade.Add(new LojaEntidade()
                            {
                                Id = (int)reader["codloja"],
                                NomeLoja = (string)reader["nomeloja"],
                                Cnpj = (string)reader["cnpj"],
                                NomeFantasia = (string)reader["nomefantasia"],
                                RazaoSocial = (string)reader["razaosocial"]
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                conn.Close();

            }

            return listLojaEntidade;
        }

        public LojaEntidade BuscarLojaPorId(int id)
        {

            LojaEntidade LojaEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from loja;";


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LojaEntidade = new LojaEntidade()
                            {
                                Id = (int)reader["codloja"],
                                NomeLoja = (string)reader["nomeloja"],
                                Cnpj = (string)reader["cnpj"],
                                NomeFantasia = (string)reader["nomefantasia"],
                                RazaoSocial = (string)reader["razaosocial"]
                            };
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                conn.Close();

            }

            return LojaEntidade;
        }

    }
}
