using System.Globalization;
using classe_estatica;

string opcao;
float valor;


Console.WriteLine($"Bem-vindo!");

do
{
    Console.WriteLine(@$"
Selecione a opção que deseja:

[1] - Dolar para Real
[2] - Real para Dolar
[3] - Sair");

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Insira o valor:");
            valor = int.Parse(Console.ReadLine()!);
            float resultado = Conversao.Dolar(valor);
            Console.WriteLine($"{resultado:C2}");
            break;

        case "2":
            Console.WriteLine($"Insira o valor:");
            valor = int.Parse(Console.ReadLine()!);
            float resultado2 = Conversao.Real(valor);
            Console.WriteLine($"{resultado2.ToString("C", new CultureInfo("en-US"))}");
            break;

        default:
            break;
    }
} while (opcao != "3");