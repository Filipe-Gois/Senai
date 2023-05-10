// Criar uma classe produto ok
// Com as propriedades: int Codig, string Nome, float Preco ok
// Crie um construtor vazio ok
// Crie um construtor completo ok
using listas;

// criar a lksta de objetos(produtos)
// forma nova
List<Produtos> produtos1 = new List<Produtos>();

produtos1.Add(
    new Produtos(250, "Cadeira", 50f)
);

produtos1.Add(
    new Produtos(10034, "Mesa", 500f)
);

// forma "habitual"

Produtos calcaDiesel = new Produtos(1526, "Calca diesel", 400f);
produtos1.Add(calcaDiesel);

// foreach (var item in produtos1)
// {
//     Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C2}, Índice: {produtos1.IndexOf(item)}");
    
// }

// lista: n dá p alterar de uma vez, tem q tirar, alterar, e dps devolver
//        buscar/
produtos1.Find(qualquercoisa => qualquercoisa.Codigo == 250);

Produtos produtoBuscado = produtos1.Find(x => x.Codigo == 10034)!;

int index = produtos1.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.9f;

produtos1.RemoveAt(index);

produtos1.Insert(index, produtoBuscado);

Console.WriteLine($"\nLista atualizada:");


foreach (var item in produtos1)
{
    Console.WriteLine($"\nCódigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C2}, Índice: {produtos1.IndexOf(item)}");
    
}