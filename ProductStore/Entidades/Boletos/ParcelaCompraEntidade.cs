using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Boletos
{
    public class ParcelaCompraEntidade
    {
        public ParcelaCompraEntidade() { }

        private int _codParcela;
        private DateTime _date;
        private double _valor;
        private int _codSituacao;
        private int _codCompra;

        public int CodParcela { get => _codParcela; set => _codParcela = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public int CodSituacao { get => _codSituacao; set => _codSituacao = value; }
        public int CodCompra { get => _codCompra; set => _codCompra = value; }
    }
}
