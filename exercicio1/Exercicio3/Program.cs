using System;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;

namespace Exercicio3
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine(preco);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):\r\n");
            string[] dados = Console.ReadLine().Split(' ');

            string nome = dados[0];
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
        }

    }


}