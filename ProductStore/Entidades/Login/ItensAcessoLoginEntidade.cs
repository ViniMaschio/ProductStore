namespace ProductStore.Entidades.Login
{
    public class ItensAcessoLoginEntidade
    {
        public ItensAcessoLoginEntidade() { }

        private int _codAcesso;
        private int _codLogin;

        public int CodAcesso { get => _codAcesso; set => _codAcesso = value; }
        public int CodLogin { get => _codLogin; set => _codLogin = value; }
    }
}
