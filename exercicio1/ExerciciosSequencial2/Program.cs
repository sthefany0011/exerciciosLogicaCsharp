// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Entre com o valor do raio");

double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double area = 3.14159 * (raio * raio);

    Console.WriteLine("A= "+ area.ToString("f4", CultureInfo.InvariantCulture));
