namespace ProductStore.Entidades.Telefone
{
    public class OperadoraEntidade
    {
        private int _id;
        private string _nomeOperadora;

        public OperadoraEntidade() { }

        public int Id { get => _id; set => _id = value; }
        public string NomeOperadora { get => _nomeOperadora; set => _nomeOperadora = value; }
    }
}
