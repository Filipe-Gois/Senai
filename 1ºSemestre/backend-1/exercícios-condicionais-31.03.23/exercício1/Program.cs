Console.WriteLine($"Em que ano você nasceu ?");
int ano = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Em qual mês você nasceu ?");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Em que dia você nasceu ?");
int dia = int.Parse(Console.ReadLine()!);




if ((ano > 2013) || (mes == 0) || (mes > 12))
{
    Console.WriteLine($"Por favor, redija seu ano e mês de nascimento.");
}

else if ((ano > 2013) || (dia == 0) || (dia > 31) )
{
    Console.WriteLine($"Por favor, redija seu ano e dia de nascimento.");
    
}

else if ((mes == 0) || (mes > 12) || (dia == 0) || (dia > 31))
{
    Console.WriteLine($"Por favor, redija seu mês e dia de nascimento.");
    
}

else if ((ano > 2013) || (mes == 0) || (mes > 12) || (dia == 0) || (dia > 31))
{
Console.WriteLine($"Por favor, redija suas informações.");

}

else if (ano > 2013 )
{
    Console.WriteLine($"Data inválida. Preecha com um ano válido até 2013.");
}

else if ((mes == 0) && (mes > 12) )
{
    Console.WriteLine($"Data inválida. Preencha com um mês válido até 12.");
}

else if ((dia == 0) && (dia > 31))
{
    Console.WriteLine($"Data inválida. Preencha com um dia válido até 31.");
    
}

else
{
    Console.WriteLine($"Tudo nos conformes. Prossiga com o seu login.");
}