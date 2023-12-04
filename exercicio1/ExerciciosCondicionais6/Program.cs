// See https://aka.ms/new-console-template for more information



using System.Globalization;

Console.WriteLine("Digite um valor:");
double n1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(n1<0 || n1>100 || n1>50 && n1<75)
{
    Console.WriteLine("Fora de intervalo");
}
else if(n1 > 25.0 && n1 < 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if(n1 > 0.0 && n1 <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else 
{
    Console.WriteLine("Intervalo (75,100]");
}
