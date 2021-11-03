using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Models
{
    public class AcertoCaixa
    {
        int _id;
        DateTime _data;
        bool _tipo;
        decimal _valor;
        string _motivo;

        public DateTime Data { get => _data; set => _data = value; }
        public bool Tipo { get => _tipo; set => _tipo = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
