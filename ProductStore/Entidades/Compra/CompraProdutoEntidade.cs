using System;

namespace ProductStore.Entidades.Compra
{
    public class CompraProdutoEntidade
    {
        public CompraProdutoEntidade() { }

        private int _id;
        private DateTime _dataCompra;
        private int _codFuncionario;
        private int _codFornecedor;

        public int Id { get => _id; set => _id = value; }
        public DateTime DataCompra { get => _dataCompra; set => _dataCompra = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int CodFornecedor { get => _codFornecedor; set => _codFornecedor = value; }
    }
}
