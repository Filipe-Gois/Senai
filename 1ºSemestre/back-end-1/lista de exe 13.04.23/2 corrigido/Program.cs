// Um posto está vendendo combustíveis com a seguinte tabela de descontos:

// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro

// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


//criar os métodos para calcular o valor do abastecimento

static float Alcool(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }
    else
    {
        return (quantidade * preco) * 0.95f;
    }
}

static float Gasolina(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }
    else
    {
        return (quantidade * preco) * 0.94f;
    }
}

//iniciar o programa

Console.WriteLine($"Boas vindas ao posto 2 carecas!");

//declarar as variáveis

float quantidadeAlcool;
float quantidadeGasolina;

const float precoAlcool = 4.90f;
const float precoGasolina = 5.30f;

float valorAbastecimento;

char opcao;

do
{
    //menu de opções
    Console.WriteLine(@$"
informe o combustível:
(A) - Álcool
(G) - Gasolina
");

    opcao = char.Parse(Console.ReadLine().ToUpper());

    switch (opcao)
    {
        case 'A':
            Console.WriteLine($"Informe a quantidade de Álcool: ");
            quantidadeAlcool = float.Parse(Console.ReadLine());

            valorAbastecimento = Alcool(quantidadeAlcool, precoAlcool);
            Console.WriteLine($"O valor do abastecimento ficou {valorAbastecimento}");
            break;
        case 'G':
            Console.WriteLine($"Informe a quantidade de Gasolina: ");
            quantidadeGasolina = float.Parse(Console.ReadLine());

            valorAbastecimento = Gasolina(quantidadeGasolina, precoGasolina);
            Console.WriteLine($"O valor do abastecimento ficou {valorAbastecimento}");
            break;
        default:
            Console.WriteLine($"Opção inválida...só Álcool e Gasolina!");
            break;
    }
} while (opcao != 'A' && opcao != 'G');