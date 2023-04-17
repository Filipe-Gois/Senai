// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

// ler 15 números e armazenar
// descrever os números na ordem inversa ao final

int[] numeros = new int[15];

Console.WriteLine($"Olá, informe os 15 números:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"{i+1}º número");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = numeros.Length; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
    
}
