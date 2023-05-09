using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_estatica
{
    public static class Conversao
    {

        public static float Dolar(float real)
        {
            float dolar = real * 4.99f;
            return dolar;
        }
        public static float Real(float dolar)
        {
            float real = dolar * 0.2f;
            return real;
        }
    }


}