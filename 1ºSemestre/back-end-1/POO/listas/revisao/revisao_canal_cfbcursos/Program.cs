

List<string> Carros = new List<string>();
string[] Carros2 = new string[10];
// alterar o "Carros2" para List, caso queira testar os outros métodos

string? carro;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do carro:");
    carro = Console.ReadLine()!;
    Carros.Add(carro);
}





// adicionando manualmente ---
Carros.Add("Golf");

// adiciona todos os itens de "Carros" em "Carros2" ---
// Carros2.AddRange(Carros);

// ---

// obrigatório usar array
// copyTo: você especifica a partir de qual posição deve ser exibido, no caso, é a a partir da segunda
Carros.CopyTo(Carros2, 2);

foreach (var item in Carros2)
{
    Console.WriteLine($"Carro: {item}");
    
}

// ---


// limpa todos os elementos da lista ---
// Carros.Clear();

// ---


// pegando todos os itens da lista e exibindo com o Console.WriteLine ---
// foreach (var item in Carros)
// {
//     Console.WriteLine($"Esse é o carros2");

//     Console.WriteLine($"Carro: {item}");

// }


// ---


// se a lista "Carros" tem algo com o nome "Gol", executar o IF ---
// if (Carros.Contains("Gol"))
// {
//     Console.WriteLine($"Carro encontrado");
    
// }
// else{
//     Console.WriteLine($"Carro não encontrado");
    
// }


// ---

