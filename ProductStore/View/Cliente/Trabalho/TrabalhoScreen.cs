using ProductStore.Controler.Cliente;
using ProductStore.Entidades.Cliente;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Trabalho
{
    public partial class TrabalhoScreen : Form
    {
        public TrabalhoScreen()
        {
            InitializeComponent();
            CarregarTrabalho();

        }

        private void CarregarTrabalho()
        {
            TrabalhoControler trabalhoControler = new TrabalhoControler();
            DataTable dataTable = trabalhoControler.BuscarTodosTrabalho();
            dGVTrabalho.DataSource = dataTable;
            dGVTrabalho.Columns[0].Width = 50;
            dGVTrabalho.Columns[1].Width = 270;
        }

        private TrabalhoEntidade BuscarIdDaLinha()
        {
            TrabalhoEntidade trabalhoEntidade = new TrabalhoEntidade();

            if (dGVTrabalho.Rows.Count > 0)
            {
                trabalhoEntidade.Id = (int)dGVTrabalho.CurrentRow.Cells[0].Value;
                trabalhoEntidade.NomeTrabalho = (string)dGVTrabalho.CurrentRow.Cells[1].Value;
            }
            return trabalhoEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            TrabalhoForm trabalhoForm = new TrabalhoForm(0);
            trabalhoForm.ShowDialog();
            CarregarTrabalho();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            TrabalhoEntidade trabalhoEntidade = BuscarIdDaLinha();
            if (trabalhoEntidade.Id == 0)
            {
                MessageBox.Show("Selecione um trabalho", "Trabalho", MessageBoxButtons.OK);
            }
            else
            {
                TrabalhoForm trabalhoForm = new TrabalhoForm(trabalhoEntidade.Id);
                trabalhoForm.ShowDialog();
                CarregarTrabalho();
            }


        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            TrabalhoEntidade trabalhoEntidade = BuscarIdDaLinha();
            if (trabalhoEntidade.Id == 0)
            {
                MessageBox.Show("Selecione um trabalho", "Trabalho", MessageBoxButtons.OK);
            }
            else
            {
                TrabalhoControler trabalhoControler = new TrabalhoControler();

                trabalhoControler.DeletarTrabalho(trabalhoEntidade);
                CarregarTrabalho();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bntTelefone_Click(object sender, EventArgs e)
        {
            TrabalhoEntidade trabalhoEntidade = BuscarIdDaLinha();
            if (trabalhoEntidade.Id == 0)
            {
                MessageBox.Show("Selecione um trabalho", "Trabalho", MessageBoxButtons.OK);
            }
            else
            {
                TelefoneTrabalhoScreen telefoneTrabalhoScreen = new TelefoneTrabalhoScreen(trabalhoEntidade.Id);
                telefoneTrabalhoScreen.ShowDialog();

            }
        }
    }
}
