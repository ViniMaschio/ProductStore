using ProductStore.Controler.Funcionario;
using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Loja
{
    public partial class LojaForm : Form
    {
        

        public LojaForm(int codLoja)
        {
            InitializeComponent();
            
            txtCod.Text = codLoja.ToString();

            if(codLoja != 0)
            {
                LojaControler lojaControler = new LojaControler();
                LojaEntidade loja = lojaControler.BuscarLojaPorId(codLoja);

                txtCNPJ.Text = loja.Cnpj;
                txtNomeFantasia.Text = loja.NomeFantasia;
                txtNomeLoja.Text = loja.NomeLoja;
                txtRazaoSocial.Text = loja.RazaoSocial;
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            LojaEntidade lojaEntidade = new LojaEntidade()
            {
                Id = int.Parse(txtCod.Text),
                Cnpj = txtCNPJ.Text,
                NomeFantasia = txtNomeFantasia.Text,
                NomeLoja = txtNomeLoja.Text,
                RazaoSocial = txtRazaoSocial.Text
            };

            LojaControler lojaControler = new LojaControler();

            if(lojaEntidade.Id == 0)
            {
                lojaControler.AdicionarLoja(lojaEntidade);
            }
            else
            {
                lojaControler.AlterarLoja(lojaEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
