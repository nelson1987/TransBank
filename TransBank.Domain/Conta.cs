using System;

namespace TransBank.Domain
{
    public class Conta
    {
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }
    }
}
