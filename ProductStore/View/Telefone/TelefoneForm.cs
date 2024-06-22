using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Telefone
{
    public partial class TelefoneForm : Form
    {
        public TelefoneForm(int codTelefone)
        {
            InitializeComponent();
            txtCod.Text = codTelefone.ToString();
            CarregarOperadora();

            if (codTelefone != 0)
            {
                TelefoneControler telefoneControler = new TelefoneControler();
                TelefoneEntidade telefoneEntidade = telefoneControler.BuscarTelefonePorID(codTelefone);
                txtTelefone.Text = telefoneEntidade.Telefone;
                cBoxOperadora.SelectedValue = telefoneEntidade.CodOperadora;
            }

        }

        private void CarregarOperadora()
        {
            OperadoraControler operadoraControler = new OperadoraControler();
            cBoxOperadora.DataSource = operadoraControler.BuscarTodasOperadora();
            cBoxOperadora.ValueMember = "ID";
            cBoxOperadora.DisplayMember = "Operadora";
            cBoxOperadora.DropDownWidth = 200;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            TelefoneEntidade telefoneEntidade = new TelefoneEntidade()
            {
                Id = int.Parse(txtCod.Text.ToString()),
                Telefone = txtTelefone.Text,
                CodOperadora = (int)cBoxOperadora.SelectedValue
            };
            TelefoneControler telefoneControler = new TelefoneControler();
            if (telefoneEntidade.Id != 0)
            {
                telefoneControler.AlterarTelefone(telefoneEntidade);
            }
            else
            {
                telefoneControler.AddTelefone(telefoneEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
