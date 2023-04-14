// Estruturas de repetição:
// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

// ler 10 valores
// exibir número maior
// exibir número menor

int[] numeros = new int[10];


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Olá, informe o {i + 1}º número.");
    numeros[i] = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Maior número: {numeros.Max()}. Menor número: {numeros.Min()}");
