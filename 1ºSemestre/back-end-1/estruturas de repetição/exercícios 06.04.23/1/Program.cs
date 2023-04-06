Console.WriteLine($"Olá, informe a nota da sua avaliação.");
int nota = int.Parse(Console.ReadLine()!);

while ((nota < 0) || (nota > 10))
{
    Console.WriteLine($"Por favor, insira uma nota de 0 à 10.");
    nota = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Anotado.");

