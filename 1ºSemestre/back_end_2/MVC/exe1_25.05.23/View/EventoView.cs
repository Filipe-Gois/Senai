using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exe1_25._05._23.Model;

namespace exe1_25._05._23.View
{
    public class EventoView
    {
        public void Listar(List<EventoModel> evm)
        {
            foreach (var item in evm)
            {
                 Console.WriteLine(@$"
            Nome do evento: {item.Nome}
            Descrição do evento: {item.Descricao}
            Data do evento: {item.Data}");
            
            }
           
        }
        public EventoModel CadastrarEvento()
        {
            EventoModel eventoModel = new EventoModel();

            Console.WriteLine($"\nInforme o nome do evento:");
            eventoModel.Nome = Console.ReadLine()!;

            Console.WriteLine($"\nInforme a descrição do evento:");
            eventoModel.Descricao = Console.ReadLine()!;

            Console.WriteLine($"\nInforme a data do evento:");
            eventoModel.Data = Console.ReadLine()!;

            return eventoModel;
        }
        
    }
}