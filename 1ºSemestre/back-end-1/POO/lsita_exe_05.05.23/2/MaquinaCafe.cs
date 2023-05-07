using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel { get; set; }
        public int AcucarAdicionado {get; set;}
        public int AcucarFinal {get; set;}
        public string BebidaAtual = "Capuccino 500ml";

        public int FazerCafe()
        {
            Console.WriteLine($"Quanto de açúcar deseja adicionar?");
            AcucarAdicionado = int.Parse(Console.ReadLine()!);

            if (AcucarAdicionado <= AcucarDisponivel)
            {
                int letreiro = AcucarDisponivel - AcucarAdicionado;
                AcucarFinal = AcucarDisponivel - AcucarAdicionado;
                Console.WriteLine($"{BebidaAtual} com {AcucarAdicionado}g adicionado ao pedido.");
                return letreiro;
            }

            else
            {
                Console.WriteLine($"Perdão, estamos sem açúcar no momento.");
                
            }


            return AcucarFinal;
        }

        // public bool FazerCafe()
        // {
        //     return true;
        // }
    }
}