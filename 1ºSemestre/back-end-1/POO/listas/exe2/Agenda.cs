using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe2
{
    public class Agenda : Contato, IAgenda
    {
        List<Contato> contato = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            throw new NotImplementedException();
        }

        public void Listar(Contato _contato)
        {
            throw new NotImplementedException();
        }
    }
}