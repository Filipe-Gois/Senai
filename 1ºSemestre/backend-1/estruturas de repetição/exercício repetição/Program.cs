Console.WriteLine($"Bem-vindo, vamos validar suas informações.");


Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Por favor, insira um nome válido.");
    nome = Console.ReadLine()!;
}

Console.WriteLine($"Informe sua idade");
int idade = int.Parse(Console.ReadLine()!);

while ((idade < 0) || (idade > 100))
{
    Console.WriteLine($"Por favor, insira uma idade válida.");
    idade = int.Parse(Console.ReadLine()!);

}

Console.WriteLine($"Informe o seu salário.");
float salario = float.Parse(Console.ReadLine()!);

while (salario <= 0)
{
    Console.WriteLine($"Por favor, digite um valor válido.");
    salario = float.Parse(Console.ReadLine()!);
}

Console.WriteLine(@$"
Informe seu estado civil:

(s) Solteiro;

(c) Casado;

(v) Viúvo;

(d) Divorciado;

");

char estado = char.Parse(Console.ReadLine()!.ToLower());

while ((estado != 's') && (estado != 'c') && (estado != 'v') && (estado != 'd'))
{
    Console.WriteLine($"Por favor, insira um uma letra válida.");
    
}

Console.WriteLine($"Dados cadastrados com sucesso. Nome: {nome}, idade: {idade}, salário: {salario}, estado civil: {estado}. ");
