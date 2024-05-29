namespace ProductStore.Entidades.Funcionario
{
    public class FuncionarioEntidade
    {
        public FuncionarioEntidade() { }

        private int _id;
        private string _nomeFuncionario;
        private string _numeroCasa;
        private int _codRua;
        private int _codBairro;
        private int _codCidade;
        private int _codCep;
        private int _codFuncao;
        private double _salario;
        private int _codLoja;

        public int Id { get => _id; set => _id = value; }
        public string NomeFuncionario { get => _nomeFuncionario; set => _nomeFuncionario = value; }
        public string NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }
        public int CodRua { get => _codRua; set => _codRua = value; }
        public int CodBairro { get => _codBairro; set => _codBairro = value; }
        public int CodCidade { get => _codCidade; set => _codCidade = value; }
        public int CodCep { get => _codCep; set => _codCep = value; }
        public int CodFuncao { get => _codFuncao; set => _codFuncao = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public int CodLoja { get => _codLoja; set => _codLoja = value; }
    }
}
