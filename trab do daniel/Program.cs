// calcular imc
// definir:
// nome
// idade
// peso
// altura
// resultado = imc

string nome;
double idade;
double peso;
double altura;
double resultado;

Console.WriteLine($"Olá, informe seu nome:");
nome = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade:");
idade = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu peso");
peso = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua altura:");
altura = double.Parse(Console.ReadLine()!);

resultado = peso / (Math.Pow(altura,2));

Console.WriteLine(@$"
Nome: {nome}
Idade: {idade}
Peso: {peso}
Altura: {altura}

IMC: {Math.Round(resultado, 2)}");

if (resultado < 17)
{
    Console.WriteLine($"Você está abaixo do peso.");
    
}

else if (resultado >= 17 && resultado < 18.5 )
{
    Console.WriteLine($"Você está abaixo do peso.");
    
}

else if (resultado >= 18.5 && resultado < 25)
{
    Console.WriteLine($"Seu peso está normal.");
    
}

else if (resultado >= 25 && resultado < 30)
{
    Console.WriteLine($"Você está acima do peso..");
    
}

else if (resultado >= 30 && resultado < 35)
{
    Console.WriteLine($"Obesidade I..");
    
}

else if (resultado >= 35 && resultado < 40)
{
    Console.WriteLine($"Obesidade II.");
    
}

else
{
    Console.WriteLine($"Obesidade III.");
    
}