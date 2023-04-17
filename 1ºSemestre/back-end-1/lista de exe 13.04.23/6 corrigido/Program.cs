
//declarando um array
string[] nomes = new string[3];

bool nomeEncontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine()!;    
}

Console.WriteLine($"Informe o nome a ser buscado: ");
string nomeBuscado = Console.ReadLine()!;

//processamento
foreach (string nome in nomes)
{
    if (nome == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}

//saída - exibir
if (nomeEncontrado == true)
{
    Console.WriteLine($"ACHEI");    
}
else
{
    Console.WriteLine($"NÃO ACHEI");    
}

string resultadoBusca = nomeEncontrado == true ? "ACHEI" : "Não ACHEI";
Console.WriteLine(resultadoBusca);

Console.WriteLine(nomeEncontrado ? "ACHEI" : "Não ACHEI");