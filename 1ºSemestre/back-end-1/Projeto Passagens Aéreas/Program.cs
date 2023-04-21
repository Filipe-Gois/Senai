
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

string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
string senha = "123456";
string opcoes3;
int i = 0;
string sn = "";

static string Login(string senha)
{
    do
    {


        Console.WriteLine($"Insira sua senha:");
        senha = Console.ReadLine()!;

        if (senha == "123456")
        {
            Console.WriteLine($"Login bem sucedido. Bem-vindo.");

        }

    }
    while (senha != "123456");
    return "";
}


Console.WriteLine($"Olá, informe seu usuário:");
string usuario = Console.ReadLine()!;

Login(senha);

do
{


    Console.WriteLine(@$" 
    1- Cadastrar passagem
    2- Listar Passagens
    0- Sair");

    opcoes3 = Console.ReadLine()!;




    switch (opcoes3)
    {

        case "1":
            do
            {
                Console.WriteLine($"Cadastro de passagem:");
                Console.WriteLine();

                Console.WriteLine($"Olá, informe seu nome");
                nomes[i] = Console.ReadLine()!;

                Console.WriteLine($"Insira a origem do voo:");
                origem[i] = Console.ReadLine()!;

                Console.WriteLine($"Insira o destino do voo:");
                destino[i] = Console.ReadLine()!;

                Console.WriteLine($"Insira a data do voo:");
                data[i] = Console.ReadLine()!;

                Console.WriteLine(@$"
        Cadastro concluído.
        
        Deseja cadastrar uma nova passagem ? S/N");
                sn = Console.ReadLine()!.ToUpper();

                if (sn == "S")
                {
                    i++;
                }

            } while (sn == "S");

            break;

        case "2":

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(@$"
       {i + 1}º cadastrado:

       Nome: {nomes[i]}
       Origem do voo: {origem[i]}
       Destino do voo: {destino[i]}
       Data do voo: {data[i]} ");

            }
            break;

        case "0":
            Console.WriteLine($"Obrigado por comprar conosco!");
            break;

        default:

            break;
    }
    }while (opcoes3 != "0");
    









