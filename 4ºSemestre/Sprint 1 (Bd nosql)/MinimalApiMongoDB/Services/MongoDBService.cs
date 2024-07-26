using MongoDB.Driver;

namespace MinimalApiMongoDB.Services
{

    public class MongoDBService()
    {
        /// <summary>
        /// Armazenar a configuração da aplicação
        /// </summary>
        private readonly IConfiguration _configuration;


        /// <summary>
        /// Armazena uma referência ao MongoDB
        /// </summary>
        private readonly IMongoDatabase _database;

        /// <summary>
        /// Contém a configuracao necessaria para acesso ao mongodb
        /// </summary>
        /// <param name="configuration">Objeto contendo toda a configuracao da aplicação</param>
        public MongoDBService(IConfiguration configuration) : this()
        {
            //atribui a config recebida em _configuration
            _configuration = configuration;


            //acessa a string de conexão
            string connectionString = _configuration.GetConnectionString("DBConnection")!;

            //transforma a string obtida em mongourl
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);

            //cria um client
            MongoClient mongoClient = new(mongoUrl);

            //obtém a referencia ao MongoDB
            _database = mongoClient.GetDatabase(mongoUrl.DatabaseName);

        }

        /// <summary>
        /// Propriedade para acessar o BD => retorna os dados em _database
        /// </summary>
        public IMongoDatabase GetDatabase => _database;

    }
}
