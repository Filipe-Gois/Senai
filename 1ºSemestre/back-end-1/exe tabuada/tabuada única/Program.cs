int numero = 0;
int contador = 0;



Console.WriteLine($"Olá, informe o número que deseja saber a tabuada:");
 numero = int.Parse(Console.ReadLine()!);

for (contador = 1; contador <= 10; contador++)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} X {contador} = {resultado}");
    }
   
    



