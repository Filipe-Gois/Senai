using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;
using webapi.filmes.tarde.Repositories;

namespace webapi.filmes.tarde.Controllers
{
    /// <summary>
    /// Route: define que a rota de uma requisição será no seguinte formato: dominio/api/nomeController
    /// Ex: http://Localhost:5000/api/genero
    /// </summary>
    [Route("api/[controller]")]

    /// <summary>
    /// ApiController: Define que é um controlador de api
    /// </summary>
    [ApiController]

    /// <summary>
    /// Route: Define que o tipo de resposta da api é JSON
    /// </summary>
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        //Ao usar o objeto Usuario usuarioo como parâmetro, os dados serão preenchidos pelo corpo. Se usar string email, string senha como parâmetros, os dados deverão ser informados pela URL. "URL seria mais perigoso"
        [HttpPost]
        public IActionResult Login(UsuarioDomain usuario)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _UsuarioRepository.BuscarUsuario(usuario.UsuarioEmail, usuario.UsuarioSenha);

                if (usuarioBuscado == null)
                {
                    return StatusCode(404, "Usuário não encontrado, E-mail ou senha inválidos.");

                }
                //Caso encontre o usuario buscado, prosegue para a criação do token

                //1º - Definir as as informações(claims) que serão fornecidas no token(payload)

                var claims = new[]
                {
                    //formato da claim(tipo, valor)
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    //jti = referente ao id do usuario

                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.UsuarioEmail),

                    new Claim(ClaimTypes.Role, usuarioBuscado.UsuarioPermissao),


                    //Existe a possibilidade de criar uma Claim personalizada
                    // new Claim("Claim Personalizada","Valor Personalizado")
                };

                //2º - Definir a chave de acesso ao Token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));

                //3º Definir as credenciais do token (header)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4º Gerar o token
                var token = new JwtSecurityToken
                    (
                    //emissor do token
                    issuer: "webapi.filmes.tarde",

                    //Destinatário
                    audience: "webapi.filmes.tarde",

                    //Dados definidos nas claims (payload)
                    claims: claims,

                    //Tempo de expiração
                    expires: DateTime.Now.AddMinutes(5),

                    //Credenciais do token
                    signingCredentials: creds
                    );

                //5º Retornar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
