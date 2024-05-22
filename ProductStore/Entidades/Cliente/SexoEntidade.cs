using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Cliente
{
    public class SexoEntidade
    {
        private int _id;
        private string _sexo;

        public int Id { get => _id; set => _id = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
    }
}
