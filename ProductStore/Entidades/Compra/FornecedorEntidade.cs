using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Compra
{
    public  class FornecedorEntidade
    {
        public FornecedorEntidade () { }

        private int _id;
        private string _nomeFornecedor;
        private string _numeroCasa;
        private int _codRua;
        private int _codBairro;
        private int _codCidade;
        private int _codCep;

        public int Id { get => _id; set => _id = value; }
        public string NomeFornecedor { get => _nomeFornecedor; set => _nomeFornecedor = value; }
        public string NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }
        public int CodRua { get => _codRua; set => _codRua = value; }
        public int CodBairro { get => _codBairro; set => _codBairro = value; }
        public int CodCidade { get => _codCidade; set => _codCidade = value; }
        public int CodCep { get => _codCep; set => _codCep = value; }
    }
}
