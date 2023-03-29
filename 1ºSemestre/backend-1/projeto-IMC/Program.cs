// See https://aka.ms/new-console-template for more information

// Crie um programa para calcular o imc de uma pessoa
// Entrada: nome, idade, peso, altura.
// processamento> peso dividido po altura ao quadrado

// Entrada

Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"

-----------------------
|   Programa para     |
|   Calcular IMC      |
-----------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome}");

Console.WriteLine($"Informe o peso do paciente ");
float peso = float.Parse(Console.ReadLine());

// só exemplo

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));

Console.WriteLine($"O paciente {nome} tem IMC igual a: {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();










