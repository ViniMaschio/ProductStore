using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Endereco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Endereco.Cep
{
    public partial class CepForm : Form
    {
        public CepForm(int codCep)
        {
            InitializeComponent();

            txtCod.Text = codCep.ToString();

            if (codCep != 0)
            {
                CepControler cepControler = new CepControler();
                txtCep.Text = cepControler.BuscarCepPorId(codCep);
            } 
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            CepEntidade cepEntidade = new CepEntidade() { Id = int.Parse(txtCod.Text), Cep = txtCep.Text };

            CepControler cepControler = new CepControler();

            if(cepEntidade.Id == 0)
            {
                cepControler.AddCep(cepEntidade);
            }
            else
            {
                cepControler.AltercarCep(cepEntidade);
            }

            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
