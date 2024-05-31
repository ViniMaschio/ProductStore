using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Funcionario
{
    public class FuncaoDAO : ConfiguraBD
    {
        public FuncaoDAO() { }

        public void Add(FuncaoEntidade funcaoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into funcao(nomefuncao) values (upper(@nomefuncao));";
                    cmd.Parameters.AddWithValue("@nomefuncao", funcaoEntidade.NomeFuncao);


                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }
        }

        public void Alterar(FuncaoEntidade funcaoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update funcao set nomefuncao = upper(@nomefuncao) where codfuncao = @codfuncao;";
                    cmd.Parameters.AddWithValue("@nomefuncao", funcaoEntidade.NomeFuncao);
                    cmd.Parameters.AddWithValue("@codfuncao", funcaoEntidade.Id);


                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from funcao where codfuncao = @codfuncao;";
                    cmd.Parameters.AddWithValue("@codfuncao", Id);


                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }
        }

        public List<FuncaoEntidade> BuscarTodasFuncao()
        {
            List<FuncaoEntidade> listFuncaoEntidade = new List<FuncaoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from funcao;";


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listFuncaoEntidade.Add(new FuncaoEntidade()
                            {
                                Id = (int)reader["codfuncao"],
                                NomeFuncao = (string)reader["nomefuncao"]
                            });
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();
            }

            return listFuncaoEntidade;
        }

        public FuncaoEntidade BuscarFuncaoPorId(int id)
        {
            FuncaoEntidade funcaoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from funcao where codfuncao = @codfuncao;";
                    cmd.Parameters.AddWithValue("@codfuncao", id);


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();

                        funcaoEntidade = new FuncaoEntidade()
                        {
                            Id = (int)reader["codfuncao"],
                            NomeFuncao = (string)reader["nomefuncao"]
                        };
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message,"Funcao DAO"); }
                }

                conn.Close();
            }

            return funcaoEntidade;
        }
    }
}
