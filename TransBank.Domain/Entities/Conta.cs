using System;

namespace TransBank.Domain.Entities
{
    public class Conta
    {
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }
    }
}
