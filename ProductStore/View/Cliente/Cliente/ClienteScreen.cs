using ProductStore.Controler.Cliente;
using ProductStore.Entidades.Cliente;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Cliente
{
    public partial class ClienteScreen : Form
    {
        public ClienteScreen()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            ClienteControler clienteControler = new ClienteControler();
            DataTable dataTable = clienteControler.BuscarTodosCliente();
            dGVCliente.DataSource = dataTable;
            dGVCliente.Columns[0].Width = 50;
            dGVCliente.Columns[1].Width = 250;
            dGVCliente.Columns[2].Width = 130;
            dGVCliente.Columns[3].Width = 130;
            dGVCliente.Columns[4].Width = 220;
            dGVCliente.Columns[5].Width = 85;
            dGVCliente.Columns[6].Width = 220;
            dGVCliente.Columns[7].Width = 220;
            dGVCliente.Columns[8].Width = 120;
            dGVCliente.Columns[9].Width = 100;
            dGVCliente.Columns[10].Width = 220;
            

        }

        private ClienteEntidade BuscarLinhaDataGrid()
        {
            ClienteEntidade clienteEntidade = new ClienteEntidade() { Id = 0 };

            if (dGVCliente.Rows.Count > 0)
            {
                clienteEntidade.Id = (int)dGVCliente.CurrentRow.Cells[0].Value;
                clienteEntidade.NomeCliente = (string)dGVCliente.CurrentRow.Cells[1].Value;
            }
            return clienteEntidade;

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(0);
            clienteForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {   
            ClienteEntidade clienteEntidade = BuscarLinhaDataGrid();
            ClienteForm clienteForm = new ClienteForm(clienteEntidade.Id);
            clienteForm.ShowDialog();
            CarregarDataGrid();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {

        }

        private void bntTelefone_Click(object sender, EventArgs e)
        {

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
