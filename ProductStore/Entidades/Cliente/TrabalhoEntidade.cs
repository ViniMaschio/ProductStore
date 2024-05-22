using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Cliente
{
    public class TrabalhoEntidade
    {
        private int _id;
        private string _nomeTrabalho;

        public int Id { get => _id; set => _id = value; }
        public string NomeTrabalho { get => _nomeTrabalho; set => _nomeTrabalho = value; }

        public TrabalhoEntidade() { }
    }
}
