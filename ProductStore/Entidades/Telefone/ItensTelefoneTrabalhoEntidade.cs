namespace ProductStore.Entidades.Telefone
{
    public class ItensTelefoneTrabalhoEntidade
    {
        public ItensTelefoneTrabalhoEntidade() { }

        private int _codTrabalho;
        private int _codTelefone;

        public int CodTrabalho { get => _codTrabalho; set => _codTrabalho = value; }
        public int CodTelefone { get => _codTelefone; set => _codTelefone = value; }
    }
}
