// 2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar.

// No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.

// a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?

// b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.

// c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!

// 1)receber quantidade em G de café "float",, valor de 10g caso n selecione nd

using _2;
MaquinaCafe Cafe = new MaquinaCafe();

Cafe.AcucarDisponivel = 100;
string Opcao = "";

do
{
    do
    {
        Console.WriteLine(@$"
            Olá, informe a opção desejada:
            [1] - Acrescentar açúcar
            [2] - Usar a medida padrão
            [3] - Sair
            
            Bebida atual: {Cafe.BebidaAtual}
            Açúcar disponível: {Cafe.AcucarDisponivel}g");

        Opcao = Console.ReadLine()!;

    } while (Opcao != "1" && Opcao != "2" && Opcao != "3");

    switch (Opcao)
    {
        case "1":
            Cafe.FazerCafe();
            break;

        case "2":
            break;

        case "3":
            Console.WriteLine($"Compra cancelada.");
            break;

        default:
            break;
    }
} while (Opcao != "3");