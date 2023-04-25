using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). ok

// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.

// Só será possível executar tais métodos se o celular estiver ligado.

// Envie o link do repositório como entrega desta atividade.


namespace exe_celular
{
    public class Celular
    {
        public string Cor = "";
        public string Modelo = "";
        public string Tamanho = "";
        public bool Ligado;
        public string LigarCell = "";

        public void Ligacao()
        {
            Console.WriteLine($"Ligação iniciada.");
            Console.WriteLine($"Ligação encerrada.");
        }

        public void Mensagem()
        {
        Console.WriteLine($"Digite sua mensagem:");
        string MensagemTxt = Console.ReadLine()!;

        Console.WriteLine($"Mensagem enviada!"); 
        }

        public void Desligar()
        {
            Console.WriteLine($"Dispositivo desligado.");
            
        }
    }
}