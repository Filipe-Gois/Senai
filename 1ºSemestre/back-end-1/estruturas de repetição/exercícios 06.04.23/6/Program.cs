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