using ExercFuncionario;

namespace Exercicio{
    class ExercFuncionario
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Digite o nome do funcionario: ");
            string nome = read();
            Console.WriteLine("Digite o valor bruto do funcionario: ");
            double valor = double.Parse(read());
            Funcionario funcionario = new Funcionario(nome, valor);
            

            Console.WriteLine("Digite o valor de imposto: ");
            double imposto = double.Parse(read());
            Console.WriteLine("Funcionario: " + nome + "\n" + "salario de R$" + funcionario.SalarioLiquido(imposto));

            Console.WriteLine("Digite a porcentagem de aumento: ");
            double porcentagem = double.Parse(read());

            Console.WriteLine("Dados atualizados: " + nome + ", R$ " + (funcionario.AumentarSalario(porcentagem) - imposto));

        }
        static string read()
        {
            return Console.ReadLine();
        }
    }

}