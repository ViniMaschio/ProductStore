using ProductStore.DAO.Boletos;
using ProductStore.Entidades.Boletos;
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

        public DataTable BuscarTodasParcelas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Venda");

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarTodasParcelas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].DataVencimento.ToString("dd:MM:yyyu"),
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaVendaEntidade[i].CodVenda);
            }

            return dataTable;
        }

        public DataTable BuscarParcelasEmAberto()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Venda");

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarParcelaEmAberto();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].DataVencimento.ToString("dd:MM:yyyu"),
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaVendaEntidade[i].CodVenda);
            }

            return dataTable;
        }

        public DataTable BuscarParcelasPagas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Venda");

            ParcelaVendaDAO parcelaVendaDAO = new ParcelaVendaDAO();
            List<ParcelaVendaEntidade> listParcelaVendaEntidade = parcelaVendaDAO.BuscarParcelaPago();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaVendaEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaVendaEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaVendaEntidade[i].CodParcela,
                    listParcelaVendaEntidade[i].DataVencimento.ToString("dd:MM:yyyu"),
                    listParcelaVendaEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaVendaEntidade[i].CodVenda);
            }

            return dataTable;
        }

    }
}
