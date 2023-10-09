using Microsoft.EntityFrameworkCore;
using webapi.inlock.tarde.Contexts;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;

namespace webapi.inlock.tarde.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();
        public void Atualizar(Guid id, Estudio estudio)
        {
            Estudio estudioBuscado = ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id)!;

            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudio.Nome;
            }
            //Executa a lógica no BD
            ctx.Update(estudioBuscado!);

            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(Guid id)
        {
            //Estudio estudioBuscado = ctx.Estudios.Find(id);
            //Ambos funcionam

            Estudio estudioBuscado = ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id)!;

            return estudioBuscado;
        }

        public void Cadastrar(Estudio estudio)
        {
            //Possibilidade para gerar um novo id para o objeto ou ir na domain e colocar
            //estudio.IdEstudio = Guid.NewGuid();
            ctx.Estudios.Add(estudio);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            //return ctx.Estudios.Remove();
            Estudio estudioBuscado = ctx.Estudios.Find(id)!;

            if (estudioBuscado != null)
            {
                ctx.Estudios.Remove(estudioBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {

            return ctx.Estudios.Include(E => E.Jogos).ToList();
        }
    }
}
