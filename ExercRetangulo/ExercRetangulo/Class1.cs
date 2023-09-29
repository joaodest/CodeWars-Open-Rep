using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercRetangulo
{
    internal class Retangulo
    {
        public double b, h;


        public double area(double b, double h)
        { 
            return b * h;
        }

        public double perimetro(double b, double h)
        {
            return 2 * (b+h);
        }

        public double diagonal(double b, double h)
        {
            return Math.Sqrt(b*b + h*h);
        }
    }
}
