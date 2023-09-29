

using System.Globalization;

namespace ExercBanco
{
    internal class User
    {

        public int Conta { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }




        public User(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;

        }

        public User(int conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        public double Saque(double valor)
        {
            return Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2");
        }

    }
}
