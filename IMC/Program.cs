using IMC;

Calculo_imc imc = new Calculo_imc();


Console.WriteLine($"Olá, informe seu nome:");
imc.nome = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade:");
imc.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu peso:");
imc.peso = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua altura:");
imc.altura = double.Parse(Console.ReadLine()!);



Console.WriteLine(@$"

Nome do paciente: {imc.nome}
Idade: {imc.idade}
Peso: {imc.peso}
Altura: {imc.altura}");



Console.WriteLine(imc.CalcularImc());
