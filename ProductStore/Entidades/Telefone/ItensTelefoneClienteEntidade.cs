using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Telefone
{
    public class ItensTelefoneClienteEntidade
    {
        private int _codCliente;
        private int _codTelefone;

        public ItensTelefoneClienteEntidade() { }

        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodTelefone { get => _codTelefone; set => _codTelefone = value; }
    }
}
