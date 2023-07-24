
List<string> carros = new List<string>();

int i = 0;

List<string> carros2 = new List<string>();

string[] carros3 = new string[10];


carros.Add("Volvo");
carros.Add("Hrv");
carros.Add("Focus");
carros.Add("Argo");
carros.Add("Hrv");


// carros.Clear(); //Limpa o conteúdo da lista

foreach (var item in carros)
{
    i++;
    Console.WriteLine($"Esse é o carro {item}, na posição {i}");


}



carros2.AddRange(carros); //adiciona o conteúdo de "carros" em "carros2"

foreach (var item in carros2)
{
    i++;
    Console.WriteLine($"Esse é o carro {item}, na posição {i}");


}


Console.WriteLine(carros.Contains("Gol") ? "Tem gol na lista." : "N tem Gol na lista."); //verifica se o elemento informado existe na lista

carros2.Clear();

// -----




carros.CopyTo(carros3, 2); //copia os dados de "carros" para "carros3" a partir do índice indicado, no caso, é o 2.

foreach (var item in carros3)
{
    Console.WriteLine($"Carro: {item}");
    
}



//IndexOff: retorna o índice do elemento (se houver elementos duplicados, sempre retorna do primeiro elemento.)

string c = "Argo";
int pos = carros.IndexOf(c);
// int pos = carros.IndexOf("Argo");
Console.WriteLine($"Carro {c} está na posição {pos}");



// Insert: insere elementos na lista em uma determinada posição
carros.Insert(1, "oioi");

// LastIndexOff: retorna a posição do último elemento com o nome pesquisado
int pos2 = carros.LastIndexOf("Hrv");

Console.WriteLine($"Último HRV está na posição {pos2}");

// Remove: remove um elemento da lista pelo seu nome
carros.Remove("Argo");

// RemoveAt: remove pelo index do elemento
carros.RemoveAt(0);

// Reverse: inverte a ordem da lista
carros.Reverse();

// Sort: ordena os elementos da lista (alfabética/numérica)
carros.Sort();



// Count: mostra o tamanho da lista (quantos itens a lista possui)
int tamanho = carros.Count;
Console.WriteLine($"Tamanho: {tamanho}");



// Capacity: retorna ou define a capacidade de elementos da lista

carros.Capacity = 15; //determinar capacidade

int capacidade = carros.Capacity; //ver capacidade

Console.WriteLine($"Capacidade: {capacidade}");
