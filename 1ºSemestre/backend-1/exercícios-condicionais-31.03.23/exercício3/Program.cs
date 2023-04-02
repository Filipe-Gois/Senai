Console.WriteLine($"Qual o raio da circunferência ? ");
float raio = float.Parse(Console.ReadLine()!);

float diametro = (raio * 2);

double comprimento =  2 * Math.PI * raio;

double area = Math.PI * (Math.Pow(raio, 2));


Console.WriteLine($"Diâmetro: {diametro} Comprimento: {comprimento} Área: {area}.");

