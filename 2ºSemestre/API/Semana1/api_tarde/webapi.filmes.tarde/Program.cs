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
.AddJwtBearer(options => { }); //PARAMOS AQUI, CONTINUAR NA SEGUNDA


//Instrução usada para colocar anotações no cabeçalho do swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Filmes Tarde",
        Description = "API para gerenciamento de filmes - Introdução a SPRINT 2, BACK-END - API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Filipe Góis",
            Url = new Uri("https://github.com/Filipe-Gois")
        },
        License = new OpenApiLicense
        {
            Name = "Senai Informática - Turma Tarde",
            Url = new Uri("https://github.com/senai-desenvolvimento")
        }
    });

    //Configura o swagger para usar o XML
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
//Adicione o gerador do Swagger à coleção de serviços
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Habilite o middleware para atender ao documento JSON gerado e à interface do usuário do Swagger

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

//Mapear os controllers
app.MapControllers();
app.Run();
