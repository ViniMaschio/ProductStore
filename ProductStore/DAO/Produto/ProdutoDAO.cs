using ProductStore.Entidades.Produto;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductStore.DAO.Produto
{
    public class ProdutoDAO : ConfiguraBD
    {
        public ProdutoDAO() { }

        public void AddProduto(ProdutoEntidade produtoEntidade)
        {

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into produto(nomeproduto,quantidade,valor,codmarca_fk,codtipo_fk) " +
                        "values(upper(@nomeproduto), @quantidade, @valor, @codmarca,@codtipo);";

                    cmd.Parameters.AddWithValue("@nomeproduto", produtoEntidade.Nomeproduto);
                    cmd.Parameters.AddWithValue("@quantidade", produtoEntidade.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", produtoEntidade.Valor);
                    cmd.Parameters.AddWithValue("@codmarca", produtoEntidade.Codigomarca);
                    cmd.Parameters.AddWithValue("@codtipo", produtoEntidade.Codigotipo);
                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro add produto");
                    }

                }
                conn.Close();
            }

        }

        public void AlterarProduto(ProdutoEntidade produtoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update produto set nomeproduto = upper('@nomeproduto'), quantidade = @quantidade, valor = @valor , codmarca_fk = @codmarca, codtipo_fk = @codtipo where codproduto = @codproduto";
                    cmd.Parameters.AddWithValue("nomeproduto", produtoEntidade.Nomeproduto);
                    cmd.Parameters.AddWithValue("@quantidade", produtoEntidade.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", produtoEntidade.Valor);
                    cmd.Parameters.AddWithValue("codmarca", produtoEntidade.Codigomarca);
                    cmd.Parameters.AddWithValue("codtipo", produtoEntidade.Codigotipo);
                    cmd.Parameters.AddWithValue("codproduto", produtoEntidade.Id);

                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Alterar produto");
                    }
                }



                conn.Close();
            }
        }

        public void RemoverProduto(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from produto where codproduto = @codproduto ";
                    cmd.Parameters.AddWithValue("@codproduto", id);
                    try { cmd.ExecuteNonQuery(); }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Remover produto");
                    }
                }
                conn.Close();

            }
        }

        public List<ProdutoEntidade> BuscarTodosProdutos()
        {
            List<ProdutoEntidade> produtoList = new List<ProdutoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from produto;";

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            produtoList.Add(new ProdutoEntidade()
                            {
                                Id = (int)reader["codproduto"],
                                Nomeproduto = reader["nomeproduto"].ToString(),
                                Quantidade = double.Parse(reader["quantidade"].ToString()),
                                Valor = double.Parse(reader["valor"].ToString()),
                                Codigomarca = (int)reader["codmarca_fk"],
                                Codigotipo = (int)reader["codtipo_fk"]
                            });
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Buscar produto");
                    }
                }

                conn.Close();
            }
            return produtoList;

        }

        public List<ProdutoEntidade> BuscarIdNameTodos()
        {
            List<ProdutoEntidade> produtoList = new List<ProdutoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select codproduto, nomeproduto from produto;";

                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            produtoList.Add(new ProdutoEntidade()
                            {
                                Id = (int)reader["codproduto"],
                                Nomeproduto = reader["nomeproduto"].ToString(),

                            });
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Buscar produto");
                    }

                }

                conn.Close();
            }

            return produtoList;

        }

        public ProdutoEntidade BuscarProdutoPorId(int id)
        {
            ProdutoEntidade produtoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from produto where codproduto = @codproduto;";
                    cmd.Parameters.AddWithValue("@codproduto", id);
                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        produtoEntidade = new ProdutoEntidade()
                        {
                            Id = (int)reader["codproduto"],
                            Nomeproduto = reader["nomeproduto"].ToString(),
                            Quantidade = double.Parse(reader["quantidade"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString()),
                            Codigomarca = (int)reader["codmarca_fk"],
                            Codigotipo = (int)reader["codtipo_fk"]
                        };
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro Buscar produto por ID");
                    }
                }

                conn.Close();

            }
            return produtoEntidade;
        }

    }
}
