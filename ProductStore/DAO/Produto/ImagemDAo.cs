using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStore.Entidades.Login;
using ProductStore.Entidades.Produto;

namespace ProductStore.DAO.Produto
{
    public class ImagemDAo: ConfiguraBD
    {
        public ImagemDAo() { }

        public void Add(ImagemEntidade imagensEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "insert into imagem(imagem,descricao,codproduto_fk) values(@imagem,@descricao,@codproduto);";
                    cmd.Parameters.AddWithValue("@imagem", imagensEntidade.Image);
                    cmd.Parameters.AddWithValue("@descricao",imagensEntidade.Descricao);
                    cmd.Parameters.AddWithValue("@codproduto",imagensEntidade.CodigoProduto);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Erro Salvar Imagem"); }
                }
                conn.Close();
            }
        }
        
        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from imagem where codimagem = @codimagem; ";
                    cmd.Parameters.AddWithValue("@codimagem",id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Erro Deletar Imagem"); }
                }

                conn.Close();

            }
        }

        public void Update(ImagemEntidade imagensEntidade)
        {
            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();



                using (SqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "update imagem set  descricao = upper(@descricao) where codimagem = @codimagem;";
                    cmd.Parameters.AddWithValue("@imagem", imagensEntidade.Image);
                    cmd.Parameters.AddWithValue("@descricao",imagensEntidade.Descricao);
                    cmd.Parameters.AddWithValue("@codimagem", imagensEntidade.Id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Erro Alterar Imagem"); }
                }

                conn.Close();

            }
        }

        public ImagemEntidade SeachForProdutc(int idProduto)
        {

            ImagemEntidade imagensEntidade = null;

            using (SqlConnection conn = new SqlConnection(_stringconnetion))
            {
                conn.Open();


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select codimagem, imagem, descricao from imagem where codproduto_fk = @codproduto;";
                    cmd.Parameters.AddWithValue("@codproduto",idProduto);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            imagensEntidade = new ImagemEntidade()
                            {
                                Id = (int)reader["codimagem"],
                                Descricao = (string)reader["descricao"],
                                Image = (byte[])reader["imagem"],
                                CodigoProduto = idProduto
                            };
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message, "Procurar Imagem"); }
                }

                conn.Close();
            }
            return imagensEntidade;
        }

        
        
    }
}
