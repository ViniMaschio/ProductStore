using ProductStore.Entidades.Venda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Venda
{
    public class VendaProdutoDAO : ConfiguraBD
    {
        public VendaProdutoDAO() { }

        public int Add(VendaProdutoEntidade vendaProdutoEntidade)
        {
            int codVenda = 0;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into vendaproduto(datavenda,codcliente_fk,codfuncionario_fk) values(@datavenda,@codcliente,@codfuncionario) SELECT SCOPE_IDENTITY() as codvenda;";
                    cmd.Parameters.AddWithValue("@datavenda", vendaProdutoEntidade.DataVenda);
                    cmd.Parameters.AddWithValue("@codcliente", vendaProdutoEntidade.CodCliente);
                    cmd.Parameters.AddWithValue("@codfuncionario", vendaProdutoEntidade.CodFuncionario);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        codVenda = int.Parse(reader["codvenda"].ToString());
                    }
                }
            }

            return codVenda;
        }

        public void Deletar(int codVenda)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from  vendaproduto where codvenda = @codvenda;";

                    cmd.Parameters.AddWithValue("@codvenda", codVenda);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public List<VendaProdutoEntidade> BuscarTodasVendas()
        {

            List<VendaProdutoEntidade> listVendaProdutoEntidade = new List<VendaProdutoEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from vendaproduto;";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listVendaProdutoEntidade.Add(new VendaProdutoEntidade()
                        {
                            CodCliente = (int)reader["codcliente_fk"],
                            CodFuncionario = (int)reader["codfuncionario_fk"],
                            DataVenda = (DateTime)reader["datavenda"],
                            Id = (int)reader["codvenda"]
                        });
                    }

                }

                conn.Close();

            }
            return listVendaProdutoEntidade;
        }

        public VendaProdutoEntidade BuscarVendaPorId(int codvenda)
        {

            VendaProdutoEntidade vendaProdutoEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from vendaproduto where codvenda = @codvenda;";
                    cmd.Parameters.AddWithValue("@codvenda", codvenda);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        vendaProdutoEntidade = new VendaProdutoEntidade()
                        {
                            CodCliente = (int)reader["codcliente_fk"],
                            CodFuncionario = (int)reader["codfuncionario_fk"],
                            DataVenda = (DateTime)reader["datavenda"],
                            Id = (int)reader["codvenda"]
                        };
                    }
                }
                conn.Close();

            }

            return vendaProdutoEntidade;
        }
    }
}
