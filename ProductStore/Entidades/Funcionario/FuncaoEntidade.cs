namespace ProductStore.Entidades.Funcionario
{
    public class FuncaoEntidade
    {
        public FuncaoEntidade() { }

        private int _id;
        private string _nomeFuncao;

        public int Id { get => _id; set => _id = value; }
        public string NomeFuncao { get => _nomeFuncao; set => _nomeFuncao = value; }
    }
}
