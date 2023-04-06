Console.WriteLine($"Insira um número inteiro  e descubra sua tabuada.");
int num = int.Parse(Console.ReadLine()!);

for (int contador = 1; contador <= 10; contador++)
{
    int formula = num * contador;
    Console.WriteLine($"{num} x {contador} = {formula}");
    
}
