using ProductStore.DAO.Boletos;
using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Boletos
{
    public class ParcelaCompraControler
    {
        public void AddParcelas(List<ParcelaCompraEntidade> listParcelaCompraEntidade)
        {
            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();
            parcelaCompraDAO.Add(listParcelaCompraEntidade);
        }

        public void DeletarParcelas(int codCompra)
        {
            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();
            parcelaCompraDAO.Deletar(codCompra);
        }

        public DataTable BuscarTodasParcelas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Compra");

            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarTodasParcelas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0;i< listParcelaCompraEntidade.Count;i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].Date.ToString("dd:MM:yyyu"),
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaCompraEntidade[i].CodCompra);
            }
            
            return dataTable;
        }

        public DataTable BuscarTodasParcelasEmAberto()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Compra");

            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarParcelaEmAberto();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaCompraEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].Date.ToString("dd:MM:yyyu"),
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaCompraEntidade[i].CodCompra);
            }

            return dataTable;
        }

        public DataTable BuscarTodasParcelasPagas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela");
            dataTable.Columns.Add("Vencimento");
            dataTable.Columns.Add("Valor");
            dataTable.Columns.Add("Situacao");
            dataTable.Columns.Add("Compra");

            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarParcelaPagas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaCompraEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].Date.ToString("dd:MM:yyyu"),
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao,
                    listParcelaCompraEntidade[i].CodCompra);
            }

            return dataTable;
        }

        public void PagarBoleto(ParcelaCompraEntidade parcelaCompraEntidade)
        {
            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            parcelaCompraDAO.Pagar(parcelaCompraEntidade);
        }
    }
}
