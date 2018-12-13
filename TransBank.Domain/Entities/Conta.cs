using System;

namespace TransBank.Domain.Entities
{
    public class Conta
    {
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("Não pode depositar vaor menor ou igual a zero.");

            Saldo += valor;
        }
    }
}
