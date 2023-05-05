using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public class Elevador
    {
        public int Andar { get; set; } = 0;

        public int TotalAndares { get; set; }
        public int CapacidadeElevador { get; set; }
        public int PessoasPresentes { get; set; }
        public int AndarAtual { get; set; } = 0;

        public void inicializa()
        {

            Console.WriteLine(@$"
           Número de pessoas suportadas: {CapacidadeElevador}
           Total de andares no prédio: {TotalAndares}");

        }

        public int Entrar()
        {
            string EntrarSouN;
            do
            {
                Console.WriteLine($"Deseja entrar ? S/N");
                EntrarSouN = Console.ReadLine()!.ToUpper();
            } while (EntrarSouN != "S" && EntrarSouN != "N");

            if (EntrarSouN == "S" && PessoasPresentes <= 19)
            {
                PessoasPresentes++;
                Console.WriteLine($"Você entrou no elevador.");

                return PessoasPresentes++;
            }
            else
            {
                Console.WriteLine($"Você passou reto e não entrou no elevador.");

                Environment.Exit(0);
                return 0;
            }
        }
        public int Sair()
        {
            string SairElevador;
            do
            {
                Console.WriteLine($"Deseja sair ? S/N");
                SairElevador = Console.ReadLine()!.ToUpper();
            } while (SairElevador != "S" && SairElevador != "N");

            if (SairElevador == "S" && PessoasPresentes != 0)
            {
                Console.WriteLine($"Você saiu do elevador.");
                return PessoasPresentes;
            }
            else
            // if (SairElevador == "S" && PessoasPresentes == 0)
            {
                Console.WriteLine($"Impossível sair, não existem pessoas no elevador.");
                return PessoasPresentes;
            }
        }

        public int Subir()
        {
            string SubirElevador;
            do
            {
                Console.WriteLine($"Deseja subir ? S/N");
                SubirElevador = Console.ReadLine()!.ToUpper();
            } while (SubirElevador != "S" && SubirElevador != "N");

            if (SubirElevador == "S" && AndarAtual <= 9 && CapacidadeElevador <= 19)
            {
                AndarAtual++;
                Console.WriteLine($"Você está no {AndarAtual}º andar. {PessoasPresentes} pessoas estão no elevador.");
                return AndarAtual;
            }
            else if (SubirElevador == "S" && TotalAndares >= 9)
            {
                Console.WriteLine($"Impossível subir.");
                return AndarAtual;;
                
            }
            return AndarAtual;
           
        }

        public int Descer()
        {
            string DescerElevador;
            do
            {
                Console.WriteLine($"Deseja descer ? S/N");
                DescerElevador = Console.ReadLine()!.ToUpper();
            } while (DescerElevador != "S" && DescerElevador != "N");

            if (DescerElevador == "S" && AndarAtual > 1)
            {
                Console.WriteLine($"Você está no {AndarAtual}º andar. {PessoasPresentes} pessoas estão no elevador.");
                return AndarAtual;
            }
            else if (DescerElevador == "S" && TotalAndares <= 1)
            {
                Console.WriteLine($"Impossível descer.");
                return AndarAtual;;
                
            }
            else{
                Console.WriteLine($"Impossível descer.");
                return AndarAtual;
                
            }
        }
      }


    }
