// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

// imprimir tabuada (de 1 a 10)

Console.WriteLine($"Olá.");

for (int contador = 1; contador <= 10; contador++)
{

    Console.WriteLine($"");
    
    for (int numero = 1; numero <= 10; numero++)
    {
        int resultado = contador * numero;

        Console.WriteLine($"{contador} x {numero} = {resultado}");
        
    }
}