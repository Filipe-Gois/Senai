using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC
{
    public class Calculo_imc
    {
        public string? nome { get; set; }
        public int idade { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public double resultado { get; set; }


        public string CalcularImc()
        {
            resultado = peso / Math.Pow(altura, 2);

            
            if (resultado < 17)
            {
                return "Você está abaixo do peso.";
            }

            else if (resultado < 18.5)
            {
                return "Você está abaixo do peso.";

            }

            else if (resultado < 25)
            {
                return "Seu peso está normal.";

            }

            else if (resultado < 30)
            {
                return "Você está acima do peso.";

            }

            else if (resultado < 35)
            {
                return "Obesidade I.";

            }

            else if (resultado < 40)
            {
                return "Obesidade II.";

            }

            else
            {
                return "Obesidade III.";

            }


        }
    }
}