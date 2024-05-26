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
    public class SituacaoControler
    {
        public SituacaoControler() { }

        public DataTable BuscarTodasSituacao()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Situcao");

            SituacaoDAO situacaoDAO = new SituacaoDAO();
            List<SituacaoEntidade> listSituacaoEntidade = situacaoDAO.BuscarTodasSituacao();

            for (int i = 0;i< listSituacaoEntidade.Count && listSituacaoEntidade != null; i++)
            {
                dataTable.Rows.Add(
                    listSituacaoEntidade[i].Id,
                    listSituacaoEntidade[i].NomeSituacao
                    );
            }

            return dataTable;
        }

        public SituacaoEntidade BuscarSituacaoPorId(int codSituacao)
        {
            SituacaoDAO situacaoDAO = new SituacaoDAO();

            return situacaoDAO.BuscaoSituacaoPorId(codSituacao);
        }
    }
}
