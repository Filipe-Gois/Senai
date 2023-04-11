// receber 5 números inteiros e exibir seu dobro ao final
int[] numero = new int[5];


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número:");
    numero[i] = int.Parse(Console.ReadLine()!);
    
}

foreach (int numeros in numero)
{
    Console.WriteLine($"O dobro de {numeros} é: {numeros * 2}");
    
}

