namespace ProductStore.Entidades.Produto
{
    public class ProdutoEntidade
    {
        public ProdutoEntidade() { }

        private int _id;
        private string _nomeproduto;
        private double _valor;
        private double _quantidade;
        private int _codigomarca;
        private int _codigotipo;

        public int Id { get => _id; set => _id = value; }
        public string Nomeproduto { get => _nomeproduto; set => _nomeproduto = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public int Codigomarca { get => _codigomarca; set => _codigomarca = value; }
        public int Codigotipo { get => _codigotipo; set => _codigotipo = value; }
    }
}
