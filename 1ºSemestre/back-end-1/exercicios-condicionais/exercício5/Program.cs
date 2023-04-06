Console.WriteLine($"Insira o número de maçãs que você quer:");
int nmacas = int.Parse(Console.ReadLine()!);

if (nmacas <=11)
{
    float macas03 = nmacas * 0.3f;
    Console.WriteLine($"Ficará R$ {macas03}");
}

else if (nmacas >=12)
{
    float macas025 = nmacas * 0.25f;
    Console.WriteLine($"Ficará R$ {macas025}");
    
}
