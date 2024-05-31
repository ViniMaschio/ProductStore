using ProductStore.Entidades.Telefone;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Telefone
{
    public class ItensTelefoneFornecedorDAO : ConfiguraBD
    {

        public ItensTelefoneFornecedorDAO() { }

        public void Add(ItensTelefoneFornecedorEntidade itensTelefoneFornecedor)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into itenstelefonefornecedor(codfornecedor_fk,codtelefone_fk) values (@codfornecedor,@codtelefone);";
                    cmd.Parameters.AddWithValue("@codfornecedor", itensTelefoneFornecedor.CodFornecedor);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFornecedor.CodTelefone);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void Delete(ItensTelefoneFornecedorEntidade itensTelefoneFornecedor)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from itenstelefonefornecedor where codfornecedor_fk = @codfornecedor and  codtelefone_fk = @codtelefone;";
                    cmd.Parameters.AddWithValue("@codfornecedor", itensTelefoneFornecedor.CodFornecedor);
                    cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFornecedor.CodTelefone);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public List<ItensTelefoneFornecedorEntidade> BuscarTodosTelefonePorFornecedor(int codFornecedor)
        {

            List<ItensTelefoneFornecedorEntidade> listItensTelefoneFornecedorEntidade = new List<ItensTelefoneFornecedorEntidade>();

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select *  from itenstelefonefornecedor where codfornecedor_fk = @codfornecedor;";
                    cmd.Parameters.AddWithValue("@codfornecedor", codFornecedor);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listItensTelefoneFornecedorEntidade.Add(new ItensTelefoneFornecedorEntidade()
                        {
                            CodFornecedor = (int)reader["codfornecedor_fk"],
                            CodTelefone = (int)reader["codtelefone_fk"]
                        });
                    }

                }

                conn.Close();
            }
            return listItensTelefoneFornecedorEntidade;
        }
    }
}
