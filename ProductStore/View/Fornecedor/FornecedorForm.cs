using ProductStore.Controler.Compra;
using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Endereco;
using ProductStore.View.Endereco.Bairro;
using ProductStore.View.Endereco.Cep;
using ProductStore.View.Endereco.Rua;
using System;
using System.Windows.Forms;

namespace ProductStore.View.Fornecedor
{
    public partial class FornecedorForm : Form
    {
        public FornecedorForm(int codFornecedor)
        {
            InitializeComponent();

            CarregarRua();
            CarregarBairro();
            BuscarCep();
            BuscarUf();
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));

            txtCodigo.Text = codFornecedor.ToString();

            if (codFornecedor != 0)
            {
                CarregarFornecedor(codFornecedor);
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

        private void CarregarFornecedor(int codFornecedor)
        {
            FornecedorControler fornecedorControler = new FornecedorControler();

            FornecedorEntidade fornecedorEntidade = fornecedorControler.BuscarFornecedorPorId(codFornecedor);

            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = cidadeControler.BuscarCidadePorId(fornecedorEntidade.CodCidade);

            txtFornecedor.Text = fornecedorEntidade.NomeFornecedor;
            txtNumero.Text = fornecedorEntidade.NumeroCasa;
            cBoxBairro.SelectedValue = fornecedorEntidade.CodBairro;
            cBoxCep.SelectedValue = fornecedorEntidade.CodCep;
            cBoxRua.SelectedValue = fornecedorEntidade.CodRua;
            cBoxEstado.SelectedValue = cidadeEntidade.Coduf;
            cBoxCidade.SelectedValue = fornecedorEntidade.CodCidade;

        }

        private void cBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));


        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            FornecedorEntidade fornecedorEntidade = new FornecedorEntidade()
            {
                Id = int.Parse(txtCodigo.Text),
                NomeFornecedor = txtFornecedor.Text,
                NumeroCasa = txtNumero.Text,
                CodBairro = (int)cBoxBairro.SelectedValue,
                CodCep = (int)cBoxCep.SelectedValue,
                CodCidade = (int)cBoxCidade.SelectedValue,
                CodRua = (int)cBoxRua.SelectedValue
            };

            FornecedorControler fornecedorControler = new FornecedorControler();

            if (fornecedorEntidade.Id == 0)
            {
                fornecedorControler.AddFornecedor(fornecedorEntidade);
            }
            else
            {
                fornecedorControler.AlterarFornecedor(fornecedorEntidade);
            }
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vntNovoRua_Click(object sender, EventArgs e)
        {
            RuaForm ruaForm =  new RuaForm(0);
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
    }
}
