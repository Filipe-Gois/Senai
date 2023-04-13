// Condicionais:
// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

int idadde = 0;

static int idadeVoto(int idadde)
{
    var dataEntrada = DateTime.Now;
    int idade = 0;

    Console.WriteLine($"Olá, informe o ano do seu nascimento:");
    int anoNasc = int.Parse(Console.ReadLine()!);

    idade = dataEntrada.Year - anoNasc;

    if (idade >= 16)
    {
        Console.WriteLine($"Vote conscientemente!");
        
    }

    else
    {
        Console.WriteLine($"infelizmente você não tem idade para votar.");

    }
    return 0;
}

idadeVoto(idadde);
idadeVoto(idadde);
idadeVoto(idadde);