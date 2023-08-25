using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    public interface IGeneroRepository
    {
        //CRUD

        //TipoDeRetorno NomeMetodo(TipoParametro NomeParametro)

        /// <summary>
        /// Cadastrar um novo Gênero de filme
        /// </summary>
        /// <param name="NovoGenero">Objeto que será cadastrado</param>
        /// 
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// Retorna todos os gênero cadastrados
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>
        /// 
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Buscar um objeto através de seu ID
        /// </summary>
        /// <param name="id">ID do objeto que será buscado</param>
        /// <returns>Objeto que foi buscado</returns>
        GeneroDomain BuscarPorId(int id);

        /// <summary>
        /// Atualizar um gênero existente, passando o ID pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Objeto gênero com as novas informações</param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atualizar um gênero existente, passando um ID pela URL e só alterando as informações no corpo
        /// </summary>
        /// <param name="id">ID do objeto a ser atualizado</param>
        /// <param name="genero">Objeto com as novas informações</param>
        void AtualizarIdURL(int id, GeneroDomain genero);


        /// <summary>
        /// Deletar um gênero existente
        /// </summary>
        /// <param name="id">ID do objeto a ser deletado</param>
        void Deletar(int id);

    }
}
