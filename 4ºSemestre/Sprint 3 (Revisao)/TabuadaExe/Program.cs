float numeroUsuario = 0;

Console.WriteLine($"Informe um numero:");
numeroUsuario = float.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroUsuario} X {i} = {numeroUsuario * i}");
}
