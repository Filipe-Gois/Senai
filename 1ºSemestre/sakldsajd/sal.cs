using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sakldsajd
{
   
    public class Pessoa
    {
     
     string? nome;
     int idade;
     float peso;
     float altura;
     double valorIMC;
     
        public Pessoa()
        {
            
        }
        public void Nome()
        {
            Console.WriteLine($"Informe o nome:");
            nome = Console.ReadLine()!;
        }
        public void Peso()
        {
            Console.WriteLine($"Informe o peso:");
            peso = float.Parse(Console.ReadLine()!);
        }
        public void Altura()
        {
            Console.WriteLine($"Informe a altura:");
            altura = float.Parse(Console.ReadLine()!);
        }
        public void Idade()
        {
            Console.WriteLine($"Informe a idade");
            idade = int.Parse(Console.ReadLine()!);
        }
        public double imc()
        {
            valorIMC = peso / Math.Pow(altura, 2);
            return valorIMC;
        }

        public void Resultado()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura} M");
            Console.WriteLine($"Peso: {peso} KG");

            Console.WriteLine($"IMC: {Math.Round(imc(),2)}");
            
            
            
            
            
        }
      
    }
}