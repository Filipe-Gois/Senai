// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades: ok

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. ok 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade ok
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade ok
// outros casos a mensalidade será integral ok
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using cadastro_alunos;
aluno classe = new aluno();

string opcao;

Console.WriteLine($"Olá, informe seu nome:");
classe.nome = Console.ReadLine()!;

Console.WriteLine($"Informe seu curso:");
classe.curso = Console.ReadLine()!;


Console.WriteLine($"Informe sua idade:");
classe.idade = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Informe seu RG:");
classe.rg = Console.ReadLine()!;

Console.WriteLine($"Você é bolsista ? S/N");
classe.bolsa = Console.ReadLine()!.ToUpper();

if (classe.bolsa == "S")
{
    classe.bolsa1 = true;
}

Console.WriteLine($"Informe sua média final:");
classe.mediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o quanto você paga de mensalidade:");
classe.mensalidade = float.Parse(Console.ReadLine()!);


do
{
    Console.WriteLine(@$"
[0] - Sair;
[1] - Visualizar média;
[2] - Visualizar o valor da mensalidade.");

    opcao = Console.ReadLine()!;





    switch (opcao)
    {
        case "0":
            Console.WriteLine($"Programa finalizado.");
            break;

        case "1":
            Console.WriteLine($"Sua média foi de {classe.mediaFinal} pontos.");

            break;

        case "2":
            classe.calcularBolsa(classe.mediaFinal);
            break;

        default:
            break;
    }

} while (opcao != "0");

