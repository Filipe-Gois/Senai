using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe_calculadora
{
    public class Calculadora
    {
        public float Somar(float n1, float n2)
        {
            float resultadoSoma = n1 + n2;
            Console.WriteLine(resultadoSoma);
            return resultadoSoma;


        }

        public float Subtrair(float n1, float n2)
        {
            float resultadoSub = n1 - n2;
            Console.WriteLine(resultadoSub);
            
            return resultadoSub;
        }

        public float Multiplicar(float n1, float n2)
        {
            float resultadoMulti = n1 * n2;
            Console.WriteLine(resultadoMulti);
            return resultadoMulti;
        }

        public float Dividir(float n1, float n2)
        {
            float resultadoDivi = n1 / n2;
            Console.WriteLine(resultadoDivi);
            return resultadoDivi;
        }
    }
}