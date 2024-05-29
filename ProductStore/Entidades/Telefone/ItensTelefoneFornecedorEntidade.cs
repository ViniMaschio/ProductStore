namespace ProductStore.Entidades.Telefone
{
    public class ItensTelefoneFornecedorEntidade
    {
        public ItensTelefoneFornecedorEntidade() { }

        private int _codFornecedor;
        private int _codTelefone;

        public int CodFornecedor { get => _codFornecedor; set => _codFornecedor = value; }
        public int CodTelefone { get => _codTelefone; set => _codTelefone = value; }
    }
}
