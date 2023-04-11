string[] carros = new string[3];
// º
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do {i + 1}º carro:");
    carros[i] = Console.ReadLine()!;

}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"o {i + 1}º carro é: {carros[i]}");
        
}