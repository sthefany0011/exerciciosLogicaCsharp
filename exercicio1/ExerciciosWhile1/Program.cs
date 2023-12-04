


Console.WriteLine("Informe a senha:");
int senha =int.Parse(Console.ReadLine());

while (senha != 2002){
    Console.WriteLine("Senha Invalida, digite novamente");
    senha=int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");
