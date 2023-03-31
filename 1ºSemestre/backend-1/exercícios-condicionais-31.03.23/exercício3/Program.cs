Console.WriteLine($"Qual o raio da circunferência ? ");
float raio = float.Parse(Console.ReadLine()!);

float area = (Math.PI) * (Math.Pow(raio, 2));

Console.WriteLine($"{area}");
