// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

int a=0; int b=0;
for(int i = 1; i <= n; i++)
{
    int x= int.Parse(Console.ReadLine());
    if (x>=10 && x<=20)
    {
        a++;

    }
    else
    {
        b++;
    }
}

Console.WriteLine(a+" in");
Console.WriteLine(b + " out");
