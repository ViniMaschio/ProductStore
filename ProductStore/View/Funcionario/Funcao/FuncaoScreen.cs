using ProductStore.Controler.Funcionario;
using ProductStore.Entidades.Funcionario;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Funcao
{
    public partial class FuncaoScreen : Form
    {
        public FuncaoScreen()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            FuncaoControler funcaoControler = new FuncaoControler();
            dGVFuncao.DataSource = funcaoControler.BuscarTodasFuncao();
            dGVFuncao.Columns[0].Width = 50;
            dGVFuncao.Columns[1].Width = 250;
        }

        private FuncaoEntidade BuscarLinhaDataGrid()
        {
            FuncaoEntidade funcaoEntidade = new FuncaoEntidade() { Id = 0 };

            if (dGVFuncao.Rows.Count > 0)
            {
                funcaoEntidade.Id = (int)dGVFuncao.CurrentRow.Cells[0].Value;
                funcaoEntidade.NomeFuncao = dGVFuncao.CurrentRow.Cells[1].Value.ToString();
            }
            return funcaoEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            FuncaoForm funcaoForm = new FuncaoForm(0);
            funcaoForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            FuncaoEntidade funcaoEntidade = BuscarLinhaDataGrid();

            if (funcaoEntidade.Id != 0)
            {
                FuncaoForm funcaoForm = new FuncaoForm(funcaoEntidade.Id);
                funcaoForm.ShowDialog();
                CarregarDataGrid();
            }
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            FuncaoEntidade funcaoEntidade = BuscarLinhaDataGrid();

            if (funcaoEntidade.Id != 0)
            {
                FuncaoControler funcaoControler = new FuncaoControler();
                funcaoControler.RemoverFuncao(funcaoEntidade);

                CarregarDataGrid();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
