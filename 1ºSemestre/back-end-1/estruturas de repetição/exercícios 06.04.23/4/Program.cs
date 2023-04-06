int contador;
int contadorSexof = 0;
int contadorSfsim = 0;

Console.WriteLine($"Bem-vindo ao questionário de nossa empresa.");

for (contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"Informe seu sexo: (m/f)");
    char sexo = char.Parse(Console.ReadLine()!.ToLower());
    if (sexo == 'f')
    {
        contadorSexof++;
    }


Console.WriteLine($"{sexo}");
    Console.WriteLine($"Você gostou do produto oferecido ? (s/n)");
    char resp = char.Parse(Console.ReadLine()!.ToLower());


    {

    }
}


// int contador;
// int contadorSexof = 0;
// int contadorSexom = 0;
// int contadorSFsim = 0;

// for (contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"Informe seu sexo: (m) (f)");
//     char sexo = char.Parse(Console.ReadLine()!);
//         if (sexo == 'f')
//         {
//             contadorSexof++;
//         }
//         else if (sexo == 'm')
//         {
//             contadorSexom++;
//         }

//     Console.WriteLine($"Você gostou do produto lançado? sim/nao");
//     string opiniao = Console.ReadLine()!;
//         if (true)
//         {
            
//         }
        
        
//         if ((sexo == 'f') && (opiniao == "sim"))
//         {
//             contadorSFsim++;
//         }


// }

// Console.WriteLine($"Essa é a quantidade de mulheres que responderam a pesquisa: {contadorSexof}");
// Console.WriteLine($"Essa é a quantidade de homens que responderam a pesquisa: {contadorSexom}");
// Console.WriteLine($"Essa é a quantidade de mulheres que responderam que gostaram: {contadorSFsim}");


