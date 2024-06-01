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

                for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "insert into itenscompraproduto(codcompra_fk,codproduto_fk,quantidade,valorc)" +
                        "values(@codcompra,@codproduto,@quantidade,@valorc);" +
                        "update produto set quantidade = (quantidade + @quantidade), valor = @valorc where codproduto = @codproduto;";

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

                for (int i = 0; i < listItensCompraProdutoEntidade.Count; i++)
                {
                    
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "delete from itenscompraproduto where codcompra_fk = @codcompra and codproduto_fk = @codproduto; " +
                            "update produto set quantidade = (quantidade - @quantidade) where codproduto = @codproduto;";
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
            List<ItensCompraProdutoEntidade> listItensCompraProdutoEntidade = new List<ItensCompraProdutoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select * from itenscompraproduto where codcompra_fk = @codcompra;";
                    cmd.Parameters.AddWithValue("@codcompra", codCompra);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensCompraProdutoEntidade.Add(new ItensCompraProdutoEntidade()
                        {
                            CodCompra = (int)reader["codcompra_fk"],
                            CodProduto = (int)reader["codproduto_fk"],
                            Quantidade = double.Parse(reader["quantidade"].ToString()),
                            Valorc = double.Parse(reader["valorc"].ToString())
                        });
                    }
                }
                conn.Close();
            }

            return listItensCompraProdutoEntidade;
        }

        public double BuscarTotalCompraPorId(int codCompra)
        {   
            double totalCompra = 0;
            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open ();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select sum(quantidade * valorc) as total from itenscompraproduto where codcompra_fk = @codcompra;";
                    cmd.Parameters.AddWithValue("@codcompra",codCompra);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalCompra = double.Parse(reader["total"].ToString());
                    }
                }
                conn.Close();
            }

            return totalCompra;
        }
    }
}
