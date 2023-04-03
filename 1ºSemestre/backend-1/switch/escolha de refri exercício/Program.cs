Console.WriteLine(@$"
-------------------------------------
| Bem-vindo!                          |   
|                                     | 
|   Informe a bebida desejada:        |
|                                     |
|    1) Coca Cola                     |
|    2) Pepsi                         |
|    3) Fanta                         |
|    4) Monster                       |
--------------------------------------
");

Console.WriteLine($"Informe a bebida desejada:");

int bebida = int.Parse(Console.ReadLine()!.ToUpper());
string respGelo = "";

switch (bebida)
{
    case 1:
    Console.WriteLine($"Gostaria de acrescentar gelo ?");
    respGelo = Console.ReadLine()! .ToUpper();
    
    
    if (respGelo == "SIM") {
        Console.WriteLine($"Coca Cola com gelo adicionada ao pedido.");
    }
    else{
        Console.WriteLine($"Coca Cola sem gelo adicionada ao pedido.");
        
    }
    break;

    case 2:
    Console.WriteLine($"Gostaria de acrescentar gelo ?");
    respGelo = Console.ReadLine()! .ToUpper();
    
    
    if (respGelo == "SIM") {
        Console.WriteLine($"Pepsi com gelo adicionada ao pedido.");
    }
    else{
        Console.WriteLine($"CPepsi sem gelo adicionada ao pedido.");
        
    }
    break;

    case 3:
    Console.WriteLine($"Gostaria de acrescentar gelo ?");
    respGelo = Console.ReadLine()! .ToUpper();
    
    
    if (respGelo == "SIM") {
        Console.WriteLine($"Fanta com gelo adicionada ao pedido.");
    }
    else{
        Console.WriteLine($"Fanta sem gelo adicionada ao pedido.");
        
    }
    break;
    
    case 4:
    Console.WriteLine($"Gostaria de acrescentar gelo ?");
    respGelo = Console.ReadLine()! .ToUpper();
    
    
    if (respGelo == "SIM") {
        Console.WriteLine($"Monter com gelo adicionada ao pedido.");
    }
    else{
        Console.WriteLine($"Monster sem gelo adicionada ao pedido.");
        
    }
    break;
    
    default:
    break;
}