Console.WriteLine($"Informe a medida dos lados do triângulo:");

Console.WriteLine($"Lado 1:");
float lado1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Lado 2:");
float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Lado 3:");
float lado3 = float.Parse(Console.ReadLine()!);


if ((lado1 == lado2) && (lado1 == lado3) && (lado2 == lado3))
{
    Console.WriteLine($"Seu triângulo é equilátero, possuindo três lados iguais.");
    
}

else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
{
    Console.WriteLine($"Seu triângulo é isósceles, possuindo dois lados iguais.");
    
}

else if ((lado1 != lado2) || (lado1 != lado3) || (lado2 != lado3))
{
    Console.WriteLine($"eu triângulo é escaleno, não possuindo lados iguais.");
    
}






