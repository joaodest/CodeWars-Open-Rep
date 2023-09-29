using ExercBanco;
using System.Runtime.Intrinsics.Arm;

namespace Solution {
    class Banco
    {
        static void Main(string[] args)
        {

            User user;

            Console.WriteLine("Entre com o numero da conta: ");
            int conta = int.Parse(read());
            Console.WriteLine("Entre com o nome do titular da conta: ");
            string titular = read();
            Console.WriteLine("Havera deposito inicial? (s/n): ");
            string depI = read();

            if (depI == "s" || depI == "S")
            {
                Console.WriteLine("Entre com o valor do deposito: ");
                double deposito = double.Parse(read());

                user = new User(conta, titular, deposito);
            }
            else
            {
                user = new User(conta, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(user);

            Console.WriteLine("Digite um valor para deposito: ");
            double saldo = double.Parse(read());
            user.Deposito(saldo);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(user);

            Console.WriteLine("Digite um valor para saque: ");
            saldo = double.Parse(read());
            user.Saque(saldo);

            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(user);




            static string read()
            {
                return Console.ReadLine();
            }

        }

    }

}