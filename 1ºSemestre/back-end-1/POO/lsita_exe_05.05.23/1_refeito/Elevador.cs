using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_refeito
{
    public class Elevador
    {
        public string? res { get; set; }
        public int andarAtual { get; set; } = 0;
        public int totalAndares { get; set; }
        public int pessoasPresentes { get; set; }
        public int maximoPessoas { get; set; }
        public int removerPessoas { get; set; }
        public int adicionarPessoas { get; set; }
        public bool terreo { get; set; }


        public void Inicializar(int capacidadePessoas, int andaresTotal)
        {
            maximoPessoas = capacidadePessoas;
            totalAndares = andaresTotal;

            Console.WriteLine($"Informe o número máximo de pessoas que o elevador comportará:");
            maximoPessoas = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe quantos andares o prédio tem:");
            totalAndares = int.Parse(Console.ReadLine()!);

            do
            {
                Console.WriteLine(@$"O que deseja fazer ?

            Andar atual: {andarAtual}
            Total de pessoas no elevador: {pessoasPresentes}
            
            [1] - Adicionar pessoa(s)

            [2] - Remover pessoa(s)

            [3] - Subir

            [4] - Descer

            [0] - Encerrar serviços");

                res = Console.ReadLine()!;

                switch (res)
                {
                    case "1":
                        adicionar();
                        break;

                    case "2":
                        remover();
                        break;

                    case "3":
                        subir();
                        break;

                    case "4":
                        descer();
                        break;

                    case "0":
                        Console.WriteLine($"Serviços encerrados, tenha uma ótima noite!");
                        // Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine($"Valor inválido.");
                        break;
                }
            } while (res != "0");
        }


        public void adicionar()
        {
            Console.WriteLine($"Deseja adicionar quantas pessoas ao elevador ?");
            adicionarPessoas = int.Parse(Console.ReadLine()!);

            if (pessoasPresentes == 0)
            {

            
            if (adicionarPessoas <= maximoPessoas)
            {
                pessoasPresentes += adicionarPessoas;

                Console.WriteLine($"{adicionarPessoas} pessoas adicionadas ao elevador.");

            }

            else
            {
                Console.WriteLine($"Impossível adicionar Todas essas pessoas, o elevador não suporta.");
            }
            }
            else
            {
                Console.WriteLine($"Impossível adicionar Todas essas pessoas, o elevador não suporta.");
            }
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

        public void subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
                Console.WriteLine($"Você está no {andarAtual}º andar.");
            }
            else
            {
                Console.WriteLine($"Ops, o elevador está na cobertura, é impossível subir.");

            }
        }

        public void descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine($"Você está no {andarAtual}º andar.");
            }

            else
            {
                Console.WriteLine($"Impossível descer, o elevador já está no térreo.");

            }

        }

    }
}