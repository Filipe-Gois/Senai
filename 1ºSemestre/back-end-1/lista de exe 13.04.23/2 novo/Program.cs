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


static float precofinalalcool(float quant, float preco)
{
    if (quant <= 20)
    {
        return (quant * preco) * 0.97f;
    }
    else 
    {
        return (quant * preco) * 0.95f;
    }
}

static float precofinalgasosa (float quant, float preco)
{
    if (quant <= 20)
    {
        return (quant )
    }
}