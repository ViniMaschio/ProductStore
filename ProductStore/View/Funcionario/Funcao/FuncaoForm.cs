using ProductStore.Controler.Funcionario;
using ProductStore.Entidades.Funcionario;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Funcao
{
    public partial class FuncaoForm : Form
    {
        public FuncaoForm(int CodFuncao)
        {
            InitializeComponent();

            txtCod.Text = CodFuncao.ToString();

            if (CodFuncao != 0)
            {
                FuncaoControler funcaoControler = new FuncaoControler();
                txtFuncao.Text = funcaoControler.BuscarFuncaoPorId(CodFuncao);
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            FuncaoControler funcaoControler = new FuncaoControler();
            FuncaoEntidade funcaoEntidade = new FuncaoEntidade()
            {
                Id = int.Parse(txtCod.Text),
                NomeFuncao = txtFuncao.Text
            };
            if (funcaoEntidade.Id == 0)
            {
                funcaoControler.AdicionarFuncao(funcaoEntidade);
            }
            else
            {
                funcaoControler.AlterarFuncao(funcaoEntidade);
            }
            this.Close();
        }

        private void BntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
