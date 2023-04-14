// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
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


// álcool <= 20 == 3% desconto litro
// álcool > 20 == 5% desconto por litro

// gasolina <= 20 == 4% desconto por litro
// gasolina > 20 == 6% desconto por litro

// 1) ler o numero de litro vendidos e o tipo do combustivel
// 2) calcular valor a ser pago pelo cliente g=R$ 5,30  a=R$ 4,90




const float litroA = 4.9f;
const float litroG = 5.3f;

int litroAq = 0;
int litroGq = 0;
double resultadoA = 0;
double resultadoAelse = 0;
double resultadoG = 0;
double resultadoGelse = 0;
double litroinfo;

Console.WriteLine(@$"
Olá, informe o tipo do combustível:
(A) - Álcool 
R$ 4,90

(G) - Gasolina 
R$ 5,30");

char combus = char.Parse(Console.ReadLine()!.ToUpper());

while ((combus != 'A') && (combus != 'G'))
{
    Console.WriteLine($"Por favor, insira um valor válido.");
    combus = char.Parse(Console.ReadLine()!.ToUpper());
}

switch (combus)
{
    case 'A':

        Console.WriteLine($"Quantos litros você deseja ?");
        litroinfo = int.Parse(Console.ReadLine()!);

        if (litroAq <= 20)
        {
            resultadoA = (litroinfo * 0.97) *litroA;

            Console.WriteLine($"Total a pagar em {litroinfo} litros: R${Math.Round(resultadoA, 2)}.");

        }
        else
        {
            resultadoAelse = (litroinfo * 0.95) *litroA;
            Console.WriteLine($"Total a pagar em {litroinfo} litros: R${Math.Round(resultadoAelse, 2)}.");
            
        }

        break;

    case 'G':

        Console.WriteLine($"Quantos litros você deseja ?");
        litroinfo = int.Parse(Console.ReadLine()!);

        if (litroGq <= 20)
        {
            resultadoG = (litroinfo * 0.96) * litroG;
            Console.WriteLine($"Total a pagar em {litroinfo} litros: R${Math.Round(resultadoG, 2)}.");
        }

        else
        {
            resultadoGelse = (litroinfo * 0.94) * litroG;
            Console.WriteLine($"Total a pagar em {litroinfo} litros: R${Math.Round(resultadoGelse, 2)}.");
        }
        break;
    default:
        break;
}


// Console.WriteLine($"{numero.Contains()}");
