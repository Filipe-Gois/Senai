using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3;

namespace _3
{
    public abstract class Jogador
    {
        public string? nome { get; set; }
        public int nascimento { get; set; }
        public string? nacionalidade { get; set; }

        public float altura { get; set; }
        public float idadeAposentadoria { get; set; }
        public float peso { get; set; }

        abstract public void imprimir();
      

        abstract public void Aposentar();      
        abstract public int Idade();      
    }
}