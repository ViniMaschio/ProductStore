using ProductStore.Controler.Cliente;
using ProductStore.Controler.Endereco;
using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Endereco;
using ProductStore.View.Endereco;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProductStore.View.Cliente.Cliente
{
    public partial class ClienteForm : Form
    {

        private byte[] FotoCarregada = null;

        public ClienteForm(int codCliente)
        {
            InitializeComponent();
            CarregarRua();
            CarregarBairro();
            BuscarCep();
            BuscarSexo();
            BuscarUf();
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));
            BuscarTrabalho();
            if (codCliente != 0)
            {
                CarregarCliente(codCliente);
            }
            else
            {
                txtCodigo.Text = "0";
            }
        }

        private void CarregarCliente(int codCliente)
        {
            ClienteControler clienteControler = new ClienteControler();
            ClienteEntidade clienteEntidade = clienteControler.BuscarClientePorId(codCliente);

            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = cidadeControler.BuscarCidadePorId(clienteEntidade.CodCidade);

            txtCodigo.Text = clienteEntidade.Id.ToString();
            txtNomeCliente.Text = clienteEntidade.NomeCliente;
            txtNumero.Text = clienteEntidade.NumeroCasa;
            txtSalario.Text = clienteEntidade.Salario.ToString();
            cBoxBairro.SelectedValue = clienteEntidade.CodBairro;
            cBoxCep.SelectedValue = clienteEntidade.CodCep;
            cBoxRua.SelectedValue = clienteEntidade.CodRua;
            cBoxSexo.SelectedValue = clienteEntidade.CodSexo;
            cBoxTrabalho.SelectedValue = clienteEntidade.CodTrabalho;
            cBoxEstado.SelectedValue = cidadeEntidade.Coduf;
            cBoxCidade.SelectedValue = clienteEntidade.CodCidade;
            FotoCliente.Image = ByteToImage(clienteEntidade.Foto);
            DataNascimento.Value = clienteEntidade.Datanasc;

            FotoCarregada = clienteEntidade.Foto;
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

        private void BuscarSexo()
        {
            SexoControler sexoControler = new SexoControler();
            cBoxSexo.DataSource = sexoControler.BuscarSexo();
            cBoxSexo.DisplayMember = "Sexo";
            cBoxSexo.ValueMember = "ID";
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

        private void BuscarTrabalho()
        {
            TrabalhoControler trabalhoControler = new TrabalhoControler();
            cBoxTrabalho.DataSource = trabalhoControler.BuscarTodosTrabalho();
            cBoxTrabalho.DisplayMember = "Trabalho";
            cBoxTrabalho.ValueMember = "ID";
            cBoxTrabalho.DropDownHeight = 200;
        }

        private byte[] ImageToByte()
        {
            if (FotoCliente.Image == null)
            {
                throw new InvalidOperationException("Nao tem imagem.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                // Salva a imagem em formato JPEG (ou qualquer formato desejado)
                FotoCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private Image ByteToImage(byte[] imagemBytes)
        {
            using (MemoryStream ms = new MemoryStream(imagemBytes))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

        private void bntSalvar_Click(object sender, System.EventArgs e)
        {
            ClienteControler clienteControler = new ClienteControler();

            ClienteEntidade clienteEntidade = new ClienteEntidade()
            {
                Id = int.Parse(txtCodigo.Text.ToString()),
                NomeCliente = txtNomeCliente.Text,
                Foto = FotoCarregada,
                CodBairro = int.Parse(cBoxBairro.SelectedValue.ToString()),
                CodCep = int.Parse(cBoxCep.SelectedValue.ToString()),
                CodCidade = int.Parse(cBoxCidade.SelectedValue.ToString()),
                CodRua = int.Parse(cBoxRua.SelectedValue.ToString()),
                CodSexo = int.Parse(cBoxSexo.SelectedValue.ToString()),
                CodTrabalho = int.Parse(cBoxTrabalho.SelectedValue.ToString()),
                NumeroCasa = txtNumero.Text,
                Salario = double.Parse(txtSalario.Text),
                Datanasc = DataNascimento.Value
            };
            if (clienteEntidade.Id == 0) {
                clienteControler.AddCliente(clienteEntidade);
            }
            else
            {
                clienteControler.AlterarCliente(clienteEntidade);
            }
            this.Close();

        }

        private void bntSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cBoxEstado_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BuscarCidade(int.Parse(cBoxEstado.SelectedValue.ToString()));
        }

        private void bntNovaFoto_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FotoCliente.Image = Image.FromFile(openFileDialog1.FileName);
                FotoCarregada = ImageToByte();
            }
        }

        private void vntNovoRua_Click(object sender, EventArgs e)
        {
            RuaScrean ruaScrean = new RuaScrean();
            ruaScrean.ShowDialog();
            CarregarRua();
        }
    }
}
