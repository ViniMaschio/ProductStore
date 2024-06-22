using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using ProductStore.View.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Cliente
{
    public partial class TelefoneClienteScreen : Form
    {

        private int codCliente;
        public TelefoneClienteScreen(int codCliente)
        {
            InitializeComponent();
            this.codCliente = codCliente;
            CarregarDataGrid();
            CarregarTelefone();
        }

        private void CarregarDataGrid()
        {
            ItensTelefoneClienteControler itensTelefoneClienteControler = new ItensTelefoneClienteControler();
            dGVTelefoneCliente.DataSource = itensTelefoneClienteControler.BuscarTodosTelefonePorCliente(codCliente);
            dGVTelefoneCliente.Columns[0].Width = 50;
            dGVTelefoneCliente.Columns[1].Width = 180;

        }

        private void CarregarTelefone()
        {
            TelefoneControler telefoneControler = new TelefoneControler();
            cBoxTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            cBoxTelefone.DisplayMember = "Telefone";
            cBoxTelefone.ValueMember = "ID";
            //cBoxTelefone.Width = 250;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            ItensTelefoneClienteControler itensTelefoneClienteControler = new ItensTelefoneClienteControler();
            ItensTelefoneClienteEntidade itensTelefoneClienteEntidade = new ItensTelefoneClienteEntidade()
            {
                CodCliente = codCliente,
                CodTelefone = int.Parse(cBoxTelefone.SelectedValue.ToString())
            };
            itensTelefoneClienteControler.AddTelefoneCliente(itensTelefoneClienteEntidade);

            CarregarDataGrid();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            ItensTelefoneClienteControler itensTelefoneClienteControler = new ItensTelefoneClienteControler();
            ItensTelefoneClienteEntidade itensTelefoneClienteEntidade = new ItensTelefoneClienteEntidade()
            {
                CodCliente = codCliente,
                CodTelefone = int.Parse(dGVTelefoneCliente.CurrentRow.Cells[0].Value.ToString())
            };
            itensTelefoneClienteControler.DeletarTelefoneCliente(itensTelefoneClienteEntidade);

            CarregarDataGrid();
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
