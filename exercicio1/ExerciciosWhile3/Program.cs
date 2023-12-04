// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe o combustivel:");

int cod = int.Parse(Console.ReadLine());
int gasolina=0, alcool=0, diesel = 0;


while(cod!=4)
{
    if (cod == 1)
    {
        gasolina++;
    }
    else if(cod == 2)
    {
        alcool++;
    }
    else if (cod == 3)
    {
        diesel++;
    }
    cod = int.Parse(Console.ReadLine()); 

}
Console.WriteLine("MUITO Obrigado(a)");
Console.WriteLine("Alcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " + diesel);