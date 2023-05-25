using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo1.Model
{
    public class Produto
    {
        // propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasta e do arquivo CSV
        private const string PATH = "Database/Produto.csv";
        public Produto()
        {
            // criar a lógica para gerar a pasta e o arquivo:

            // 1)obter o caminho para a pasta

            string pasta = PATH.Split("/")[0];

            // 2) verificar se no caminho já existe uma pasta

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // 3) verificar se no caminho já existe um arquivo

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        // leitura das linhas
        public List<Produto> LER()
        {
            // instãncia da lista d eprodutos
            List<Produto> produtos = new List<Produto>();


            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                // adiciona objeto dentro da lista
                produtos.Add(p);
            }
            // retorna  a lista de produtos
            return produtos;
        }

        // método para preparar as linhas a serem inseridas no CSV
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome}; {p.Preco}";
        }

        // metodo para inserir um produto na linha do CSV

        public void Inserir(Produto p)
        {
            // array que armazena as linhas obtidas pelo método PrepararLinhasCSV
            string[] linhas = {PrepararLinhasCSV(p)};

            // inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }
    }
}