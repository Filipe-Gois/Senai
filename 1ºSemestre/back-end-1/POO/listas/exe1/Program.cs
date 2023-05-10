using exe1;
// string marca;
// string cor;
int i;
List<Carro> Carros = new List<Carro>();

// for (i = 0; i < 2; i++)
// {
//     Console.WriteLine($"Informe a marca do carro:");
//     marca = Console.ReadLine()!;

//     Console.WriteLine($"Informe a cor do carro:");
//     cor = Console.ReadLine()!;
//     Carros.Add(
//         new Carro( marca, cor));
// }


// foreach (var item in Carros)
// {
//     Console.WriteLine($"Marca: {item.Marca}, Cor: {item.Cor} ");

// }

// ou

for (i = 0; i < 2; i++)
{
    Carro carros = new Carro();

    Console.WriteLine($"Informe a marca do carro:");
    carros.Marca = Console.ReadLine()!;

    Console.WriteLine($"Informe a cor do carro:");
    carros.Cor = Console.ReadLine()!;

    Carros.Add(carros);
}


foreach (var item in Carros)
{
    Console.WriteLine($"Marca: {item.Marca}, Cor: {item.Cor} ");

}
