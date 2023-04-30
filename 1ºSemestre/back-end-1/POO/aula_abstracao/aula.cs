using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_abstracao
{
    public abstract class aula
    {
        public abstract class Veiculo
        {
            protected int velMaxima;    
            protected int velAtual;    
            protected bool ligado;

            public Veiculo()
            {
                ligado = false;
                velAtual = 0;
            }    

            public void setLigado(bool ligado)
            {
                this.ligado=ligado;
            }
           
        }
    }
}