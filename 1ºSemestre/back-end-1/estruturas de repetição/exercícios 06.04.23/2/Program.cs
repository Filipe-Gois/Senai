Console.WriteLine($"Olá, insira suas credenciais.");

Console.WriteLine($"Insira seu nome:");
string nome = Console.ReadLine()!;

Console.WriteLine($"Insira sua senha:");
string senha = Console.ReadLine()!;

while (nome == senha)
{
    Console.WriteLine($"Por favor, insira credenciais válidas");
    Console.WriteLine($"Insira seu nome:");
    nome = Console.ReadLine()!;
    Console.WriteLine($"Insira sua senha:");
    senha = Console.ReadLine()!;
}

Console.WriteLine($"Credenciais aceitas.");


