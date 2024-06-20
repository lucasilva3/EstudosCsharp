using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palavra: ");
            String palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length / 2; i++)
            {
                char esquerda = palavra[i];
                char direita  = palavra[palavra.Length - 1 - i];
                if (esquerda != direita)
                {
                    Console.WriteLine("Não é palíndromo.");
                }
                else
                {
                    Console.WriteLine("É palíndromo.");
                }
                break;
            }
        }
    }
}

