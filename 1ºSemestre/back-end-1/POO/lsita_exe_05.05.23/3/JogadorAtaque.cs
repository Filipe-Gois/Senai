using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3;

namespace _3
{
    public class JogadorAtaque : Jogador
    {
        public string? nome { get; set; }
        public int nascimentoAno { get; set; }
        public string? nacionalidade { get; set; }
        public int idade { get; set; }
        public int res { get; set; }
        public DateTime dataAno { get; set; }

        public float altura { get; set; }
        public int idadeAposentadoria { get; set; } = 35;
        public float peso { get; set; }


      
        public override int Idade()
        {
            idade = DateTime.Now.Year - nascimentoAno;

            Console.WriteLine($"Você possui {idade} anos.");
            
            return idade;
        }


        public override void Aposentar()
        {
            res = idadeAposentadoria - Idade();

            Console.WriteLine(res <= 0 ? $"Procure seu serviço de aposentadoria, você já passou sua idade limite de {idadeAposentadoria} anos de tranalho." : $"Ainda faltam {res} anos para você se aposentar. Trabalhe duro!");
        }

        public override void imprimir()
        {
            Console.WriteLine($"Informe seu nome");
            nome = Console.ReadLine()!;

            Console.WriteLine($"Informe seu ano de nascimento:");
            nascimentoAno = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe sua nacionalidade:");
            nacionalidade = Console.ReadLine()!;

            Console.WriteLine($"Informe sua altura:");
            altura = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe seu peso:");
            peso = float.Parse(Console.ReadLine()!);
        }
    }
}