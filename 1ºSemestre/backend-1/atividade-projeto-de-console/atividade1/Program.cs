// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"

                                         --------------------------
                                         |     Programa para       |
                                         |     Calcular idade      |
                                         --------------------------
");
Console.ResetColor();

Console.WriteLine($"Insira sua idade em anos: ");
int idadeAnos = int.Parse(Console.ReadLine()!);



int idadeMeses = idadeAnos*12;
int idadeDias = idadeMeses*30;
int idadeHoras = idadeDias*24;
int idadeMinutos = idadeHoras*60;


Console.WriteLine($"{idadeMeses} meses {idadeDias} dias {idadeHoras} horas {idadeMinutos} minutos");
