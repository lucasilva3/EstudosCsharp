using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace NotasAluos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[4];

            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("\nMatrícula: ");
            int matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nota " + (i + 1) + ": ");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            int media = soma / notas.Length;
            String resultado = "";

            if (media >= 60)
            {
                if (media >= 65)
                {
                    resultado = "Aprovado!";
                    Console.WriteLine("\nMédia: " + media);
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    resultado = "Aprovado por conselho de classe!";
                    Console.WriteLine("\nMédia: " + media);
                    Console.WriteLine("Resultado: " + resultado);
                }
            }
            else if (media >= 45)
            {
                resultado = "Recuperação!";
                Console.WriteLine("\nMédia: " + media);
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                resultado = "Reprovado!";
                Console.WriteLine("\nMédia: " + media);
                Console.WriteLine("Resultado: " + resultado);
            }
        }
    }
}


/*
    10 10 10 50 = 20 | Reprovado
    10 80 85 60 = 58 | Recuperação
    60 60 60 79 = 64 | Aprovado Conselho Classe
    90 90 95 60 = 83 | Aprovado
 */




