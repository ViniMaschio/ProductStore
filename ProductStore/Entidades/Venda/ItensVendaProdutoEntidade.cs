using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Venda
{
    public class ItensVendaProdutoEntidade
    {
        public ItensVendaProdutoEntidade() { }

        private int _codVenda;
        private int _codProduto;
        private double _quantidade;
        private double _valor;

        public int CodVenda { get => _codVenda; set => _codVenda = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
