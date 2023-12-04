using System;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {

            string texto = Console.ReadLine();
            Console.WriteLine(texto);

            string[] frase = Console.ReadLine().Split(' ');
            string a = frase[0];
            Console.WriteLine(a);
            string b = frase[1];
            Console.WriteLine(b);
            string c = frase[2];

            Console.WriteLine(c);
        }
    }
}