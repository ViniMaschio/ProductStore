using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Entidades.Login
{
    public class ControleLogSistemaEntidade
    {
        public ControleLogSistemaEntidade() { }

        private int _id;
        private int _codLogin;
        private DateTime _dataLog;
        private TimeSpan _hora;

        public int Id { get => _id; set => _id = value; }
        public int CodLogin { get => _codLogin; set => _codLogin = value; }
        public DateTime DataLog { get => _dataLog; set => _dataLog = value; }
        public TimeSpan Hora { get => _hora; set => _hora = value; }
    }
}
