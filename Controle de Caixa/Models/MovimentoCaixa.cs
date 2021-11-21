using Controle_de_Caixa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Models
{
    public class MovimentoCaixa
    {
        int _id;
        Caixa _caixa;
        AcertoCaixa _acerto;
        decimal _valor;
        char _tipo;

        public Caixa Caixa { get => _caixa; set => _caixa = value; }
        public AcertoCaixa Acerto { get => _acerto; set => _acerto = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public char Tipo { get => _tipo; set => _tipo = value; }
        public int Id { get => _id; set => _id = value; }

        public (int, string) Gravar()
        {
            MovimentoCaixaDAO mcd = MovimentoCaixaDAO.getInstance();
            return (_, _) = mcd.Gravar(this);
        }
    }
}
