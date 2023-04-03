int respostasPositivas = 0;

string resposta = "";

List<string> perguntas = new List<string> {
    "Você telefonou para a vítima? ",
    "Você esteve no local do crime? ",
    "Você mora perto da vítima? ",
    "Você devia para a vítima? ",
    "Você já trabalhou com a vítima? "
};

foreach (string pergunta in perguntas)
{
    Console.WriteLine($"{pergunta} [sim/não] ");
    resposta = Console.ReadLine()! .ToUpper();

    if (resposta == "SIM") 
    {
        respostasPositivas++;
    }
}

switch (respostasPositivas) {
    case 2:
        Console.WriteLine($"Você é considerado Suspeito.");
        break;
    case 3 or 4:
        Console.WriteLine($"Você é considerado Cúmplice.");
        break;
    case 5:
        Console.WriteLine($"Você é considerado Culpado.");
        break;
    default:
        Console.WriteLine($"Você é considerado Inocente.");
        break;
        }