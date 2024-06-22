using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using ProductStore.View.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Trabalho
{
    public partial class TelefoneTrabalhoScreen : Form
    {
        private int _codTrabalho;

        public TelefoneTrabalhoScreen(int id)
        {
            InitializeComponent();
            _codTrabalho = id;
            CarregarTelefones();
            CarregarDataGrid();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade = new ItensTelefoneTrabalhoEntidade()
            {
                CodTelefone = int.Parse(cbBoxTelefone.SelectedValue.ToString()),
                CodTrabalho = _codTrabalho
            };
            ItensTelefoneTrabalhoControler itensTelefoneTrabalhoControler = new ItensTelefoneTrabalhoControler();

            itensTelefoneTrabalhoControler.AdicionarTelefone(itensTelefoneTrabalhoEntidade);

            CarregarDataGrid();
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            ItensTelefoneTrabalhoEntidade itensTelefoneTrabalhoEntidade = new ItensTelefoneTrabalhoEntidade()
            {
                CodTelefone = int.Parse(dGvTelefone.CurrentRow.Cells[0].Value.ToString()),
                CodTrabalho = _codTrabalho
            };
            ItensTelefoneTrabalhoControler itensTelefoneTrabalhoControler = new ItensTelefoneTrabalhoControler();

            itensTelefoneTrabalhoControler.RemoverTelefone(itensTelefoneTrabalhoEntidade);

            CarregarDataGrid();

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarDataGrid()
        {
            ItensTelefoneTrabalhoControler itensTelefoneTrabalhoControler = new ItensTelefoneTrabalhoControler();

            dGvTelefone.DataSource = itensTelefoneTrabalhoControler.BuscarTodosTelefonePorCliente(_codTrabalho);
            dGvTelefone.Columns[0].Width = 50;
            dGvTelefone.Columns[1].Width = 180;
        }

        private void CarregarTelefones()
        {
            TelefoneControler telefoneControler = new TelefoneControler();

            cbBoxTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            cbBoxTelefone.DisplayMember = "Telefone";
            cbBoxTelefone.ValueMember = "ID";
        }

        private void bntNovoTelefone_Click(object sender, EventArgs e)
        {
            TelefoneScreen telefoneScreen = new TelefoneScreen();
            telefoneScreen.ShowDialog();
            CarregarTelefones();
        }
    }
}
