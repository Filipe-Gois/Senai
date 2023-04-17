// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// ler nome de 10 pessoas
// buscar o nome
// "achei" caso nome esteja na lista
// "não achei" caso nome não esteja na lista

bool nomeEncontrado = false;
string nomeBuscado;
string[] nomes = new string[3];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Olá, informe o {i + 1}º nome:");
    nomes[i] = Console.ReadLine()!;
    
}

Console.WriteLine($"Informe o nome a ser buscado:");
nomeBuscado = Console.ReadLine()!;

foreach (string item in nomes)
{
    if (item == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}


Console.WriteLine(nomeEncontrado ? "Achei" : "Não achei.");



