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


            foreach (var item in InventarioLista)
            {
                //se contem
                if (InventarioLista.ContainsKey(item.Key))
                {
                    item.Value.Quantidade++;
                }
                //se n contem
                else
                {
                    InventarioLista.Add(produto.IdLivro, produto);
                }
            }
        }
    }
}
