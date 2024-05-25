using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Telefone
{
    public class ItensTelefoneFuncionarioEntidade
    {
        public ItensTelefoneFuncionarioEntidade () { }

        private int _codFuncionario;
        private int _codTelefone;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int CodTelefone { get => _codTelefone; set => _codTelefone = value; }
    }
}
