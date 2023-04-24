using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_alunos
{
    public class aluno
    {
        public string nome = "";
        public string curso = "";
        public int idade;
        public string rg = "";
        public string bolsa = "";
        public bool bolsa1 = false;
        public float mediaFinal;
        public float mensalidade;

        public float  calcularBolsa(float mediaFinal)
    {
        if (mediaFinal >= 8)
        {
            Console.WriteLine($"Parabéns, você recebeu 50% de bolsa e pagará {mensalidade * 0.5}");
            return mensalidade * 0.5f;
        }

        else if (mediaFinal > 6 && mediaFinal < 8)
        {
            Console.WriteLine($"Você recebeu uma bolsa de 30% e pagará {mensalidade * 0.7}");
            return mensalidade * 0.7f;
        }
        else{
            Console.WriteLine($"Você não alcançou os parâmetros mínimos para obter bolsa.");
            return 0;
        }
        
    }

    }

    
}