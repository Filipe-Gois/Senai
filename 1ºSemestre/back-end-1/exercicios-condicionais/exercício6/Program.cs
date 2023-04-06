Console.WriteLine($"Olá, informe sua média bimestral:");
float media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua frequência de acompanhamento das aulas:");
float freq = float.Parse(Console.ReadLine()!);

if ((media >= 7) && (freq >= 75))
{
    Console.WriteLine($"Parabéns, você foi aprovado.");
    
}

else if (freq < 75)
{
    Console.WriteLine($"Sinto muito, você está reprovado.");
    
}

else if ((freq >= 75) && (media >= 3) && (media < 7))
{
    Console.WriteLine($"Você será encaminhado para a recuperação. Estude!!");
    
}