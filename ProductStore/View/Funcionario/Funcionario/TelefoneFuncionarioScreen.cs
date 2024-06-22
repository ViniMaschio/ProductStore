using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using ProductStore.View.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Funcionario
{
    public partial class TelefoneFuncionarioScreen : Form
    {
        private int _codFuncionario;
        public TelefoneFuncionarioScreen(int codFuncionario)
        {
            InitializeComponent();
            _codFuncionario = codFuncionario;
            CarregarTelefone();
            CarregarDataGrid();
        }

        private void CarregarTelefone()
        {
            TelefoneControler telefoneControler = new TelefoneControler();
            cBoxTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            cBoxTelefone.ValueMember = "ID";
            cBoxTelefone.DisplayMember = "Telefone";
            cBoxTelefone.DropDownWidth = 200;
        }

        private void CarregarDataGrid()
        {
            ItensTelefoneFuncionarioControler itensTelefoneFuncionarioControler = new ItensTelefoneFuncionarioControler();

            dGVTelefoneFuncionario.DataSource = itensTelefoneFuncionarioControler.BuscarTelefonePorFuncionario(_codFuncionario);
            dGVTelefoneFuncionario.Columns[0].Width = 50;
            dGVTelefoneFuncionario.Columns[1].Width = 200;
        }

        private void BntAdicionar_Click(object sender, EventArgs e)
        {
            ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade = new ItensTelefoneFuncionarioEntidade()
            {
                CodTelefone = (int)cBoxTelefone.SelectedValue,
                CodFuncionario = _codFuncionario
            };
            ItensTelefoneFuncionarioControler itensTelefoneFuncionarioControler = new ItensTelefoneFuncionarioControler();

            itensTelefoneFuncionarioControler.AdicionarTelefone(itensTelefoneFuncionarioEntidade);

        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            ItensTelefoneFuncionarioEntidade itensTelefoneFuncionarioEntidade = new ItensTelefoneFuncionarioEntidade()
            {
                CodTelefone = (int)dGVTelefoneFuncionario.CurrentRow.Cells[0].Value,
                CodFuncionario = _codFuncionario
            };
            ItensTelefoneFuncionarioControler itensTelefoneFuncionarioControler = new ItensTelefoneFuncionarioControler();

            itensTelefoneFuncionarioControler.RemoverTelefone(itensTelefoneFuncionarioEntidade);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntNovoTelefone_Click(object sender, EventArgs e)
        {
            TelefoneScreen telefoneScreen = new TelefoneScreen();
            telefoneScreen.ShowDialog();
            CarregarTelefone();
        }
    }
}
