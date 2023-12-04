Console.WriteLine("Digite o horario do inicio e o horario do final do jogo:");

int  inicio , final, duracao;

String[] valores = Console.ReadLine().Split(' ');

 inicio= int.Parse(valores[0]);
final = int.Parse(valores[1]);




if(inicio < final)
{
    duracao = final - inicio;
}
else
{
    duracao = 24 - inicio + final;
}

Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");