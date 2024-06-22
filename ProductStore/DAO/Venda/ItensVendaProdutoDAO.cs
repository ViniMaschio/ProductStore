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

                for (int i = 0; i < listItensVendaProdutoEntidade.Count; i++)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "insert into itensvendaproduto(codvenda_fk,codproduto_fk,quantidade,valor)" +
                            "values(@codvenda,@codproduto,@quantidade,@valor);" +
                            "update produto set quantidade = (quantidade - @quantidade) where codproduto = @codproduto;";

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

            List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade = new List<ItensVendaProdutoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "select * from itensvendaproduto where codvenda_fk = @codvenda;";
                    cmd.Parameters.AddWithValue("@codvenda", codVenda);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensVendaProdutoEntidade.Add(new ItensVendaProdutoEntidade()
                        {
                            CodVenda = int.Parse(reader["codvenda_fk"].ToString()),
                            CodProduto = int.Parse(reader["codproduto_fk"].ToString()),
                            Quantidade = double.Parse(reader["quantidade"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString())
                        });
                    }
                }
                conn.Close();
            }

            return listItensVendaProdutoEntidade;
        }

        public double BuscarTotalVenda(int codVenda)
        {
            double valorTotal = 0;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select sum(quantidade * valor ) as total , COUNT(codproduto_fk) as quantidade from itensvendaproduto where codvenda_fk = @codvenda;";
                    cmd.Parameters.AddWithValue("@codvenda", codVenda);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if ((int)reader["quantidade"] > 0)
                        {
                            valorTotal = double.Parse(reader["total"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return valorTotal;
        }
    }
}
