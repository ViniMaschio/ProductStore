using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Produto
{
    public class TipoEntidade
    {
        private string _tipo;
        private int _id;

        public string Tipo { get => _tipo; set => _tipo = value; }
        public int Id { get => _id; set => _id = value; }

        public TipoEntidade() { }


    }
}
