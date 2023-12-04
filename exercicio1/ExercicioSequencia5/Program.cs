// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Informe código da peça 1, número de peças 1, o valor da peça 1:");
String[] pecas = Console.ReadLine().Split(' ');

string codigo1 = pecas[0];
int quantidade1 = int.Parse(pecas[1]);
double valor1 = double.Parse(pecas[2], CultureInfo.InvariantCulture);
    
    
Console.WriteLine("Informe código da peça 2, número de peças 2, o valor da peça 2:");

pecas = Console.ReadLine().Split(' ');
string codigo2 = pecas[0];
int quantidade2 = int.Parse(pecas[1]);
double valor2 = double.Parse(pecas[2], CultureInfo.InvariantCulture);

double valorTotal = quantidade1 * valor1 + quantidade2 * valor2;

Console.WriteLine("Valor a pagar: R$ "+ valorTotal.ToString("F2", CultureInfo.InvariantCulture));