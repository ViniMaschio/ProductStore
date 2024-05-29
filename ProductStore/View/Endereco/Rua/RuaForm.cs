using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Endereco.Rua
{
    public partial class RuaForm : Form
    {
        public RuaForm(int codRua)
        {
            InitializeComponent();
            if (codRua ==0) 
            {
                txtCodRua.Text = "0";
            }
            else
            {
                CarregarRua(codRua);
            }
        }

        private void CarregarRua(int codRua)
        {
            RuaControler ruaControler = new RuaControler();
            txtCodRua.Text = codRua.ToString(); 
            txtNomeRua.Text = ruaControler.BuscarPorId(codRua);
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            RuaEntidade ruaEntidade = new RuaEntidade()
            {
                Id = int.Parse(txtCodRua.Text),
                Rua = txtNomeRua.Text,
            };

            RuaControler ruaControler = new RuaControler();

            if (ruaEntidade.Id == 0)
            {
                ruaControler.NovaRua(ruaEntidade);
            }
            else
            {
                ruaControler.AlterarRua(ruaEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
