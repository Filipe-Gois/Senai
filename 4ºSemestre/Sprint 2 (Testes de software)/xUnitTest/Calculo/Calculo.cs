

using System;

namespace Calculos
{
    public static class Calculo
    {
        public static double Somar(double x, double y) => x + y;
        public static double Subtrair(double x, double y) => x - y;
        public static double Dividir(double x, double y) => x / y;
        public static double Multiplicar(double x, double y) => x * y;
        public static double Modulo(double x) => x * -1;
        public static double Bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;


        };
    }
}
