using ProductStore.Entidades.Venda;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Venda
{
    public class ItensVendaProdutoDAO : ConfiguraBD
    {
        public ItensVendaProdutoDAO() { }

        public void Add(List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "insert into itensvendaproduto(codvenda_fk,codproduto_fk,quantidade,valor)" +
                        "values(@codvenda,@codprodtuto,@quantidade,@valor);" +
                        "update produto set quantidade = (quantidade - @quantidade) where codproduto = @codproduto;";

                    for (int i = 0; i < listItensVendaProdutoEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codproduto", listItensVendaProdutoEntidade[i].CodProduto);
                        cmd.Parameters.AddWithValue("@codvenda", listItensVendaProdutoEntidade[i].CodVenda);
                        cmd.Parameters.AddWithValue("@quantidade", listItensVendaProdutoEntidade[i].Quantidade);
                        cmd.Parameters.AddWithValue("@valor", listItensVendaProdutoEntidade[i].Valor);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public void Deletar(List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "delete from itensvendaproduto where codvenda_fk = @codvenda and codproduto_fk = @codproduto; " +
                        "update produto set quantidade = (quantidade + @quantidade) where codproduto = @codproduto;";

                    for (int i = 0; i < listItensVendaProdutoEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codproduto", listItensVendaProdutoEntidade[i].CodProduto);
                        cmd.Parameters.AddWithValue("@codvenda", listItensVendaProdutoEntidade[i].CodVenda);
                        cmd.Parameters.AddWithValue("@quantidade", listItensVendaProdutoEntidade[i].Quantidade);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public List<ItensVendaProdutoEntidade> BuscarTodosProdutoPorVenda(int codVenda)
        {

            List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select * from itensvendaproduto where codvenda_fk = @codvenda;";
                    cmd.Parameters.AddWithValue("@covenda", codVenda);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensVendaProdutoEntidade.Add(new ItensVendaProdutoEntidade()
                        {
                            CodVenda = (int)reader["codvenda_fk"],
                            CodProduto = (int)reader["codproduto_fk"],
                            Quantidade = (double)reader["quantidade"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }
                conn.Close();
            }

            return listItensVendaProdutoEntidade;
        }
    }
}
