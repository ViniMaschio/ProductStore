using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Produto
{
    public partial class TipoScreen : Form
    {
        public TipoScreen()
        {
            InitializeComponent();
        }

        

        private void TipoScreen_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private TipoEntidade BuscarlinhaDataGrid()
        {
            TipoEntidade tipoEntidade = new TipoEntidade();
            if (dGVTipo.RowCount != 0)
            {
                tipoEntidade.Id = (int)dGVTipo.CurrentRow.Cells[0].Value;
                tipoEntidade.Tipo = dGVTipo.CurrentRow.Cells[1].Value.ToString();
                return tipoEntidade;
            }
            return null;
        }
        private void CarregarDataGrid()
        {
            TipoControler tipoControler = new TipoControler();

            DataTable table = tipoControler.BuscarTodosTipos();

            dGVTipo.DataSource = table;
            dGVTipo.Columns[0].Width = 50;
            dGVTipo.Columns[1].Width = 370;
            
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            TipoControler tipoControler = new TipoControler();

            TipoEntidade tipoEntidade = BuscarlinhaDataGrid();

            if (tipoEntidade != null)
            {

                tipoControler.RemoverTipo(tipoEntidade);

                CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Não tem Tipo para excluir", "Erro Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
           

            TipoEntidade tipoEntidade = BuscarlinhaDataGrid();

            if (tipoEntidade != null)
            {

                TipoForm tipoForm = new TipoForm(tipoEntidade);

                tipoForm.ShowDialog();

                CarregarDataGrid();
            }else
            {
                MessageBox.Show("Não tem Tipo para editar", "Erro Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            TipoEntidade tipoEntidade = new TipoEntidade() { Id = 0, Tipo = "" };

            TipoForm tipoForm = new TipoForm(tipoEntidade);

            tipoForm.ShowDialog();

            CarregarDataGrid();

        }
    }
}
