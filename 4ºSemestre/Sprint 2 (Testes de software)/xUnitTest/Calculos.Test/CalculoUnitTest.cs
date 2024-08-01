using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //principio AAA : Act: Arrange, Assert
        //principio AAA : Agir: Organizar, Provar
        [Fact]
        public void SomarDoisNumeros()
        {
            //organizar
            double n1 = 10;
            double n2 = 5;
            double valorEsperadoSoma = 15;

            //agir
            double soma = Calculo.Somar(n1, n2);

            //provar
            Assert.Equal(valorEsperadoSoma, soma);

        }
        [Fact]
        public void SubtrairDoisNumeros()
        {
            double n1 = 10;
            double n2 = 5;
            double valorEsperado = 5;


            double subtracao = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtracao);

        }
        [Fact]
        public void DividirDoisNumeros()
        {
            double n1 = 10;
            double n2 = 5;
            double valorEsperado = 2;
            double divisao = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, divisao);
        }
        [Fact]
        public void MultiplicarDoisNumeros()
        {
            double n1 = 10;
            double n2 = 5;
            double valorEsperadoSoma = 50;

            double multiplicacao = Calculo.Multiplicar(n1, n2);

            Assert.Equal(valorEsperadoSoma, multiplicacao);
        }
        [Fact]
        public void Modulo()
        {
            double n1 = -20;

            double valorEsperaModulo = n1 * -1;

            double modulo = Calculo.Modulo(n1);

            Assert.Equal(valorEsperaModulo, modulo);
        }
    }
}
