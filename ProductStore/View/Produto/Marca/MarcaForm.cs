using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Produto.Marca
{
    public partial class MarcaForm : Form
    {
        public MarcaForm(MarcaEntidade marcaEntidade)
        {
            InitializeComponent();
            txtCodigo.Text = marcaEntidade.Id.ToString();
            txtMarca.Text = marcaEntidade.Marca;
        }

        private void MarcaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            MarcaEntidade marcaEntidade = new MarcaEntidade() { Marca = txtMarca.Text , Id = int.Parse(txtCodigo.Text)};

            MarcaControler marcaControler = new MarcaControler();
            if (marcaEntidade.Id == 0)
            {
                marcaControler.AddMarca(marcaEntidade);
            }
            else
            {
                marcaControler.EditarMarca(marcaEntidade);
            }

            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
