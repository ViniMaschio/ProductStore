using ProductStore.Entidades.Boletos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Compra
{
    public partial class PagamentoCompraScreen : Form
    {
        public PagamentoCompraScreen(double ValorTotal)
        {
            InitializeComponent();
            _valorTotal = ValorTotal;
            CarregarDataGrid();
        }

        public List<ParcelaCompraEntidade> _listParcelaCompraEntidade = new List<ParcelaCompraEntidade>();

        private double _valorTotal = 0;

        private void CarregarDataGrid()
        {
            if (txtQuantidadeParcela.Text != "")
            {
                int parcelas = int.Parse(txtQuantidadeParcela.Text);
                dGVBoletos.Rows.Clear();
                DateTime dateTime = DateTime.Now;
                for (int i = 1; i <= parcelas; i++)
                {
                    dGVBoletos.Rows.Add(i, "", (_valorTotal / parcelas), dateTime.AddMonths(i).ToString("dd/MM/yyyy"));
                }
            }
        }

        private void txtQuantidadeParcela_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dGVBoletos.Rows.Count; i++)
            {
                _listParcelaCompraEntidade.Add(new ParcelaCompraEntidade()
                {
                    CodParcela = (int)dGVBoletos.Rows[i].Cells[0].Value,
                    CodSituacao = 1,
                    Valor = double.Parse(dGVBoletos.Rows[i].Cells[2].Value.ToString()),
                    Date = DateTime.Parse(dGVBoletos.Rows[i].Cells[3].Value.ToString())
                });
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
