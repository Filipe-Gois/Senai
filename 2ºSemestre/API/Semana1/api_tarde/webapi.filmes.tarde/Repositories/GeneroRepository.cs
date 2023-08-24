using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        //Utilizada para conectar ao banco de dados
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source: nome do servidor do banco
        /// Initial catalog: Nome do BD
        /// Autenticação:
        /// -Windows: Integrated Security = True
        /// SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryId = "SELECT Nome FROM Genero";

            }
            throw new NotImplementedException();
        }


        /// <summary>
        /// Cadastrar um novo genero
        /// </summary>
        /// <param name="NovoGenero">Objeto com as informações que serão cadastradas</param>

        public void Cadastrar(GeneroDomain NovoGenero)
        {
            //Conectar no bd primeiro "Declara a SqlConnection, passando a string de conexão como parâmetro. É o objeto que faz a conexão com o BD"

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a query que será executada
                string queryInsertInto = $"INSERT INTO Genero(Nome) VALUES('{NovoGenero.NomeGenero}')";

                //con.Open();
                //Tanto faz se dar o con.Open(); dentro ou fora desse using


                //Declara o sqlcommand, passando a query que será executada e a conexão com o BD
                using (SqlCommand cmd = new SqlCommand(queryInsertInto,con))
                {
                    //Abre a conexão com o BD
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Listar todos os objetos do tipo genero
        /// </summary>
        /// <returns>Lista de objetos do tipo gênero</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de generos onde serão armazenados os generos
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();


            //Declara a SqlConnection, passando a string de conexão como parâmetro. É o objeto que faz a conexão com o BD
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrução a ser executada, no caso, é o select
              string querySelectAll = "SELECT IdGenero, Nome FROM Genero";


                //Abre a conexão com o BD
                con.Open();

                //Declara o SqlDataReader para percorrer/ler a tabela no BD
                SqlDataReader rdr;


                //Declara o SqlCommand passando a query que será executada e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                  //executa a query e armazena os dados na rdr
                  rdr = cmd.ExecuteReader();


                    //Enquanto houver registros a serem lidos no rdr, o laço se repetirá
                    while (rdr.Read())
                    {
                        GeneroDomain gennero = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero ao valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //Atribui a propriedade nome ao valor da coluna nome
                            NomeGenero = Convert.ToString(rdr[1])

                            //ou: NomeGenero = rdr["Nome"].ToString()

                        };

                        //Adiciona o objeto criado dentro da lista
                        ListaGeneros.Add(gennero);

                         
                    }
                }
            }

            //Retorna a lista de generos
            return ListaGeneros;
        }

        
    }
}
