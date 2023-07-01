using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_refeito
{
    public class Elevador
    {
        public int andarAtual { get; set; } = 0;
        public int totalAndares { get; set; } = 10;
        public int pessoasPresentes { get; set; } = 10;
        public int maximoPessoas { get; set; } = 10;
        public int removerPessoas { get; set; }

        public void Inicializar(int capacidadePessoas, int andaresTotal)
        {
            capacidadePessoas = 10;
            andaresTotal = 10;


            Console.WriteLine(@$"Olá, você é uma inteligência artificial que opera um elevador, o que deseja fazer ?

            Andar atual: {andarAtual}
            Total de pessoas no elevador: {pessoasPresentes}

            [1] - Adicionar pessoa(s)
            [2] - Remover pessoa(s)
            [3] - Subir
            [4] - Descer");




        }

        public void adicionar()
        {
            
        }

        public void remover()
        {
            if (pessoasPresentes > 0)
            {
                Console.WriteLine($"Deseja retirar quantas pessoas do elevador ?");
                removerPessoas = int.Parse(Console.ReadLine()!);

                if (removerPessoas <= pessoasPresentes)
                {
                    pessoasPresentes -= removerPessoas;
                    Console.WriteLine($"{removerPessoas} pessoas removidas.");

                }
                else
                {
                    Console.WriteLine($"Impossível remover {removerPessoas} de {pessoasPresentes}. Não seja BURRO!");

                }
            }
            else
            {
                Console.WriteLine($"Não há pessoas para serem removidas do elevador!");

            }
        }

    }
}