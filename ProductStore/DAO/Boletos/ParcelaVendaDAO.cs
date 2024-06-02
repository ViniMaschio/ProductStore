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

                for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "insert into parcelavenda(codparcela,datavencimento,valor,codsituacao_fk,codvenda_fk) " +
                            "values(@codparcela,@datavencimento,@valor,@codsituacao,@codvenda);";

                        cmd.Parameters.AddWithValue("@codparcela", listParcelaVendaEntidade[i].CodParcela);
                        cmd.Parameters.AddWithValue("@datavencimento", listParcelaVendaEntidade[i].DataVencimento);
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

        public void Pagar(ParcelaVendaEntidade parcelaVendaEntidade)
        {
            using(SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update parcelavenda set codsituacao_fk = 2 where codparcela = @codparcela and codvenda_fk = @codvenda; ";
                    cmd.Parameters.AddWithValue("@codparcela",parcelaVendaEntidade.CodParcela);
                    cmd.Parameters.AddWithValue("@codvenda",parcelaVendaEntidade.CodVenda);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<ParcelaVendaEntidade> BuscarParcelaEmAberto()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = new List<ParcelaVendaEntidade>();

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
                            CodVenda = int.Parse(reader["codvenda_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcela"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            DataVencimento = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString())
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }

        public List<ParcelaVendaEntidade> BuscarParcelaPago()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = new List<ParcelaVendaEntidade>();

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
                            CodVenda = int.Parse(reader["codvenda_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcela"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            DataVencimento = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString())
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }

        public List<ParcelaVendaEntidade> BuscarTodasParcelas()
        {
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = new List<ParcelaVendaEntidade>();

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
                            CodVenda = int.Parse(reader["codvenda_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcela"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            DataVencimento = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString())
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaVendaEntidade;
        }
    }
}
