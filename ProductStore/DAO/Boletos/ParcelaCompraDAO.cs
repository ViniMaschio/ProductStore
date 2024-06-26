﻿using ProductStore.Entidades.Boletos;
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

                for (int i = 0; i < parcelaCompraEntidade.Count; i++)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "insert into parcelacompra(datavencimento,valor,codsituacao_fk,codcompra_fk,codparcelacompra) " +
                        "values(@datavencimento,@valor,@codsituacao,@codcompra,@codparcelacompra);";

                        cmd.Parameters.AddWithValue("@codparcelacompra", parcelaCompraEntidade[i].CodParcela);
                        cmd.Parameters.AddWithValue("@datavencimento", parcelaCompraEntidade[i].Date);
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
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = new List<ParcelaCompraEntidade>();

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
                            CodCompra = int.Parse(reader["codcompra_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcelacompra"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            Date = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString()),
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaCompraEntidade;
        }

        public List<ParcelaCompraEntidade> BuscarParcelaPagas()
        {
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = new List<ParcelaCompraEntidade>();

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
                            CodCompra = int.Parse(reader["codcompra_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcelacompra"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            Date = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString()),
                        });
                    }
                }

                conn.Close();
            }

            return listParcelaCompraEntidade;
        }

        public List<ParcelaCompraEntidade> BuscarTodasParcelas()
        {
            List<ParcelaCompraEntidade> listParcelaCompraEntidade = new List<ParcelaCompraEntidade>();

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
                            CodCompra = int.Parse(reader["codcompra_fk"].ToString()),
                            CodParcela = int.Parse(reader["codparcelacompra"].ToString()),
                            CodSituacao = int.Parse(reader["codsituacao_fk"].ToString()),
                            Date = DateTime.Parse(reader["datavencimento"].ToString()),
                            Valor = double.Parse(reader["valor"].ToString()),
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
