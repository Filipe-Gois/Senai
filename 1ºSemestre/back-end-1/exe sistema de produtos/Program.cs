// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome ok
// float Preco ok
// bool Promocao (se está em promoção ou não) ok

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto ok
// ListarProdutos
// MostrarMenu ok
// Crie função(ões) para otimizar o código. ok
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade. ok


// atribuir nome de 10 produtos ok
// atribuir preço de 10 produtos ok
// Dizer se está em promo (true or false)

// tela para cadastrar produto ok
// tela para listar produtos ok
// menu ok

string[] nome = new string[10];
float[] preco = new float[10];
bool[] promo = new bool[10];
string promoSoun = "";
string opcao012;
int i = 0;
string soun;


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
    } while (senha != "123456");




    return "";
}

Console.WriteLine($"Olá, informe seu usuário");
Console.ReadLine();

Login("senha");

do
{
    Console.WriteLine($"Menu de opções:");

    Console.WriteLine(@$"
[1] - Cadastrar produto.
[2] - Listar produtos cadastrados.
[3] - Sair do programa.");

    opcao012 = Console.ReadLine()!;

    switch (opcao012)
    {
        case "1":

            do
            {
                Console.WriteLine($"Informe o nome do produto.");
                nome[i] = Console.ReadLine()!;

                Console.WriteLine($"Informe o preço do produto:");
                preco[i] = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"O produto está em promoção ? S/N");
                promoSoun = Console.ReadLine()!.ToUpper();

                if (promoSoun == "S")
                {
                    promo[i] = true;



                }
                else
                {
                    promo[i] = false;



                }




                Console.WriteLine($"Deseja cadastrar algo mais ? S/N");
                soun = Console.ReadLine()!.ToUpper();
                if (soun == "S")
                {
                    i++;
                }

            } while (soun == "S");
            Console.WriteLine($"Produtos cadastrados.");
            break;

        case "2":

            Console.WriteLine($"Produtos cadastrados:");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º produto:");
                Console.WriteLine($"Nome: {nome[i]}.");
                Console.WriteLine($"Preço: {preco[i]}.");
                if (promo[i] == true)
                {
                    Console.WriteLine($"Produto em promoção.");

                }
                else
                {
                    Console.WriteLine($"O produto não está em promoção.");

                }
                Console.WriteLine();

            
            }
            break;

        case "3":
            Console.WriteLine($"Programa finalizado.");
            break;

        default:
            break;
    }
} while (opcao012 != "3");
