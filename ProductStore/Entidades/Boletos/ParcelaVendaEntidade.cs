using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Boletos
{
    public class ParcelaVendaEntidade
    {
        public ParcelaVendaEntidade() { }

        private int _codParcela;
        private DateTime _dataVencimento;
        private double _valor;
        private int _codSituacao;
        private int _codVenda;

        public int CodParcela { get => _codParcela; set => _codParcela = value; }
        public DateTime DataVencimento { get => _dataVencimento; set => _dataVencimento = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public int CodSituacao { get => _codSituacao; set => _codSituacao = value; }
        public int CodVenda { get => _codVenda; set => _codVenda = value; }
    }
}
