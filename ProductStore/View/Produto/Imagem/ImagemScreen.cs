using ProductStore.Controler.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProductStore.View.Produto.Imagem
{
    public partial class ImagemScreen : Form
    {
        public ImagemScreen(int codProduto)
        {
            InitializeComponent();

            CarregarImagem(codProduto);
        }

        byte[] imagemCarregada;

        private void bntImagem_Click(object sender, EventArgs e)
        {
            Image Imagem = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Imagem = Image.FromFile(openFileDialog1.FileName);
                pictureBoxImagem.Image = Imagem;
                imagemCarregada = BuscarImage();
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            ImagemEntidade imagemEntidade = new ImagemEntidade()
            { Descricao = txtDescricao.Text, Image = imagemCarregada, CodigoProduto = int.Parse(txtCodProduto.Text), Id = int.Parse(txtCodImagem.Text) };

            ImagemControler imagemControler = new ImagemControler();
            if (txtCodImagem.Text != "")
            {
                imagemControler.AddImagem(imagemEntidade);
            }
            else
            {
                imagemControler.UpdateImagem(imagemEntidade);
            }
            this.Close();
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            if (txtCodImagem.Text != "")
            {
                ImagemEntidade imagemEntidade = new ImagemEntidade()
                { Descricao = txtDescricao.Text, Image = imagemCarregada, CodigoProduto = int.Parse(txtCodProduto.Text), Id = int.Parse(txtCodImagem.Text) };

                ImagemControler imagemControler = new ImagemControler();
                imagemControler.DeleteImagem(imagemEntidade);
                this.Close();
            }
            else { MessageBox.Show("Nao tem imagem para apagar!", "Deletar Imagem"); }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarImagem(int idProduto)
        {
            txtCodProduto.Text = idProduto.ToString();
            txtCodImagem.Text = "0";

            ImagemControler imagemControler = new ImagemControler();
            ImagemEntidade imagemEntidade = imagemControler.BuscarImagemPorProduto(idProduto);
            if (imagemEntidade != null)
            {
                txtCodImagem.Text = imagemEntidade.Id.ToString();
                txtDescricao.Text = imagemEntidade.Descricao;
                imagemCarregada = imagemEntidade.Image;
                pictureBoxImagem.Image = ByteArrayToImage(imagemEntidade.Image);
                //bntImagem.Enabled = false;
            }
        }

        private byte[] BuscarImage()
        {
            if (pictureBoxImagem.Image == null)
            {
                throw new InvalidOperationException("A imagem no pictureBoxImagem não está carregada.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                // Salva a imagem em formato JPEG (ou qualquer formato desejado)
                pictureBoxImagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private Image ByteArrayToImage(byte[] imagemBytes)
        {
            using (MemoryStream ms = new MemoryStream(imagemBytes))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }
    }
}
