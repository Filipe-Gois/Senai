Console.WriteLine($"Você telefonou para a vítima ? (Responda com sim ou não)");
string telefonou = Console.ReadLine() .ToUpper();



Console.WriteLine($"Você esteve no local do crime? (Responda com sim ou não)");
string esteve = Console.ReadLine() .ToUpper();

Console.WriteLine($"Você mora perto da vítima? (Responda com sim ou não)");
string mora = Console.ReadLine() .ToUpper();

Console.WriteLine($"Você devia para a vítima? (Responda com sim ou não)");
string devia = Console.ReadLine() .ToUpper();

Console.WriteLine($"Você já trabalhou com a vítima? (Responda com sim ou não)");
string trabalhou = Console.ReadLine() .ToUpper();


if ((telefonou == "NÃO") && (esteve == "NÃO") && (mora == "NÃO") && (devia == "NÃO") && (trabalhou == "NÃO"))
{
    Console.WriteLine($"Você foi considerado inocente.");
}


else if ((telefonou == "SIM") && (esteve == "SIM") && (mora == "SIM") && (devia == "SIM") && (trabalhou == "SIM"))
{
    Console.WriteLine($"Você foi considerado culpado.");
}