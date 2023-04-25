// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using exe_calculadora;
Calculadora operacoes = new Calculadora();

string opcao;
do
{
    Console.WriteLine(@$"
Olá, informe a operação que deseja:
[1] - Adição
[2] - Subtração
[3] - Multiplicação
[4] - Divisão");

    opcao = Console.ReadLine()!;
} while ((opcao != "1") && (opcao != "2") && (opcao != "3") && (opcao != "4"));


// for (int i = 0; i <n.Length; i++)
// {
//     Console.WriteLine($"Informe o {i+1}º número:");
//     n[i] = float.Parse(Console.ReadLine()!);
// }

Console.WriteLine($"Informe o primeiro número:");
operacoes.n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo número:");
operacoes.n2 = float.Parse(Console.ReadLine()!);


switch (opcao)
{
    case "1":

        operacoes.Somar(operacoes.n1, operacoes.n2);

        break;

    case "2":
        operacoes.Subtrair(operacoes.n1, operacoes.n2);
        break;

    case "3":
        operacoes.Multiplicar(operacoes.n1, operacoes.n2);
        break;

    case "4":
        operacoes.Dividir(operacoes.n1, operacoes.n2);
        break;
    default:
        break;
}

