using ProductStore.DAO.Boletos;
using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Boletos
{
    public class ParcelaVendaControler
    {
        public ParcelaVendaControler() { }

        public void AddParcela(List<ParcelaVendaEntidade> listParcelaVendaEntidade)
        {
            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            parcelaVendaDAO.Add(listParcelaVendaEntidade);
        }

        public void RemoverParcela(int codVenda)
        {
            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            parcelaVendaDAO.Deletar(codVenda);
        }

        public void Pagar(ParcelaVendaEntidade parcelaVendaEntidade)
        {
            ParcelaVendaDAO parcelaVendaDAO=new ParcelaVendaDAO();
            parcelaVendaDAO.Pagar(parcelaVendaEntidade);
        }

        public DataTable BuscarTodasParcelas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Venda", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarTodasParcelas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].CodVenda,
                    listParcelaVendaEntidade[i].DataVencimento,
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

        public DataTable BuscarParcelasEmAberto()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Venda", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarParcelaEmAberto();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].CodVenda,
                    listParcelaVendaEntidade[i].DataVencimento,
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

        public DataTable BuscarParcelasPagas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Venda", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarParcelaPago();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].CodVenda,
                    listParcelaVendaEntidade[i].DataVencimento,
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

    }
}
