using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4
{
    public class Inventario
    {
        public Dictionary<Guid, Produto> InventarioLista { get; set; } = [];
        public void AdicionarProduto(Produto produto)
        {
            bool existeProduto = InventarioLista.ContainsKey(produto.IdLivro);



            if (existeProduto)
            {
                InventarioLista[produto.IdLivro].Quantidade++;
            }
            else
            {
                InventarioLista.Add(produto.IdLivro, produto);
            }
        }

        public int BuscarQuantidadeDoProdutoPeloNome(string nomePrduto) => InventarioLista.FirstOrDefault(x => x.Value.Nome == nomePrduto).Value.Quantidade;

    }
}
