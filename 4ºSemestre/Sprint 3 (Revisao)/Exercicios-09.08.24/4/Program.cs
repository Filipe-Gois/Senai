// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.


int nInformado = 0;

Console.WriteLine($"Informe um numero:");
nInformado = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($" {nInformado} x {i}  = {i * nInformado}");
}
