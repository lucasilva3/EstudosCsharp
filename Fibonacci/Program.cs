using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;

            Console.WriteLine("Quantidade de termos: ");
            int termos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResultado: ");
            for(int i = termos; i > 0; i--)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
