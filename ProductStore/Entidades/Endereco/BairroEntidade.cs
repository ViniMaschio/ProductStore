namespace ProductStore.Entidades.Endereco
{
    public class BairroEntidade
    {
        private int _id;
        private string _bairro;

        public BairroEntidade() { }

        public int Id { get => _id; set => _id = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
    }
}
