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
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";


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

        /// <summary>
        /// Busca um gênero através de seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeneroDomain BuscarPorId(int id)
        {
            GeneroDomain generoBuscado = new GeneroDomain();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {

                string queryId = "SELECT IdGenero, Nome FROM Genero WHERE Genero.IdGenero = @IdGenero";

                con.Open();
                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryId, con))
                {
                    cmd.Parameters.AddWithValue("IdGenero", id);

                    rdr = cmd.ExecuteReader();

                    //utilziar if, por conta de ser só 1 objeto
                    if (rdr.Read())
                    {
                        //Atribui a propriedade IdGenero ao valor da primeira coluna da tabela
                        generoBuscado.IdGenero = Convert.ToInt32(rdr[0]);

                        //Atribui a propriedade nome ao valor da coluna nome
                        generoBuscado.NomeGenero = Convert.ToString(rdr[1]);

                        //ou: NomeGenero = rdr["Nome"].ToString()
                        return generoBuscado;
                    }
                }

            }
            return null;

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
                //Sempre coloque uma variável na query, para não dar o erro da joana d'ARC
                //Declara a query que será executada
                string queryInsertInto = $"INSERT INTO Genero(Nome) VALUES(@Nome)";
                //ou colocar NomeGenero no lugar da interpolação

                //con.Open();
                //Tanto faz se dar o con.Open(); dentro ou fora desse using


                //Declara o sqlcommand, passando a query que será executada e a conexão com o BD
                using (SqlCommand cmd = new SqlCommand(queryInsertInto, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", NovoGenero.NomeGenero);

                    //Abre a conexão com o BD
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Deleta um gênero passando o ID pela URL
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE Genero.IdGenero = @IdGenero";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("IdGenero", id);
                    //isso especifica que o termo "@id" representa o id do genero informado como parâmetro @id = int id
                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Atualiza um gêenero através do ID passado pelo corpo
        /// </summary>
        /// <param name="genero"></param>
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Update = "UPDATE Genero SET Genero.Nome = @NomeGenero WHERE Genero.IdGenero = @IdGenero";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(Update, con))
                {
                    cmd.Parameters.AddWithValue("IdGenero", genero.IdGenero);
                    cmd.Parameters.AddWithValue("NomeGenero", genero.NomeGenero);

                    cmd.ExecuteNonQuery();
                }
            }

        }
        /// <summary>
        /// Atualiza um gênero passando o ID pela URL
        /// </summary>
        /// <param name="id"></param>
        /// <param name="genero"></param>
        public void AtualizarIdURL(int id, GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Update = "UPDATE Genero SET Genero.Nome = @NomeGenero WHERE Genero.IdGenero = @IdGenero";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(Update, con))
                {
                    cmd.Parameters.AddWithValue("IdGenero", id);
                    cmd.Parameters.AddWithValue("NomeGenero", genero.NomeGenero);

                    cmd.ExecuteNonQuery();
                }
            }
        }







    }
}
