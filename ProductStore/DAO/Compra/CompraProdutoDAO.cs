using ProductStore.Entidades.Compra;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Compra
{
    public class CompraProdutoDAO : ConfiguraBD
    {
        public CompraProdutoDAO() { }

        public int Add(CompraProdutoEntidade compraProduto)
        {
            int codCompra = 0;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into compraproduto(datacompra,codfornecedor_fk,codfuncionario_fk) values (@datacompra,@codfornecedor,codfuncionario) SELECT SCOPE_IDENTITY();";
                    cmd.Parameters.AddWithValue("@datacompra", compraProduto.DataCompra.ToString("dd:MM:yyyy"));
                    cmd.Parameters.AddWithValue("@codfornecedor", compraProduto.CodFornecedor);
                    cmd.Parameters.AddWithValue("@codfuncionario", compraProduto.CodFornecedor);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    codCompra = (int)reader["codcompra"];
                }

                conn.Close();
            }

            return codCompra;
        }

        public void Alterar(CompraProdutoEntidade compraProdutoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update compraproduto set datacompra = @datacompra, codfornecedor_fk = @codfornecedor, codfuncionario_fk = @codfuncionario where codcompra = @codcompra;";
                    cmd.Parameters.AddWithValue("@datacompra", compraProdutoEntidade.DataCompra.ToString("dd:MM:yyyy"));
                    cmd.Parameters.AddWithValue("@codfornecedor", compraProdutoEntidade.CodFornecedor);
                    cmd.Parameters.AddWithValue("@codfuncionario", compraProdutoEntidade.CodFuncionario);
                    cmd.Parameters.AddWithValue("@codcompra", compraProdutoEntidade.Id);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void Deletar(int codCompra)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from  compraproduto where codcompra = @codcompra;";

                    cmd.Parameters.AddWithValue("@codcompra", codCompra);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public List<CompraProdutoEntidade> BuscarTodasCompras()
        {

            List<CompraProdutoEntidade> listCompraProdutoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from compraproduto;";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCompraProdutoEntidade.Add(new CompraProdutoEntidade()
                        {
                            Id = (int)reader["codcompra"],
                            DataCompra = (DateTime)reader["datacompra"],
                            CodFornecedor = (int)reader["codfornecedor_fk"],
                            CodFuncionario = (int)reader["codfuncionario_fk"]
                        });
                    }
                }

                conn.Close();
            }

            return listCompraProdutoEntidade;
        }

        public CompraProdutoEntidade BuscarCompraPorId(int codCompra)
        {
            CompraProdutoEntidade compraProdutoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from compraproduto where codcompra = @codcompra;";
                    cmd.Parameters.AddWithValue("@codcompra",codCompra);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        compraProdutoEntidade = new CompraProdutoEntidade()
                        {
                            Id = (int)reader["codcompra"],
                            DataCompra = (DateTime)reader["datacompra"],
                            CodFornecedor = (int)reader["codfornecedor_fk"],
                            CodFuncionario = (int)reader["codfuncionario_fk"]
                        };
                    }
                }

                conn.Close();
            }

            return compraProdutoEntidade;
        }
    }
}
