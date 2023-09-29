using ExercRetangulo;
using System.Formats.Asn1;
using System.Threading.Channels;

namespace Exercicio
{
    class ExercRetangulo
    {
        
        static void Main(string[] args)
        {
            
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a base");
            retangulo.b = double.Parse(read());
            Console.WriteLine("Digite a digite a altura");
            retangulo.h = double.Parse(read());
            Console.WriteLine("A area eh: " + retangulo.area(retangulo.b, retangulo.h));
            Console.WriteLine("O perimetro eh: " + retangulo.perimetro(retangulo.b, retangulo.h));
            Console.WriteLine("A diagonal eh: " + retangulo.diagonal(retangulo.b, retangulo.h));
        }
         
        static string read()
        {
            return Console.ReadLine();
        }
    }
    
}
