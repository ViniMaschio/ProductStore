using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using ProductStore.View.Endereco.Rua;
using System.Windows.Forms;

namespace ProductStore.View.Endereco
{
    public partial class RuaScrean : Form
    {
        public RuaScrean()
        {
            InitializeComponent();

            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            RuaControler ruaControler = new RuaControler();
            dGVRua.DataSource = ruaControler.BuscarTodasRuas();
            dGVRua.Columns[0].Width = 50;
            dGVRua.Columns[1].Width = 280;
        }

        private RuaEntidade BuscarLinhaDatagrid()
        {
            RuaEntidade ruaEntidade = new RuaEntidade()
            {
                Id = 0
            };


            if (dGVRua.Rows.Count > 0)
            {
                ruaEntidade.Id = (int)dGVRua.CurrentRow.Cells[0].Value;
                ruaEntidade.Rua = (string)dGVRua.CurrentRow.Cells[1].Value;
            }
            return ruaEntidade;
        }

        private void bntNovo_Click(object sender, System.EventArgs e)
        {
            RuaForm ruaForm = new RuaForm(0);
            ruaForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, System.EventArgs e)
        {
            RuaEntidade ruaEntidade = BuscarLinhaDatagrid();

            if (ruaEntidade.Id != 0)
            {
                RuaForm ruaForm = new RuaForm(ruaEntidade.Id);
                ruaForm.ShowDialog();
                CarregarDataGrid();
            }
        }

        private void bntExcluir_Click(object sender, System.EventArgs e)
        {
            RuaEntidade ruaEntidade = BuscarLinhaDatagrid();

            if (ruaEntidade.Id != 0)
            {
                RuaControler ruaControler = new RuaControler();
                ruaControler.DeletarRua(ruaEntidade);
                CarregarDataGrid();
            }
        }

        private void bntSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
