using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Endereco.Bairro
{
    public partial class BairroForm : Form
    {
        public BairroForm(int codBairro)
        {
            InitializeComponent();

            txtCod.Text = codBairro.ToString();

            if (codBairro != 0)
            {
                BairroControler bairroControler = new BairroControler();
                txtBairro.Text = bairroControler.BuscarPorId(codBairro);
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {

            BairroEntidade bairroEntidade = new BairroEntidade()
            {
                Id = int.Parse(txtCod.Text),
                Bairro = txtBairro.Text
            };

            if (txtCod.Text == "0")
            {

                BairroControler bairroControler = new BairroControler();
                bairroControler.AddBairro(bairroEntidade);
            }
            else
            {
                BairroControler bairroControler = new BairroControler();
                bairroControler.AlterarBairro(bairroEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
