using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Boletos
{
    public class ParcelaCompraDAO : ConfiguraBD
    {
        public ParcelaCompraDAO() { }

        public void Add(List<ParcelaCompraEntidade> parcelaCompraEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into parcelacompra(codparcelacompra,datavencimento,valor,codsituacao_fk,codcompra_fk) " +
                        "values(@codparcelacompra,@datavencimento,@valor,@codsituacao,@codcompra);";

                    for (int i = 0; i < parcelaCompraEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codparcelacompra", parcelaCompraEntidade[i].CodParcela);
                        cmd.Parameters.AddWithValue("@datavencimento", parcelaCompraEntidade[i].Date.ToString("dd:MM:yyyy"));
                        cmd.Parameters.AddWithValue("@valor", parcelaCompraEntidade[i].Valor);
                        cmd.Parameters.AddWithValue("@codsituacao", parcelaCompraEntidade[i].CodSituacao);
                        cmd.Parameters.AddWithValue("@codcompra", parcelaCompraEntidade[i].CodCompra);

                        cmd.ExecuteNonQuery();
                    }
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
                    cmd.CommandText = "delete from parcelacompra where codcompra_fk = @codcompra;";
                    cmd.Parameters.AddWithValue("@codcompra", codCompra);

                    cmd.ExecuteNonQuery();

                }

                conn.Close();
            }
        }

        public List<ParcelaCompraEntidade> BuscarParcelaEmAberto()
        {
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelacompra where codsituacao_fk = 1";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaCompraEntidade.Add(new ParcelaCompraEntidade()
                        {
                            CodCompra = (int)reader["codcompra_fk"],
                            CodParcela = (int)reader["codparcelacompra"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            Date = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaCompraEntidade;
        }

        public List<ParcelaCompraEntidade> BuscarParcelaPagas()
        {
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelacompra where codsituacao_fk = 2";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaCompraEntidade.Add(new ParcelaCompraEntidade()
                        {
                            CodCompra = (int)reader["codcompra_fk"],
                            CodParcela = (int)reader["codparcelacompra"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            Date = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaCompraEntidade;
        }

        public List<ParcelaCompraEntidade> BuscarTodasParcelas()
        {
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelacompra";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaCompraEntidade.Add(new ParcelaCompraEntidade()
                        {
                            CodCompra = (int)reader["codcompra_fk"],
                            CodParcela = (int)reader["codparcelacompra"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            Date = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaCompraEntidade;
        }

        public void Pagar(ParcelaCompraEntidade parcelaCompraEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update parcelacompra set codsituacao_fk = 2 where codcompra_fk = @codcompra and codparcelacompra = @codparcela;";
                    cmd.Parameters.AddWithValue("@codcompra", parcelaCompraEntidade.CodCompra);
                    cmd.Parameters.AddWithValue("@codparcela", parcelaCompraEntidade.CodParcela);

                    cmd.ExecuteNonQuery();

                }

                conn.Close();
            }
        }

    }
}
