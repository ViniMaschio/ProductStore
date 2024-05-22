using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Cliente
{
    public class ClienteEntidade
    {
        private int _id;
        private string _nomeCliente;
        private byte[] _foto;
        private DateTime _datanasc;
        private int _codSexo;
        private int _codRua;
        private int _codBairro;
        private int _codCep;
        private int _codCidade;
        private int _codTrabalho;
        private double _salario;
        private string _numeroCasa;

        public int Id { get => _id; set => _id = value; }
        public string NomeCliente { get => _nomeCliente; set => _nomeCliente = value; }
        public byte[] Foto { get => _foto; set => _foto = value; }
        public DateTime Datanasc { get => _datanasc; set => _datanasc = value; }
        public int CodSexo { get => _codSexo; set => _codSexo = value; }
        public int CodRua { get => _codRua; set => _codRua = value; }
        public int CodBairro { get => _codBairro; set => _codBairro = value; }
        public int CodCep { get => _codCep; set => _codCep = value; }
        public int CodCidade { get => _codCidade; set => _codCidade = value; }
        public int CodTrabalho { get => _codTrabalho; set => _codTrabalho = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public string NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }

        public ClienteEntidade() { }
    }
}
