using ProductStore.Controler.Funcionario;
using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Loja
{
    public partial class LojaScreen : Form
    {
        public LojaScreen()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            LojaControler lojaControler = new LojaControler();

            dGWLoja.DataSource = lojaControler.BuscarTodasLojas();
            dGWLoja.Columns[0].Width = 50;
            dGWLoja.Columns[1].Width = 250;
            dGWLoja.Columns[2].Width = 250;
            dGWLoja.Columns[3].Width = 250;
            dGWLoja.Columns[4].Width = 250;
        }

        private LojaEntidade BuscarLinhaDataGrid()
        {
            LojaEntidade lojaEntidade = new LojaEntidade() { Id = 0};
            
            if(dGWLoja.Rows.Count > 0)
            {
                lojaEntidade.Id = (int) dGWLoja.CurrentRow.Cells[0].Value;
                lojaEntidade.NomeLoja = dGWLoja.CurrentRow.Cells[1].Value.ToString();
            }
            return lojaEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LojaForm lojaForm = new LojaForm(0);
            lojaForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            LojaEntidade buscar = BuscarLinhaDataGrid();
            if(buscar.Id != 0)
            {
                LojaForm lojaForm = new LojaForm(buscar.Id);
                lojaForm.ShowDialog();
            }
            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            LojaControler lojaControler = new LojaControler();

            LojaEntidade buscar = BuscarLinhaDataGrid();

            if (buscar.Id != 0)
            {
                lojaControler.DeletarLoja(buscar);
            }
            CarregarDataGrid();
        }

        private void bntTelefone_Click(object sender, EventArgs e)
        {   
            LojaEntidade Buscar = BuscarLinhaDataGrid();
            TelefoneLojaScreen telefoneLoja = new TelefoneLojaScreen(Buscar.Id);
            telefoneLoja.ShowDialog();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
