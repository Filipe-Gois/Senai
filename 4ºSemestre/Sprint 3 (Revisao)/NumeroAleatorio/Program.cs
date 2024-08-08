//criar programa que gere um numero aleatorio entre 1 e 100.

int numeroGeradoAleatoriamente = Random.Shared.Next(1, 100);

int totalTentativas = 0;
int respostaUsuario = 0;

Console.WriteLine($"{numeroGeradoAleatoriamente}");

do
{
    Console.WriteLine($"Adivinhe o número:");
    respostaUsuario = int.Parse(Console.ReadLine()!);

    if (respostaUsuario > numeroGeradoAleatoriamente)
    {
        Console.WriteLine($"Passou um pouco!");
    }
    else
    {
        Console.WriteLine("Acrescente um pouco!");
    }

    totalTentativas++;
} while (respostaUsuario != numeroGeradoAleatoriamente);

Console.WriteLine(
    $"Isso mesmo!! O número é {numeroGeradoAleatoriamente}. Você tentou {totalTentativas} {(totalTentativas != 1 ? "vezes" : "vez")}."
);
