string senha = "";
Console.WriteLine("Digite a senha: ");
senha = Console.ReadLine();
while(senha != "2018")
{
    Console.WriteLine("Digite a senha: ");
    senha = Console.ReadLine();
    if(senha != "2018")
    {
        Console.WriteLine("Senha Inválida");
    }
    else
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
}