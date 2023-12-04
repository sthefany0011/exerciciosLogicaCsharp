// See https://aka.ms/new-console-template for more information

using System.Globalization;

int numeroDoFuncionario, numeroDeHorasTrabalhadas;
double valorPorHora, salario;

Console.WriteLine("Numero do Funcionário:");
numeroDoFuncionario = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidades de horas Trabalhadas?");
numeroDeHorasTrabalhadas=int.Parse( Console.ReadLine());

Console.WriteLine("Valor da hora?");
valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salario = (double)numeroDeHorasTrabalhadas * valorPorHora;

Console.WriteLine("NUMBER = " + numeroDoFuncionario);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));