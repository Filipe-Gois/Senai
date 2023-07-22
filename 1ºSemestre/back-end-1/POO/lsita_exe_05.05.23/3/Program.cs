// 3.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

using _3;
JogadorMeio_Campo meio = new JogadorMeio_Campo();
JogadorAtaque atk = new JogadorAtaque();
JogadorDefesa def = new JogadorDefesa();







string escolha;
do
{


    Console.WriteLine(@$"Olá, informe em qual posição você joga:
[1] Ataque
[2] Meio
[3] Defesa");
    escolha = Console.ReadLine()!;
}
while (escolha != "1" && escolha != "2" && escolha != "3");


switch (escolha)
{
    case "1":
        atk.imprimir();
        atk.Idade();
        atk.Aposentar();
        break;
    case "2":
       meio.imprimir();
       meio.Idade();
       meio.Aposentar();
        break;
    case "3":
        def.imprimir();
        def.Idade();
        def.Aposentar();
        break;

    default:
        Console.WriteLine($"Valor inválido.");
        break;
}
