using ProductStore.Entidades.Compra;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Compra
{
    public class FornecedorDAO : ConfiguraBD
    {


        public void Add(FornecedorEntidade fornecedorEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into fornecedor(nomefornecedor,numerocasa,codrua_fk,cobairro_fk,cocep_fk,codcidade_fk) values(upper(@nomefornecedor),@numerocasa," +
                        "@codrua, @codbairro, @codcep,@codcidade);";
                    cmd.Parameters.AddWithValue("@nomefornecedor", fornecedorEntidade.NomeFornecedor);
                    cmd.Parameters.AddWithValue("@numerocasa", fornecedorEntidade.NumeroCasa);
                    cmd.Parameters.AddWithValue("@codrua", fornecedorEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", fornecedorEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcep", fornecedorEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@codcidade", fornecedorEntidade.CodCidade);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Alterar(FornecedorEntidade fornecedorEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update fornecedor set nomefornecedor = upper(@nomefornecedor),numerocasa = @numerocasa,codrua_fk = @codrua ,cobairro_fk = @codbairro," +
                        "cocep_fk = @codcep,codciddade = @codcidade where codfornecedor = @codfornecedor;";

                    cmd.Parameters.AddWithValue("@nomefornecedor", fornecedorEntidade.NomeFornecedor);
                    cmd.Parameters.AddWithValue("@numerocasa", fornecedorEntidade.NumeroCasa);
                    cmd.Parameters.AddWithValue("@codrua", fornecedorEntidade.CodRua);
                    cmd.Parameters.AddWithValue("@codbairro", fornecedorEntidade.CodBairro);
                    cmd.Parameters.AddWithValue("@codcep", fornecedorEntidade.CodCep);
                    cmd.Parameters.AddWithValue("@codcidade", fornecedorEntidade.CodCidade);
                    cmd.Parameters.AddWithValue("@codfornecedor", fornecedorEntidade.Id);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Deletar(int codFornecedor)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from fornecedor where codfornecedor = @codfornecedor;";

                    cmd.Parameters.AddWithValue("@nomefornecedor", codFornecedor);


                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public List<FornecedorEntidade> BuscarTodosFornecedor()
        {

            List<FornecedorEntidade> listFornecedorEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from fornecedor;";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listFornecedorEntidade.Add(new FornecedorEntidade()
                        {
                            Id = (int)reader["codfornecedor"],
                            NomeFornecedor = (string)reader["nomefornecedor"],
                            NumeroCasa = (string)reader["numerocasa"],
                            CodBairro = (int)reader["codbairro_fk"],
                            CodCep = (int)reader["codcep_fk"],
                            CodCidade = (int)reader["codcidade_fk"],
                            CodRua = (int)reader["codrua_fk"]
                        });
                    }
                }

                conn.Close();
            }

            return listFornecedorEntidade;
        }

        public FornecedorEntidade BuscarFornecedorPorID(int codFornecedor)
        {

            FornecedorEntidade fornecedorEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from fornecedor where codfornecedor = @codfornecedor;";
                    cmd.Parameters.AddWithValue("@codfornecedor", codFornecedor);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fornecedorEntidade = new FornecedorEntidade()
                        {
                            Id = (int)reader["codfornecedor"],
                            NomeFornecedor = (string)reader["nomefornecedor"],
                            NumeroCasa = (string)reader["numerocasa"],
                            CodBairro = (int)reader["codbairro_fk"],
                            CodCep = (int)reader["codcep_fk"],
                            CodCidade = (int)reader["codcidade_fk"],
                            CodRua = (int)reader["codrua_fk"]
                        };
                    }
                }

                conn.Close();
            }

            return fornecedorEntidade;
        }
    }
}
