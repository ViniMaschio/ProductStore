using ProductStore.Controler.Endereco;
using ProductStore.Controler.Funcionario;
using ProductStore.Entidades.Endereco;
using ProductStore.Entidades.Funcionario;
using ProductStore.View.Endereco.Bairro;
using ProductStore.View.Endereco.Cep;
using ProductStore.View.Endereco.Rua;
using ProductStore.View.Funcionario.Funcao;
using ProductStore.View.Funcionario.Loja;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Funcionario.Funcionario
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm(int codFuncionario)
        {
            InitializeComponent();
            CarregarRua();
            CarregarBairro();
            BuscarCep();
            BuscarUf();
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));
            BuscarFuncao();
            BuscarLoja();

            txtCodigo.Text = codFuncionario.ToString();

            if (codFuncionario != 0)
            {
                CarregarFuncionario(codFuncionario);
            }
        }

        private void CarregarRua()
        {
            RuaControler ruaControler = new RuaControler();
            cBoxRua.DataSource = ruaControler.BuscarTodasRuas();
            cBoxRua.DisplayMember = "Rua";
            cBoxRua.ValueMember = "ID";
            cBoxRua.DropDownHeight = 200;
        }

        private void CarregarBairro()
        {
            BairroControler bairroControler = new BairroControler();
            cBoxBairro.DataSource = bairroControler.BuscarTodosBairro();
            cBoxBairro.DisplayMember = "Bairro";
            cBoxBairro.ValueMember = "ID";
            cBoxBairro.DropDownHeight = 200;
        }

        private void BuscarCep()
        {
            CepControler cepControler = new CepControler();
            cBoxCep.DataSource = cepControler.BuscarTodosCep();
            cBoxCep.DisplayMember = "CEP";
            cBoxCep.ValueMember = "ID";
            cBoxCep.DropDownHeight = 200;
        }

        private void BuscarUf()
        {
            UfControler ufControler = new UfControler();
            cBoxEstado.DataSource = ufControler.BuscarTodosUf();
            cBoxEstado.DisplayMember = "UF";
            cBoxEstado.ValueMember = "ID";
            cBoxEstado.DropDownHeight = 200;
        }

        private void BuscarCidade(int codUf)
        {
            CidadeControler cidadeControler = new CidadeControler();
            cBoxCidade.DataSource = cidadeControler.BuscarCidadePorUF(codUf);
            cBoxCidade.DisplayMember = "Cidade";
            cBoxCidade.ValueMember = "ID";
            cBoxCidade.DropDownHeight = 200;
        }

        private void BuscarFuncao()
        {
            FuncaoControler funcaoControler = new FuncaoControler();
            cBoxFuncao.DataSource = funcaoControler.BuscarTodasFuncao();
            cBoxFuncao.ValueMember = "ID";
            cBoxFuncao.DisplayMember = "Funcao";
            cBoxLoja.DropDownHeight = 200;
        }

        private void BuscarLoja()
        {
            LojaControler lojaControler = new LojaControler();
            cBoxLoja.DataSource = lojaControler.BuscarTodasLojas();
            cBoxLoja.DisplayMember = "Nome Loja";
            cBoxLoja.ValueMember = "ID";
            cBoxLoja.DropDownHeight = 200;
        }

        private void CarregarFuncionario(int codFuncionario)
        {
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(codFuncionario);

            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = cidadeControler.BuscarCidadePorId(funcionarioEntidade.CodCidade);

            txtNomeFuncionario.Text = funcionarioEntidade.NomeFuncionario;
            txtNumero.Text = funcionarioEntidade.NumeroCasa;
            txtSalario.Text = funcionarioEntidade.Salario.ToString();
            cBoxBairro.SelectedValue = funcionarioEntidade.CodBairro;
            cBoxCep.SelectedValue = funcionarioEntidade.CodCep;
            cBoxRua.SelectedValue = funcionarioEntidade.CodRua;
            cBoxEstado.SelectedValue = cidadeEntidade.Coduf;
            cBoxCidade.SelectedValue = funcionarioEntidade.CodCidade;
            cBoxFuncao.SelectedValue = funcionarioEntidade.CodFuncao;
            cBoxLoja.SelectedValue = funcionarioEntidade.CodLoja;
        }

        private void cBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioEntidade funcionarioEntidade = new FuncionarioEntidade()
            {
                Id = int.Parse(txtCodigo.Text),
                CodCep = (int)cBoxCep.SelectedValue,
                CodLoja = (int)cBoxLoja.SelectedValue,
                CodBairro = (int)cBoxBairro.SelectedValue,
                CodCidade = (int)cBoxCidade.SelectedValue,
                CodFuncao = (int)cBoxFuncao.SelectedValue,
                CodRua = (int)cBoxRua.SelectedValue,
                NumeroCasa = txtNumero.Text,
                Salario = double.Parse(txtSalario.Text),
                NomeFuncionario = txtNomeFuncionario.Text
            };

            FuncionarioControler funcionarioControler = new FuncionarioControler();

            if (funcionarioEntidade.Id == 0)
            {
                funcionarioControler.AddFuncionario(funcionarioEntidade);
            }
            else
            {
                funcionarioControler.AlterarFuncionario(funcionarioEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vntNovoRua_Click(object sender, EventArgs e)
        {
            RuaForm ruaForm = new RuaForm(0);
            ruaForm.ShowDialog();
            CarregarRua();
        }

        private void bntNovoBairro_Click(object sender, EventArgs e)
        {
            BairroForm bairroForm = new BairroForm(0);
            bairroForm.ShowDialog();
            CarregarBairro();
        }

        private void bntNovoCep_Click(object sender, EventArgs e)
        {
            CepForm cepForm = new CepForm(0);
            cepForm.ShowDialog();
            BuscarCep();
        }

        private void bntNovoFuncao_Click(object sender, EventArgs e)
        {
            FuncaoForm funcaoForm = new FuncaoForm(0);
            funcaoForm.ShowDialog();
            BuscarFuncao();
        }

        private void bntNovaLoja_Click(object sender, EventArgs e)
        {
            LojaForm lojaForm = new LojaForm(0);
            lojaForm.ShowDialog();
            BuscarLoja();
        }
    }
}
