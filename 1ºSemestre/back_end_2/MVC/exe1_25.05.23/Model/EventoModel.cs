using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe1_25._05._23.Model
{
    public class EventoModel
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Data { get; set; }

        private const string PATH = "Database/Evento.csv";

        public EventoModel()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<EventoModel> Listar()
        {
            List<EventoModel> eventos = new List<EventoModel>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                EventoModel evm = new EventoModel();
                evm.Data = atributos[0];
                evm.Descricao = atributos[1];
                evm.Nome = atributos[2];

                eventos.Add(evm);
            }
            return eventos;
        }

        public string PrepararLinahsCsv(EventoModel evm2)
        {
            return $"{evm2.Nome};{evm2.Descricao};{evm2.Data}";
        }
        public void Inserir(EventoModel evm2)
        {
            string[] linhas = {PrepararLinahsCsv(evm2)};

            File.AppendAllLines(PATH, linhas);
        }



    }
}