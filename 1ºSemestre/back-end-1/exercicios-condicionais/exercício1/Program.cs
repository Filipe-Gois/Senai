Console.WriteLine($"Informe seu salário:");
float salario = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Informe o gasto mensal:");
float gasto = float.Parse (Console.ReadLine()!);

float total = salario - gasto;

if (salario > gasto)
{Console.WriteLine($"Gastos dentro do orçamento");
}

else
{Console.WriteLine($"Orçamento estourado");
}





