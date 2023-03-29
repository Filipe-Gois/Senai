// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"

                                         --------------------------
                                         |     Programa para       |
                                         |     Calcular idade      |
                                         --------------------------
");
Console.ResetColor();

var dataEntrada = DateTime.Now;

Console.WriteLine(dataEntrada);

Console.WriteLine($"Digite o ano em que você nasceu:");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mês em que você nasceu:");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o dia em que você nasceu:");
int dia = int.Parse(Console.ReadLine());

int idadeAnos = dataEntrada.Year-ano;
int idadeSem = idadeAnos*12*4;

Console.WriteLine($"{idadeAnos} é sua idade em anos, tendo {idadeSem} semanas de vida.");






