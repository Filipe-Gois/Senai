using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o serviço de controllers
builder.Services.AddControllers();


//Adicionar serviço de autenticação JWT Bearer
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})

//Define os parametros de validação do token
.AddJwtBearer("JwtBearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        //Valida quem está solicitando
        ValidateIssuer = true,

        //Valida quem está recebendo

        ValidateAudience = true,

        //Define se o tempo de validação do token será validado
        ValidateLifetime = true,

        //Forma de criptografia e ainda validação da chave de autenticação
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev")),

        //Valida o tempo de expiração do token
        ClockSkew = TimeSpan.FromMinutes(5),

        //De onde está vindo (issuer)
        ValidIssuer = "webapi.filmes.tarde",

        //Para onde está indo (audience)
        ValidAudience = "webapi.filmes.tarde"
    };



}); //PARAMOS AQUI, CONTINUAR NA SEGUNDA


//Instrução usada para colocar anotações no cabeçalho do swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        //Versão da API
        Version = "v1",

        //Título da API
        Title = "API Filmes Tarde",

        //Descrição da API
        Description = "API para gerenciamento de filmes - Introdução a SPRINT 2, BACK-END - API",

        //Termos de serviço
        TermsOfService = new Uri("https://example.com/terms"),

        //Contatos do desenvolvedor
        Contact = new OpenApiContact
        {
            Name = "Filipe Góis",
            Url = new Uri("https://github.com/Filipe-Gois")
        },

        //Lincensa da aplicação
        License = new OpenApiLicense
        {
            Name = "Senai Informática - Turma Tarde",
            Url = new Uri("https://github.com/senai-desenvolvimento")
        }
    });

    //Configura o swagger para usar o XML
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    //Usando a autorização no Swagger
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Values: Bearer TokenJWT"
    });
});



//Instancia o builder da aplicação
var app = builder.Build();

//Habilita o middleware para atender ao documento JSON gerado e à interface do usuário do Swagger
if (app.Environment.IsDevelopment())
{
    //Adicionará o middleware do Swagger somente se o ambiente atual estiver definido como Desenvolvimento.
    app.UseSwagger();

    //A chamada do método UseSwaggerUI habilita o Middleware de arquivos estáticos.
    app.UseSwaggerUI();
}

//Para atender à interface do usuário do Swagger na raiz do aplicativo - leva pra interface do swagger
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

    //Defina a propriedade RoutePrefix como uma cadeia de caracteres vazia
    options.RoutePrefix = string.Empty;
});


app.UseAuthentication();

app.UseAuthorization();

//Mapear os controllers
app.MapControllers();
app.Run();
