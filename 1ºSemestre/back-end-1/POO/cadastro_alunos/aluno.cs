using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_alunos
{
    public class aluno
    {
        // atributos/propriedades
        public string Nome = "";
        public string Curso = "";
        public string Idade = "";
        public string Rg = "";
        public string Bolsa = "";
        public bool Bolsa1 = false;
        public float MediaFinal;
        public float Mensalidade;


        // métodos
        public float CalcularBolsa(float MediaFinal)
        {
            if (this.MediaFinal >= 8 && this.Bolsa1 == true)
            {
                float Valor50 = this.Mensalidade * 0.5f;

                Console.WriteLine($"Parabéns, você recebeu 50% de bolsa e pagará {Valor50}.");
                return Valor50;
            }

            else if (this.MediaFinal > 6 && this.MediaFinal < 8 && this.Bolsa1 == true)
            {
                float Valor70 = this.Mensalidade * 0.7f;

                Console.WriteLine($"Você recebeu uma bolsa de 30% e pagará {Valor70}.");
                return this.Mensalidade * 0.7f;
            }
            else
            {
                Console.WriteLine($"Você não alcançou os parâmetros mínimos para obter bolsa.");
                return 0;
            }

        }

        public void VerMediaFinal()
        {
            Console.WriteLine($"{this.Nome}, sua média final foi de: {this.MediaFinal}.");

        }

    }


}