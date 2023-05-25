using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exe1_25._05._23.Model;
using exe1_25._05._23.View;

namespace exe1_25._05._23.Controller
{
    public class EventoController
    {
        EventoModel eventoModel = new EventoModel();
        EventoView eventoView = new EventoView();
        public void Cadastrar()
        {
            eventoModel.Inserir(eventoView.CadastrarEvento());
        }
        public void ListarEvento()
        {
            List<EventoModel> evm = eventoModel.Listar();
            eventoView.Listar(evm);
        }
    }
}