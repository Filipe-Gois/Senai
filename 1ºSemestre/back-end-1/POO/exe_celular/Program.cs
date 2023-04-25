// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). ok

// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.

// Só será possível executar tais métodos se o celular estiver ligado.

// Envie o link do repositório como entrega desta atividade.

using exe_celular;

Celular trab = new Celular();

string opcao;
string opcaoMsg;

Console.WriteLine($"Olá, deseja ligar o celular ?");
trab.LigarCell = Console.ReadLine()!.ToUpper();

while (trab.LigarCell != "S")
{
    Console.WriteLine($"Ligue o dispositivo.");
    trab.LigarCell = Console.ReadLine()!.ToUpper();
}

if (trab.LigarCell == "S")
{
    trab.Ligado = true;
}


if (trab.Ligado == true)
{
    do
    {
        Console.WriteLine(@$"

[2] - Fazer ligação;
[3] - Enviar SMS;
[4] - Desligar dispositivo.");

        opcao = Console.ReadLine()!;

        switch (opcao)
        {

            case "2":
                trab.Ligacao();
                break;

            case "3":
                do
                {
                    Console.WriteLine(@$"
            Enviar mensagem:
            
            1) Pâmela;
            2) Erick;
            3) Filipe.
            ");
                    opcaoMsg = Console.ReadLine()!;
                } while (opcaoMsg != "1" && opcaoMsg != "2" && opcaoMsg != "3");

                switch (opcaoMsg)
                {
                    case "1":
                        trab.Mensagem();
                        break;

                    case "2":
                        trab.Mensagem();
                        break;

                    case "3":
                        trab.Mensagem();
                        break;

                    case "4":
                        trab.Mensagem();
                        break;

                    default:
                        Console.WriteLine($"Contato não encontrado.");
                        break;
                }


                break;

            case "4":
                trab.Desligar();
                break;

            default:
                break;
        }

    } while (opcao != "4");

}



