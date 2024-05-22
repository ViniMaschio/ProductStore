using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Produto
{
    public class MarcaEntidade
    {
        public MarcaEntidade() { }  

        private int _id;
        private string _marca;

        public int Id { get => _id; set => _id = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
