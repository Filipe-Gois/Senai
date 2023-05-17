using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_sprint3
{
    public class Marca
    {
        public int CodigoMarca { get; set; }
        public int codigomarca { get; set; }
        public string NomeMarca { get; set; } = "";
        public string nomemarca { get; set; } = "";
        public DateTime DataCadastro { get; set; }
        List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca CadastrarMarca()
        {
            Marca novaMarca = new Marca();

            codigomarca = CodigoMarca;
            nomemarca = NomeMarca;

            Console.WriteLine($"Informe o nome da marca:");
            nomemarca = Console.ReadLine()!;

            Console.WriteLine($"Informe o código da marca:");
            codigomarca = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Marca cadastrada!");

            ListaDeMarcas.Add(new Marca());
            
            return novaMarca;
        }

        public void ListarMarca()
        {
            Console.WriteLine(@$"Marcas cadastradas:");

            foreach (var item in ListaDeMarcas)
            {
                Console.WriteLine(@$"
                Nome da marca: {item.nomemarca}
                Código da marca: {item.codigomarca}");
                
            }
            

        }

        public void DeletarMarca()
        {
            int codigomarca = CodigoMarca;

        }
    }
}