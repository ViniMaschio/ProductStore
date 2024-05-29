namespace ProductStore.Entidades.Boletos
{
    public class SituacaoEntidade
    {
        public SituacaoEntidade() { }

        private int _id;
        private string _nomeSituacao;

        public int Id { get => _id; set => _id = value; }
        public string NomeSituacao { get => _nomeSituacao; set => _nomeSituacao = value; }
    }
}
