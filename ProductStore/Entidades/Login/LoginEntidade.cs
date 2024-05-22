using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Login
{
    public class LoginEntidade
    {
        public LoginEntidade() { }

        private int _id;
        private string _usuario;
        private string _senha;
        private int _funcionario;

        public int Id { get => _id; set => _id = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public int Funcionario { get => _funcionario; set => _funcionario = value; }
    }
}
