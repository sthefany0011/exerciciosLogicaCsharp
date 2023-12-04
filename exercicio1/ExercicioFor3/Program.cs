using System.Globalization;

Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i < n; i++)
{
    String[] x =Console.ReadLine().Split(' ');

    double a = double.Parse(x[0], CultureInfo.InvariantCulture);
    double b = double.Parse(x[1], CultureInfo.InvariantCulture);
    double c = double.Parse(x[2], CultureInfo.InvariantCulture);


    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

}