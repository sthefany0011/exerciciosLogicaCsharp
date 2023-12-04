using System.Globalization;

Console.WriteLine("Digite os dois valores inteiros");

double x, y;

String[] valores = Console.ReadLine().Split(' ');

x = double.Parse(valores[0], CultureInfo.InvariantCulture);
y = double.Parse(valores[1], CultureInfo.InvariantCulture);


if(x>0.0 && y>0.0)
{
    Console.WriteLine("Q1");
}
else if (x<0.0 && y>0.0)
{
    Console.WriteLine("Q2");
}
else if (x<0.0 && y<0.0)
{
    Console.WriteLine("Q3");
}
else if (x>0 && y<0.0)
{
    Console.WriteLine("Q4");
}
else
{
    Console.WriteLine("Origem");
}