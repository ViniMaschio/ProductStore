using ProductStore.DAO.Boletos;
using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Compra", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));

            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarTodasParcelas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaCompraEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].CodCompra,
                    listParcelaCompraEntidade[i].Date,
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

        public DataTable BuscarTodasParcelasEmAberto()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Compra", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));


            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarParcelaEmAberto();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaCompraEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].CodCompra,
                    listParcelaCompraEntidade[i].Date,
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

        public DataTable BuscarTodasParcelasPagas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Parcela", typeof(int));
            dataTable.Columns.Add("Compra", typeof(int));
            dataTable.Columns.Add("Vencimento", typeof(DateTime));
            dataTable.Columns.Add("Valor", typeof(double));
            dataTable.Columns.Add("Situacao", typeof(string));

            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            List<ParcelaCompraEntidade> listParcelaCompraEntidade = parcelaCompraDAO.BuscarParcelaPagas();

            SituacaoControler situacaoControler = new SituacaoControler();

            for (int i = 0; i < listParcelaCompraEntidade.Count; i++)
            {
                SituacaoEntidade situacaoEntidade = situacaoControler.BuscarSituacaoPorId(listParcelaCompraEntidade[i].CodSituacao);

                dataTable.Rows.Add(listParcelaCompraEntidade[i].CodParcela,
                    listParcelaCompraEntidade[i].CodCompra,
                    listParcelaCompraEntidade[i].Date,
                    listParcelaCompraEntidade[i].Valor,
                    situacaoEntidade.NomeSituacao
                    );
            }

            return dataTable;
        }

        public void PagarBoleto(ParcelaCompraEntidade parcelaCompraEntidade)
        {
            ParcelaCompraDAO parcelaCompraDAO = new ParcelaCompraDAO();

            if (MessageBox.Show("Tem certeza que desejar Pagar?", "Pagar Boleto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                parcelaCompraDAO.Pagar(parcelaCompraEntidade);
            }
        }
    }
}
