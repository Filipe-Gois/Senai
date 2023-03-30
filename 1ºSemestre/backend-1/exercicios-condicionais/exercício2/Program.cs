Console.WriteLine($"Informe o saldo de gols de cada time:");

Console.WriteLine($"Saldo de gols do time 1:");
int time1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Saldo de gols do time 2:");
int time2 = int.Parse(Console.ReadLine()!);

if (time1 == time2)
{ 
    Console.WriteLine($"Nem pra um, nem pra outro, tivemos um empate.");
}


else if (time1 > time2)
{
    Console.WriteLine($"O time 1 ganhou");
}


else 

{
    Console.WriteLine($"O time 2 ganhou");
}







