﻿
Console.WriteLine("Digite um valor para X:");
    int x = int.Parse(Console.ReadLine());

for(int i = 1; i <= x; i++)
{
    if (i%2 !=0)
    {
        Console.WriteLine(i);
    }
}