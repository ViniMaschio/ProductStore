namespace ProductStore.Entidades.Endereco
{
    public class CidadeEntidade
    {
        private int _id;
        private string _nomecidade;
        private int _coduf;

        public int Id { get => _id; set => _id = value; }
        public string Nomecidade { get => _nomecidade; set => _nomecidade = value; }
        public int Coduf { get => _coduf; set => _coduf = value; }

        public CidadeEntidade() { }
    }
}
