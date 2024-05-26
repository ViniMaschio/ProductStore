using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Compra
{
    public class ItensCompraProdutoEntidade
    {
        public ItensCompraProdutoEntidade() { }

        private int _codCompra;
        private int _codProduto;
        private double _quantidade;
        private double _valorc;

        public int CodCompra { get => _codCompra; set => _codCompra = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public double Valorc { get => _valorc; set => _valorc = value; }
    }
}
