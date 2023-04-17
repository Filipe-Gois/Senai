
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros. ok

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456. ok
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem ok
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login). ok

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N). ok

// registrar 5 passageiros:
// nome
// origem
// destino
// data do voo

// usuário só pode acessar menu se senha for 123456 

// menu:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// ao final, exibir mensagem se quer cadastrar nova passagem, voltando ao menu.

int senha;

static void menu()
{
    Console.WriteLine(@$" 
    1- Cadastrar passagem
    2- Listar Passagens
    0- Sair");

    char opcao = char.Parse(Console.ReadLine()!);

    while ((opcao != '1') && (opcao != '2') && (opcao != '0'))
    {
        Console.WriteLine($"Insira credenciais válidas:");
        opcao = char.Parse(Console.ReadLine()!);

    }


    switch (opcao)
    {
        case '1':
            cadastro();
            break;

        case '2':

            break;

        default:

            break;
    }

}



static void cadastro()
{

    string[] passageiros = new string[1];

    for (int i = 0; i < passageiros.Length; i++)
    {

        string[] nomes = new string[5];
        string[] origem = new string[5];
        string[] destino = new string[5];
        int[] data = new int[5];

        Console.WriteLine($"Cadastro de passagem:");
        Console.WriteLine();


        Console.WriteLine($"Olá, informe seu nome");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a origem do voo:");
        origem[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira o destino do voo:");
        destino[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a data do voo:");
        data[i] = int.Parse(Console.ReadLine()!);

        Console.WriteLine(@$"
        Cadastro concluído.
        
        Deseja cadastrar uma nova passagem ? S/N");
        char sn = char.Parse(Console.ReadLine()!.ToUpper());



        if (sn == 'S')
        {
            cadastro();
        }
        else
        {
            menu();
        }

        while (sn != 'S' && sn != 'N')
        {
            Console.WriteLine(@$"
            Insira um valor válido.
            
            Deseja cadastrar uma nova passagem ? S/N");
            char opcao1 = char.Parse(Console.ReadLine()!);
            

        }



    }

    return;
}


Console.WriteLine($"Olá, informe seu usuário:");
string usuario = Console.ReadLine()!;

Console.WriteLine($"Olá, informe sua senha:");
senha = int.Parse(Console.ReadLine()!);

while (senha != 123456)
{
    Console.WriteLine($"Senha inválida, insira a correta:");
    senha = int.Parse(Console.ReadLine()!);

}

Console.WriteLine($"Login bem sucedido");

menu();