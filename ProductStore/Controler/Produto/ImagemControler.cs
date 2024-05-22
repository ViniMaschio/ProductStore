using ProductStore.DAO.Produto;
using ProductStore.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Produto
{
    public class ImagemControler
    {
        public ImagemControler() { }

        public void AddImagem(ImagemEntidade imagemEntidade)
        {
            ImagemDAo imagemDao = new ImagemDAo();

            imagemDao.Add(imagemEntidade);

            MessageBox.Show("Imagem Adicionada com Sucesso!","Adicionar Imagem",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateImagem(ImagemEntidade imagemEntidade)
        {
            ImagemDAo imagemDao = new ImagemDAo();

            imagemDao.Update(imagemEntidade);

            MessageBox.Show("Imagem Alterada com Sucesso!", "Alterar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteImagem(ImagemEntidade imagemEntidade)
        {
            ImagemDAo imagemDao = new ImagemDAo();

            if (MessageBox.Show("Tem Certeza que deseja Excluir a imagem do \nproduto"+ imagemEntidade.Id, "Deletar Imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                imagemDao.Delete(imagemEntidade.Id);

                MessageBox.Show("Imagem Excluida com Sucesso!", "Deletar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        public ImagemEntidade BuscarImagemPorProduto(int idProduto)
        {
            ImagemEntidade imagemEntidade;

            ImagemDAo imagemDao = new ImagemDAo();



            return  imagemEntidade = imagemDao.SeachForProdutc(idProduto);
        }
    }
}
