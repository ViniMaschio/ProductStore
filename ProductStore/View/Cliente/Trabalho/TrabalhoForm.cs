using ProductStore.Controler.Cliente;
using ProductStore.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Trabalho
{
    public partial class TrabalhoForm : Form
    {
        public TrabalhoForm(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                txtCodigo.Text = id.ToString();
            }
            else
            {
                TrabalhoControler trabalhoControler = new TrabalhoControler();
                txtCodigo.Text = id.ToString();
                txtTrabalho.Text = trabalhoControler.BuscarTrabalhoPorId(id);
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {   
            TrabalhoEntidade trabalhoEntidade = new TrabalhoEntidade()
            {
                Id = int.Parse(txtCodigo.Text),
                NomeTrabalho = txtTrabalho.Text
            };
            TrabalhoControler trabalhoControler = new TrabalhoControler();

            if (trabalhoEntidade.Id == 0)
            {
                trabalhoControler.AddTrabalho(trabalhoEntidade);
            }
            else
            {
                trabalhoControler.AlterarTrabalho(trabalhoEntidade);
            }

            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
