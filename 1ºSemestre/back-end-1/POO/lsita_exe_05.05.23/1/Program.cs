// 1)criar classe "elevador": ok
// andar atual = 0 ok
// total de andares do predio (desconsiderar térreo) ok
// capacidade do elevador ok
// quantas pessoas estão presentes nele ok
// 1.1)métodos:
// inicializa: parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio) ok
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver 
// espaço); ok
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele); ok
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using _1;

Elevador novo = new Elevador();

novo.TotalAndares = 10;
novo.CapacidadeElevador = 20;
novo.PessoasPresentes = 0;
string opcao;

novo.inicializa();
novo.Entrar();

do{
Console.WriteLine(@$"
O que deseja fazer ?
[1] - Subir
[2] - Descer
[3] - Sair");

opcao = Console.ReadLine()!.ToUpper();

switch (opcao)
{
    case "1":
    novo.Subir();
    break;

    case "2":
    novo.Descer();
    break;

    case "3":
    novo.Sair();
    break;


    default:
    Console.WriteLine($"Opção inválida.");
    break;
}
}while (opcao != "3");