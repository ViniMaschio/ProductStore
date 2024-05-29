namespace ProductStore.Entidades.Funcionario
{
    public class LojaEntidade
    {
        public LojaEntidade() { }

        private int _id;
        private string _nomeLoja;
        private string _cnpj;
        private string _nomeFantasia;
        private string _razaoSocial;

        public int Id { get => _id; set => _id = value; }
        public string NomeLoja { get => _nomeLoja; set => _nomeLoja = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
    }
}
