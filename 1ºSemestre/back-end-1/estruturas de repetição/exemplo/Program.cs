// usando for: repete um número determinado de vezes

// string nome = "Filipe Góis";

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"hehehehehehehehe");
    
//     Console.WriteLine($"{i}) {nome} {i}");
    
// }





// usando o while: (faz a veerificação da condição no ínicio, antes de executar o códeigo)

// string nome = "Filipe Góis";
// int i = 0;

// string[] nomePessoas = new string[4];

// nomePessoas[0] = "fefe";
// nomePessoas[1] = "uga";
// nomePessoas[2] = "juba";
// nomePessoas[3] = "emo";





// while (i < 10) ou while (i < nomePessoas.Length) "o length conta quantos registros existem  dentro do array"
// {
//     Console.WriteLine($"hehehehehehehehe, {i + 1}");
    
//     Console.WriteLine($"{nomePessoas[0]}");
   
//     i++;
// }

// usando foreach: (significa para cada, usado para arrays)





// foreach (var item in nomePessoas)
// {
//     Console.WriteLine($"repetindo a variável nome: índice: {i}");
//     Console.WriteLine($"{item}");
    
// }


// do while: (faz a veerificação da condição após a execução do código)


// int x = 0;

// do
// {
//     Console.WriteLine(x);
//     x++;
    
// } 

// while (x <= 10);
// {

// }

// outro exemplo de do while
// aqui ele só executa uma vez, pois primeiro ele executa o comando, e depois percebe que está "errado"(false) e não escreve os próximos
int x = 20;

do
{
    Console.WriteLine(x);
    x++;
    
} 

while (x <= 10);
{

}