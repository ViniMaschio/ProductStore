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
using System.Windows.Forms.VisualStyles;

namespace ProductStore.View.Produto
{
    public partial class TipoForm : Form
    {
        
        public TipoForm(TipoEntidade tipoEntidade)
        {
            InitializeComponent();
            txtCod.Text = tipoEntidade.Id.ToString();
            txtTipo.Text = tipoEntidade.Tipo;
        }

        private void TipoForm_Load(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            TipoEntidade TipoEntidade = new TipoEntidade() { Tipo = txtTipo.Text, Id = int.Parse(txtCod.Text) };

            TipoControler tipoControler = new TipoControler();

            if(TipoEntidade.Id == 0)
            {
                tipoControler.Add(TipoEntidade);
            }else
            {
                tipoControler.AlterarTipo(TipoEntidade);
            }
            this.Close();
        }
    }
}
