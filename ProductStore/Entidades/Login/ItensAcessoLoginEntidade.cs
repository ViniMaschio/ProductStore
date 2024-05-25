using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Login
{
    public class ItensLoginAcessoEntidade
    {
        public ItensLoginAcessoEntidade() { }

        private int _codAcesso;
        private int _codLogin;

        public int CodAcesso { get => _codAcesso; set => _codAcesso = value; }
        public int CodLogin { get => _codLogin; set => _codLogin = value; }
    }
}
