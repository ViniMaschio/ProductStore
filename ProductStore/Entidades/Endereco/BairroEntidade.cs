using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Endereco
{
    public class BairroEntidade
    {
        private int _id;
        private string _bairro;

        public BairroEntidade() { }

        public int Id { get => _id; set => _id = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
    }
}
