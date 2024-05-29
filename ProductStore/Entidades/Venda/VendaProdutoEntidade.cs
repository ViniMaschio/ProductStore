using System;

namespace ProductStore.Entidades.Venda
{
    public class VendaProdutoEntidade
    {
        public VendaProdutoEntidade() { }

        private int _id;
        private DateTime _dataVenda;
        private int _codCliente;
        private int _codFuncionario;

        public int Id { get => _id; set => _id = value; }
        public DateTime DataVenda { get => _dataVenda; set => _dataVenda = value; }
        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
    }
}
