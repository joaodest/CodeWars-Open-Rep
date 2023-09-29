using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata6
{

    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com uma string");
            var input = DuplicateCount(Console.ReadLine());
            Console.WriteLine($"existem {input} caracteres repetidos");

        }
        public static int DuplicateCount(string str)
        {



            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                char lowerCase = char.ToLower(c);
                if (char.IsLetterOrDigit(lowerCase))
                {
                    if (dict.ContainsKey(lowerCase))
                    {
                        dict[lowerCase]++;

                    }
                    else
                    {
                        dict[lowerCase] = 1;
                    }
                }
            }

            int count = 0;

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    count++;
                }
            }

            return count;

        }
    }
}

