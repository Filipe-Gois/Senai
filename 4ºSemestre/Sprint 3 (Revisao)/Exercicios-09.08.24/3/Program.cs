// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

int somaTotal = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        somaTotal += numeros[i];
    }
}
Console.WriteLine($"O total é: {somaTotal}");
