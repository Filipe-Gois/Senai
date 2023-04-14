// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

// ler nome
// ler quantidade adquirida
// ler o preço unitário

// calcular e escrever o total
// calcular e escrever o desconto
// calcular e escrever o total a pagar

// escrever o total
// escrever o desconto
// escrever o total a pagar(preço com desconto)

Console.WriteLine($"Olá, infrme o produto adquirido:");
string nomeProduto = Console.ReadLine()!;

Console.WriteLine($"Informe a quantidade:");
int quantProduto = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o valor unitário do produto:");
float punitProduto = float.Parse(Console.ReadLine()!);

if (quantProduto <= 5)
{
    float total = quantProduto * punitProduto;

    float desc = quantProduto * (punitProduto * 0.98f);

    float totalp = total - desc;

    Console.WriteLine($"Valor sem desconto: {Math.Round(total,2)}. Valor com desconto: {Math.Round(totalp,2)}. Desconto aplicado: {Math.Round(desc,2)}");

}

else if ((quantProduto > 5) && (quantProduto <= 10))
{
    float total = quantProduto * punitProduto;

    float totalp = quantProduto * (punitProduto * 0.97f);

    float desc = total - totalp;

    Console.WriteLine($"Valor sem desconto: {Math.Round(total,2)}. Valor com desconto: {Math.Round(totalp,2)}. Desconto aplicado: {Math.Round(desc,2)}");
}

else
{
    float total = quantProduto * punitProduto;

    float desc = quantProduto * (punitProduto * 0.95f);

    float totalp = total - desc;

    Console.WriteLine($"Valor sem desconto: {Math.Round(total,2)}. Valor com desconto: {Math.Round(totalp,2)}. Desconto aplicado: {Math.Round(desc,2)}");
}