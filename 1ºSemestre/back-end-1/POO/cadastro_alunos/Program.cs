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
aluno novoAluno = new aluno();

string opcao;

Console.WriteLine($"Olá, informe seu nome:");
novoAluno.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe seu curso:");
novoAluno.Curso = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade:");
novoAluno.Idade = Console.ReadLine()!;

Console.WriteLine($"Informe seu RG:");
novoAluno.Rg = Console.ReadLine()!;

Console.WriteLine($"Você é bolsista ? S/N");
novoAluno.Bolsa = Console.ReadLine()!.ToUpper();

if (novoAluno.Bolsa == "S")
{
    novoAluno.Bolsa1 = true;
}

Console.WriteLine($"Informe sua média final:");
novoAluno.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o quanto você paga de mensalidade:");
novoAluno.Mensalidade = float.Parse(Console.ReadLine()!);

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
            novoAluno.VerMediaFinal();
            break;

        case "2":
            novoAluno.CalcularBolsa(novoAluno.MediaFinal);
            break;

        default:
        Console.WriteLine($"Opção inválida.");
        
            break;
    }

} while (opcao != "0");

