using ProductStore.Entidades.Compra;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Compra
{
    public class ItensCompraProdutoDAO : ConfiguraBD
    {
        public ItensCompraProdutoDAO() { }

        public void Add(List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "insert into itenscompraproduto(codcompra_fk,codproduto_fk,quantidade,valorc)" +
                        "values(@codcompra,@codprodtuto,@quantidade,@valorc);" +
                        "update produto set quantidade = (quantidade + @quantidade), valor = @valorc where codproduto = @codproduto;";

                    for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codproduto", listItensCompraProdutoEntidade[i].CodProduto);
                        cmd.Parameters.AddWithValue("@codcompra", listItensCompraProdutoEntidade[i].CodCompra);
                        cmd.Parameters.AddWithValue("@quantidade", listItensCompraProdutoEntidade[i].Quantidade);
                        cmd.Parameters.AddWithValue("@valorc", listItensCompraProdutoEntidade[i].Valorc);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public void Delete(List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "delete itenscompraproduto where codcompra_fk = @codcompra_fk and codproduto_fk = @codproduto; " +
                        "update produto set quantidade = (quantidade - @quantidade) where codproduto = @codproduto;";

                    for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codproduto", listItensCompraProdutoEntidade[i].CodProduto);
                        cmd.Parameters.AddWithValue("@codcompra", listItensCompraProdutoEntidade[i].CodCompra);
                        cmd.Parameters.AddWithValue("@quantidade", listItensCompraProdutoEntidade[i].Quantidade);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public List<ItensCompraProdutoEntidade> BuscarTodosProdutoPorCompra(int codCompra)
        {
            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select * from itenscompraproduto where codcompra_fk = @codcompra_fk;";
                    cmd.Parameters.AddWithValue("@codcompra", codCompra);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensCompraProdutoEntidade.Add(new ItensCompraProdutoEntidade()
                        {
                            CodCompra = (int)reader["codcompra_fk"],
                            CodProduto = (int)reader["codproduto_fk"],
                            Quantidade = (double)reader["quantidade"],
                            Valorc = (double)reader["valor"]
                        });
                    }
                }
                conn.Close();
            }

            return listItensCompraProdutoEntidade;
        }
    }
}
