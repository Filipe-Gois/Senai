// Escreva um algorcontadortmo que contadormprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

// imprimir tabuada (de 1 a 10)

for (int contador = 1; contador <= 10; contador++)
{
    for (int i = 1; i <= 10; i++)
    {
        int resultado = contador * i;
        Console.WriteLine($"{contador} X {i} = {resultado}");
    }
    Console.WriteLine();
    
}