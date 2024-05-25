using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Login
{
    public class AcessoEntidade
    {
        public AcessoEntidade() { }

        private int _id;
        private string _nomeAcesso;

        public int Id { get => _id; set => _id = value; }
        public string NomeAcesso { get => _nomeAcesso; set => _nomeAcesso = value; }
    }
}
