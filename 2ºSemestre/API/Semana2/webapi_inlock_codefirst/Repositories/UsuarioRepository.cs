using Microsoft.EntityFrameworkCore;
using webapi_inlock_codefirst.Contexts;
using webapi_inlock_codefirst.Domains;
using webapi_inlock_codefirst.Interfaces;
using webapi_inlock_codefirst.Utils;

namespace webapi_inlock_codefirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly InlockContext ctx;
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }

        public UsuarioDomain BuscarUsuario(string email, string senha)
        {
            try
            {
                var usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.EmailUsuario == email);

                if (usuarioBuscado != null)
                {
                    bool conferido = Criptografia.CompararHash(senha, usuarioBuscado.SenhaUsuario);

                    if (conferido == true)
                    {
                        return usuarioBuscado;
                    }
                }


                return null;

            }
            catch (Exception)
            {

                throw;
            }


            //    UsuarioDomain usuarioBuscado = ctx.Usuario.Find(email)!;

            //    if (usuarioBuscado != null)
            //    {
            //        Criptografia.CompararHash(senha, );
            //    }

            //}

            public void CadastrarUsuario(UsuarioDomain usuario)
            {
                try
                {
                    usuario.SenhaUsuario = Criptografia.GerarHash(usuario.SenhaUsuario!);

                    ctx.Usuario.Add(usuario);

                    ctx.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
