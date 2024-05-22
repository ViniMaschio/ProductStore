using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Endereco
{
    public class CepEntidade
    {
        public CepEntidade() { }

        private int _id;
        private string _cep;

        public int Id { get => _id; set => _id = value; }
        public string Cep { get => _cep; set => _cep = value; }
    }
}
