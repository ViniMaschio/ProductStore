using ProductStore.Controler.Telefone;
using ProductStore.Entidades.Telefone;
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
    public partial class TelefoneLojaScreen : Form
    {
        private int _codLoja;
        public TelefoneLojaScreen(int codLoja)
        {
            InitializeComponent();
            _codLoja = codLoja;
            CarregarDataGird();
            CarregarTodosTelefone();
        }

        private void CarregarDataGird()
        {
            ItensTelefoneLojaControler itensTelefoneLojaControler = new ItensTelefoneLojaControler();

            dGVTelefoneLoja.DataSource = itensTelefoneLojaControler.BuscarTodosTelfonePorLoja(_codLoja);
            dGVTelefoneLoja.Columns[0].Width = 50;
            dGVTelefoneLoja.Columns[1].Width = 180;

        }

        private void CarregarTodosTelefone()
        {
            TelefoneControler telefoneControler = new TelefoneControler();

            cBoxTelefone.DataSource = telefoneControler.BuscarTodosTelefone();
            cBoxTelefone.ValueMember = "ID";
            cBoxTelefone.DisplayMember = "Telefone";
            cBoxTelefone.Width = 200;
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            ItensTelefoneLojaControler itensTelefoneLojaControler = new ItensTelefoneLojaControler();
            ItensTelefoneLojaEntidade itensTelefoneLojaEntidade = new ItensTelefoneLojaEntidade()
            {
                CodLoja = _codLoja,
                CodTelefone = int.Parse(cBoxTelefone.SelectedValue.ToString())
            };

            itensTelefoneLojaControler.AddTelefone(itensTelefoneLojaEntidade);

            CarregarDataGird();
            
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            ItensTelefoneLojaControler itensTelefoneLojaControler = new ItensTelefoneLojaControler();
            ItensTelefoneLojaEntidade itensTelefoneLojaEntidade = new ItensTelefoneLojaEntidade()
            {
                CodLoja = _codLoja,
                CodTelefone = (int)dGVTelefoneLoja.CurrentRow.Cells[0].Value
            };
            itensTelefoneLojaControler.DeletarTelefone(itensTelefoneLojaEntidade);

            CarregarDataGird();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
