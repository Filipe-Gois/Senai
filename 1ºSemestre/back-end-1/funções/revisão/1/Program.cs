// //  não obrigatórios:(local  tipo). retorno nome    parâmetros
//     public static void Executar(string tete)
// {

// }

// static int Calcular()
// {
//     int a = 1;
//     int b = 7;
//     int c = a + b;
    
//     return c;
    
// }


// Console.WriteLine(Calcular());
// Console.WriteLine(Calcular());
// Console.WriteLine(Calcular());


// função para exobor tabuada

static void Tabuada(int numero)
{   
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
    }
    Console.WriteLine();
}


Tabuada(144);
Tabuada(14);
Tabuada(3);
Tabuada(7);

