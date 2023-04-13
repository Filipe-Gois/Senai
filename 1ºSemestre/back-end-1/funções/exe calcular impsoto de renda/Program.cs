//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda


float renda = 0;

static float impostoRenda(float renda)
{
    Console.WriteLine($"Olá, informe seu rendimento mensal:");
    float salario = float.Parse(Console.ReadLine()!);

    if (salario <= 1500)
    {
        Console.WriteLine($"Seu rendimento está isento de imposto.");
    }

    else if ((salario > 1500) && (salario <= 3500))
    {
        float rendimento80 = salario * 0.8f;
        float imposto20 = salario * 0.2f;
        Console.WriteLine($"Uma taxa de 20% será aplicada perante o rendimento de R${salario}. Valor total a ser recebido: R${rendimento80}. Total descontado: R${imposto20}.");
    }

    else if ((salario > 3500) && (salario <= 6000))
    {
        float rendimento75 = salario * 0.75f;
        float imposto25 = salario * 0.25f;
        Console.WriteLine($"Uma taxa de 25% será aplicada perante o rendimento de R${salario}. Valor total a ser recebido: R${rendimento75}. Total descontado: R${imposto25}.");
    }

    else
    {
        float rendimento65 = salario * 0.65f;
        float imposto35 = salario * 0.35f;
        Console.WriteLine($"Uma taxa de 35% será aplicada perante o rendimento de R${salario}. Valor total a ser recebido: R${rendimento65}. Total descontado: R${imposto35}.");
    }
    return 0;
}
impostoRenda(renda);
impostoRenda(renda);
impostoRenda(renda);
