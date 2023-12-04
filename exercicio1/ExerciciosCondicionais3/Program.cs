// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite os dois valores inteiros");

int n1, n2;

String[] valores = Console.ReadLine().Split(' ');

n1 = int.Parse(valores[0]);
n2 = int.Parse(valores[1]);

if(n1%n2 == 0||n2%n1 == 0){
    Console.WriteLine("Sao Multiplos");
}
else {
    Console.WriteLine("Nao Sao Multiplos");
}