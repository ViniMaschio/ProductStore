namespace ProductStore.Entidades.Produto
{
    public class ImagemEntidade
    {
        public ImagemEntidade() { }

        private int _id;
        private byte[] _image;
        private string _descricao;
        private int _codigoProduto;

        public int Id { get => _id; set => _id = value; }
        public byte[] Image { get => _image; set => _image = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int CodigoProduto { get => _codigoProduto; set => _codigoProduto = value; }
    }
}
