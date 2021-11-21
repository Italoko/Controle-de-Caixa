using Controle_de_Caixa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Models
{
    public class Caixa
    {
        int _id;
        decimal _saldoInicial;
        decimal _saldoFinal;
        bool _status;

        public decimal SaldoInicial { get => _saldoInicial; set => _saldoInicial = value; }
        public decimal SaldoFinal { get => _saldoFinal; set => _saldoFinal = value; }
        public bool Status { get => _status; set => _status = value; }
        public int Id { get => _id; set => _id = value; }

        public (int, string) Gravar()
        {
            CaixaDAO cd = CaixaDAO.getInstance();
            return (_, _) = cd.Gravar(this);
        }
    }
}
