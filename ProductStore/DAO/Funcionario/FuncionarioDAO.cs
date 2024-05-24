using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.DAO.Funcionario
{
    public class FuncionarioDAO : ConfiguraBD
    {

        public FuncionarioDAO() { }

        public void Add(FuncionarioEntidade funcionarioEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into funcionario(nomefuncionario,numerocasa,codrua_fk,codbairro_fk,codcep_fk,codcidade_fk,codfuncao_fk,salario,codloja_fk) " +
                        "values(upper(@nomefuncionario),@numerocasa,@codrua,@codbairro,@codcep,@codcidade,@codfuncao,@salario,@codloja);";
                    cmd.Parameters.AddWithValue("@nomefuncionario", funcionarioEntidade.NomeFuncionario);
                    cmd.Parameters.AddWithValue("@numerocasa", funcionarioEntidade.NumeroCasa);
                    cmd.Parameters.AddWithValue("@codrua", funcionarioEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", funcionarioEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcidade", funcionarioEntidade.CodCidade);
                    cmd.Parameters.AddWithValue("@codfuncao", funcionarioEntidade.CodFuncao);
                    cmd.Parameters.AddWithValue("@salario", funcionarioEntidade.Salario);
                    cmd.Parameters.AddWithValue("@codloja", funcionarioEntidade.CodLoja);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }
        }

        public void Alterar(FuncionarioEntidade funcionarioEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update funcionario set nomefuncionario = @numerofuncionario, numerocasa = @numerocasa ,codrua_fk = @codrua,codbairro_fk = @codbairro, " +
                        "codcep_fk = @codcep ,codcidade_fk = @codcidade ,codfuncao_fk = @codfuncao ,salario = @salario ,codloja_fk = @codloja where codfuncionario = @codfuncionario;";
                        
                    cmd.Parameters.AddWithValue("@nomefuncionario", funcionarioEntidade.NomeFuncionario);
                    cmd.Parameters.AddWithValue("@numerocasa", funcionarioEntidade.NumeroCasa);
                    cmd.Parameters.AddWithValue("@codrua", funcionarioEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", funcionarioEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcidade", funcionarioEntidade.CodCidade);
                    cmd.Parameters.AddWithValue("@codfuncao", funcionarioEntidade.CodFuncao);
                    cmd.Parameters.AddWithValue("@salario", funcionarioEntidade.Salario);
                    cmd.Parameters.AddWithValue("@codloja", funcionarioEntidade.CodLoja);
                    cmd.Parameters.AddWithValue("@codfuncionario", funcionarioEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                    cmd.CommandText = "delete from funcionario where codfuncionario = @codfuncionario;";

                    
                    cmd.Parameters.AddWithValue("@codfuncionario", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }

        }

        public List<FuncionarioEntidade> BuscarTodosFuncionarios()
        {

            List < FuncionarioEntidade > listFuncionarioEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from funcionario;";

                    

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            listFuncionarioEntidade.Add(new FuncionarioEntidade()
                            {
                                Id = (int)reader["codfuncionario"],
                                NomeFuncionario = (string)reader["nomefuncionario"],
                                NumeroCasa = (string)reader["numerocasa"],
                                CodRua = (int)reader["codrua_fk"],
                                CodBairro = (int)reader["codbairro_fk"],
                                CodCep = (int)reader["codcep_fk"],
                                CodCidade = (int)reader["codcidade_fk"],
                                CodFuncao = (int)reader["codfuncao_fk"],
                                CodLoja = (int)reader["codloja_fk"],
                                Salario = (double)reader["salario"]
                            });
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }

            return listFuncionarioEntidade;
        }

        public FuncionarioEntidade BuscarFuncionarioPorId(int id)
        {
            FuncionarioEntidade funcionarioEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from funcionario where codfuncionario = @codfuncionario;";
                    cmd.Parameters.AddWithValue("@codfuncionario",id);



                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            funcionarioEntidade = new FuncionarioEntidade()
                            {
                                Id = (int)reader["codfuncionario"],
                                NomeFuncionario = (string)reader["nomefuncionario"],
                                NumeroCasa = (string)reader["numerocasa"],
                                CodRua = (int)reader["codrua_fk"],
                                CodBairro = (int)reader["codbairro_fk"],
                                CodCep = (int)reader["codcep_fk"],
                                CodCidade = (int)reader["codcidade_fk"],
                                CodFuncao = (int)reader["codfuncao_fk"],
                                CodLoja = (int)reader["codloja_fk"],
                                Salario = (double)reader["salario"]
                            };
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                conn.Close();

            }

            return funcionarioEntidade;
        }
    }
}
