using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using ProductStore.View.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Fornecedor
{
    public partial class TelefoneFornecedorScreen : Form
    {
        private int _codFornecedor;
        public TelefoneFornecedorScreen(int codFornecedor)
        {
            InitializeComponent();

            _codFornecedor = codFornecedor;

            CarregarDataGird();
            CarregarTodosTelefone();
        }

        private void CarregarDataGird()
        {
            ItensTelefoneFornecedorControler itensTelefoneFornecedorControler = new ItensTelefoneFornecedorControler();

            dGVTelefoneFornecedor.DataSource = itensTelefoneFornecedorControler.BuscarTelefonePorFornecedor(_codFornecedor);
            dGVTelefoneFornecedor.Columns[0].Width = 50;
            dGVTelefoneFornecedor.Columns[1].Width = 200;
        }

        private void CarregarTodosTelefone()
        {
            TelefoneControler telefoneControler = new TelefoneControler();

            cBoxTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            cBoxTelefone.DisplayMember = "Telefone";
            cBoxTelefone.ValueMember = "ID";
            cBoxTelefone.DropDownWidth = 200;
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            ItensTelefoneFornecedorEntidade itensTelefoneFornecedorEntidade = new ItensTelefoneFornecedorEntidade()
            {
                CodFornecedor = _codFornecedor,
                CodTelefone = (int)cBoxTelefone.SelectedValue
            };

            ItensTelefoneFornecedorControler itensTelefoneFornecedorControler = new ItensTelefoneFornecedorControler();
            itensTelefoneFornecedorControler.AddTelefone(itensTelefoneFornecedorEntidade);

            CarregarDataGird();
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            if (dGVTelefoneFornecedor.Rows.Count > 0)
            {
                ItensTelefoneFornecedorEntidade itensTelefoneFornecedorEntidade = new ItensTelefoneFornecedorEntidade()
                {
                    CodFornecedor = _codFornecedor,
                    CodTelefone = (int)dGVTelefoneFornecedor.CurrentRow.Cells[0].Value
                };

                ItensTelefoneFornecedorControler itensTelefoneFornecedorControler = new ItensTelefoneFornecedorControler();
                itensTelefoneFornecedorControler.RemoverTelefone(itensTelefoneFornecedorEntidade);

                CarregarDataGird();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntNovoTelefone_Click(object sender, EventArgs e)
        {
            TelefoneScreen telefoneScreen = new TelefoneScreen();
            telefoneScreen.ShowDialog();
            CarregarTodosTelefone();
        }
    }
}
