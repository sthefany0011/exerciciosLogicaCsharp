using System.Globalization;

Console.WriteLine("Digite os dois valores inteiros");

int cod, qts;
double valor;

String[] valores = Console.ReadLine().Split(' ');

cod = int.Parse(valores[0]);
qts = int.Parse(valores[1], CultureInfo.InvariantCulture);


if(cod == 1)
{
    valor = (double)qts * 4.00;
}
else if (cod == 2)
{
    valor = (double)qts * 4.50;
}
else if (cod == 3)
{
    valor = (double)qts * 5.00;
}
else if (cod == 4)
{
    valor = (double)qts * 2.00;
}
else
{
    valor = (double)qts * 1.50;
}

Console.WriteLine("Total: R$ " + valor.ToString("f2",CultureInfo.InvariantCulture));