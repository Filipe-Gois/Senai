Console.WriteLine($"Insira sua senha");
int senha = int.Parse(Console.ReadLine()!);

if (senha == 1234)
{
Console.WriteLine($"Acesso permitido. Bem-vindo.");
}

else 
{
    Console.WriteLine($"Acesso negado.");
    
}