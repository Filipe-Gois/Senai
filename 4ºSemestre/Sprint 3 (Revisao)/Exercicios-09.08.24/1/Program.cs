// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

Console.WriteLine($"Informe um numero:");
int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine($"é par");
}
else
{
    Console.WriteLine($"é impar");
}
