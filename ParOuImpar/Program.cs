using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor numérico: ");
            var valor_numerico = Convert.ToInt16(Console.ReadLine());

            String par_inp = (valor_numerico % 2 == 0) ? "par" : "ímpar";
            String pos_neg = (valor_numerico >= 0) ? "positivo" : "negativo";

            Console.WriteLine("\n[O valor inserido é "+ par_inp+ " e "+ pos_neg+ "]");
        }
    }
}

