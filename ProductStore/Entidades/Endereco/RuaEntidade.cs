using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Endereco
{
    public class RuaEntidade
    {
        private int _id;
        private string _Rua;

        public int Id { get => _id; set => _id = value; }
        public string Rua { get => _Rua; set => _Rua = value; }
    }
}
