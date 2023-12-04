using System;
using System.Globalization;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));


            string[] dados = Console.ReadLine().Split(' ');

            string name= dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3],CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString( CultureInfo.InvariantCulture));    
            }
    }
}