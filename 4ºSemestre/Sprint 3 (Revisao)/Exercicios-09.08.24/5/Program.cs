// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.

using _5;

string texto = "";

Console.WriteLine($"Informe o texto:");
texto = Console.ReadLine()!;

Dictionary<char, TotalVezesLetra> letras = [];

for (int i = 0; i < texto.Length; i++)
{
    if (letras.ContainsKey(texto[i]))
    {
        letras[texto[i]].Total++;
    }
    else
    {
        TotalVezesLetra totalVezesLetra = new() { Total = 1, Letra = texto[i] };
        letras.Add(texto[i], totalVezesLetra);
    }
}

foreach (var letra in letras)
{
    Console.WriteLine($"Letra: '{letra.Key}' apareceu {letra.Value.Total} vezes.");
}
