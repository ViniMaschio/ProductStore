namespace ProductStore.Entidades.Endereco
{
    public class UfEntidade
    {
        private int _id;
        private string _nomeuf;
        private string _sigla;

        public int Id { get => _id; set => _id = value; }
        public string Nomeuf { get => _nomeuf; set => _nomeuf = value; }
        public string Sigla { get => _sigla; set => _sigla = value; }

        public UfEntidade() { }
    }
}
