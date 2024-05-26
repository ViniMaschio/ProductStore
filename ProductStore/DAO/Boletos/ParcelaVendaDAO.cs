using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProductStore.DAO.Boletos
{
    public class ParcelaVendaDAO : ConfiguraBD
    {
        public ParcelaVendaDAO() { }

        public void Add(List<ParcelaVendaEntidade> listParcelaVendaEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into parcelavenda(codparcela,datavencimento,valor,codsituacao_fk,codvenda_fk) " +
                        "values(@codparcela,@datavencimento,@valor,@codsituacao,@codvenda);";

                    for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codparcela", listParcelaVendaEntidade[i].CodParcela);
                        cmd.Parameters.AddWithValue("@datavencimento", listParcelaVendaEntidade[i].DataVencimento.ToString("dd:MM:yyyy"));
                        cmd.Parameters.AddWithValue("@valor", listParcelaVendaEntidade[i].Valor);
                        cmd.Parameters.AddWithValue("@codsituacao", listParcelaVendaEntidade[i].CodSituacao);
                        cmd.Parameters.AddWithValue("@codvenda", listParcelaVendaEntidade[i].CodVenda);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }

        public void Deletar(int codVenda)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from parcelavenda where codvenda_fk = @codvenda;";
                    cmd.Parameters.AddWithValue("@codvenda", codVenda);

                    cmd.ExecuteNonQuery();

                }

                conn.Close();
            }
        }

        public List<ParcelaVendaEntidade> BuscarParcelaEmAberto()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelavenda where codsituacao_fk = 1";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaVendaEntidade.Add(new ParcelaVendaEntidade()
                        {
                            CodVenda = (int)reader["codvenda_fk"],
                            CodParcela = (int)reader["codparcela"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            DataVencimento = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }

        public List<ParcelaVendaEntidade> BuscarParcelaPago()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelavenda where codsituacao_fk = 2";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaVendaEntidade.Add(new ParcelaVendaEntidade()
                        {
                            CodVenda = (int)reader["codvenda_fk"],
                            CodParcela = (int)reader["codparcela"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            DataVencimento = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }

        public List<ParcelaVendaEntidade> BuscarTodasParcelas()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from parcelavenda;";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listParcelaVendaEntidade.Add(new ParcelaVendaEntidade()
                        {
                            CodVenda = (int)reader["codvenda_fk"],
                            CodParcela = (int)reader["codparcela"],
                            CodSituacao = (int)reader["codsituacao_fk"],
                            DataVencimento = (DateTime)reader["datavencimento"],
                            Valor = (double)reader["valor"]
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }
    }
}
