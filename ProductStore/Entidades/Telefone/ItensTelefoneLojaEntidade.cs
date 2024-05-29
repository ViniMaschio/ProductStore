namespace ProductStore.Entidades.Telefone
{
    public class ItensTelefoneLojaEntidade
    {

        public ItensTelefoneLojaEntidade() { }

        private int _codLoja;
        private int _codTelefone;

        public int CodLoja { get => _codLoja; set => _codLoja = value; }
        public int CodTelefone { get => _codTelefone; set => _codTelefone = value; }
    }
}
