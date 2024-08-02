using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4
{
    public class Produto
    {
        public Guid IdLivro { get; set; } = Guid.NewGuid();

        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 1;

    }
}
