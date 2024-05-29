namespace ProductStore.Entidades.Telefone
{
    public class TelefoneEntidade
    {
        private int _id;
        private string _Telefone;
        private int _codOperadora;

        public int Id { get => _id; set => _id = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public int CodOperadora { get => _codOperadora; set => _codOperadora = value; }

        public TelefoneEntidade() { }
    }
}
