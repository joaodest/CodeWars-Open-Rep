
using ProblemaEstoque;

namespace Course
{
    class ProblemaEstoque
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Nome do produto: ");
            produto.name = read();
            Console.WriteLine("Quantos produtos ha no estoque: ");
            produto.qty = int.Parse(read());
            Console.WriteLine("Qual o preco unitario desse produto: ");
            produto.preco = double.Parse(read());

            Console.WriteLine(produto.GetUpdate(produto.name, produto.preco, produto.qty));

            Console.WriteLine("Digite o numero de produtos a serem adicionados ao estoque: ");
            produto.AddProduct(5);
            produto.qty = int.Parse(read());
            Console.WriteLine(produto.GetUpdate(produto.name, produto.preco, produto.qty));
            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
            produto.qty = int.Parse(read());
            produto.DeleteProduct(5);
            Console.WriteLine(produto.GetUpdate(produto.name, produto.preco, produto.qty));
        }

        static string read()
        {
            return Console.ReadLine();
        }
    }
}