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

namespace ProductStore.View.Funcionario.Funcionario
{
    public partial class FuncionarioScreen : Form
    {
        public FuncionarioScreen()
        {
            InitializeComponent();
            CarregarDataGird();
        }

        private void CarregarDataGird()
        {
            FuncionarioControler funcionarioControler = new FuncionarioControler();

            dGVFuncionario.DataSource = funcionarioControler.BuscarTodosFuncionarios();
            dGVFuncionario.Columns[0].Width = 50;
            dGVFuncionario.Columns[1].Width = 250;
            dGVFuncionario.Columns[2].Width = 250;
            dGVFuncionario.Columns[3].Width = 150;
            dGVFuncionario.Columns[4].Width = 100;
            dGVFuncionario.Columns[5].Width = 200;
            dGVFuncionario.Columns[6].Width = 100;
            dGVFuncionario.Columns[7].Width = 200;
            dGVFuncionario.Columns[8].Width = 200;
            dGVFuncionario.Columns[9].Width = 130;
        }
        private FuncionarioEntidade BuscarLinhaDataGird()
        {
            FuncionarioEntidade funcionarioEntidade = new FuncionarioEntidade() { Id = 0 };
            
            if(dGVFuncionario.Rows.Count > 0 )
            {
                funcionarioEntidade.Id = int.Parse(dGVFuncionario.CurrentRow.Cells[0].Value.ToString());
                funcionarioEntidade.NomeFuncionario = dGVFuncionario.CurrentRow.Cells[1].Value.ToString();
            }
            return funcionarioEntidade;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
           
            FuncionarioForm funcionarioForm = new FuncionarioForm(0);
            funcionarioForm.ShowDialog();
            CarregarDataGird();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            FuncionarioEntidade funcionarioEntidade = BuscarLinhaDataGird();
            if (funcionarioEntidade.Id != 0)
            {
                FuncionarioForm funcionarioForm = new FuncionarioForm(funcionarioEntidade.Id);
                funcionarioForm.ShowDialog();
                CarregarDataGird();
            }
        }

        private void bntApagar_Click(object sender, EventArgs e)
        {
            FuncionarioEntidade funcionarioEntidade = BuscarLinhaDataGird();
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            funcionarioControler.DeletarFuncionario(funcionarioEntidade);
            CarregarDataGird();

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntTelefone_Click(object sender, EventArgs e)
        {
            FuncionarioEntidade funcionarioEntidade = BuscarLinhaDataGird();
            if (funcionarioEntidade.Id != 0)
            {
                TelefoneFuncionarioScreen telefoneFuncionarioScreen = new TelefoneFuncionarioScreen(funcionarioEntidade.Id);
                telefoneFuncionarioScreen.ShowDialog();
            }
        }
    }
}
