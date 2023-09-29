
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
                   
            
            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(read());
            x.B = double.Parse(read());
            x.C = double.Parse(read());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(read());
            y.B = double.Parse(read());
            y.C = double.Parse(read());
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de X = " + areaY.ToString("F4"));

            if (areaX < areaY)
            {
                Console.WriteLine("Maior area: Y");
            } else
            {
                Console.WriteLine("Maior area: X");
            }

            static string read()
            {
                return Console.ReadLine();
            }
        }
    }
}