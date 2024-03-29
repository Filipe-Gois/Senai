using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        // Ignora os loopings nas consultas
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        // Ignora valores nulos ao fazer jun��es nas consultas
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    }
);


//Adiciona servi�o de autentica��o JWT Bearer - token por json
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})

//Define os par�metros de valida��o do token (continua��o acima)
.AddJwtBearer("JwtBearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        //Valida quem est� solicitando
        ValidateIssuer = true,

        //Valida quem est� recebendo
        ValidateAudience = true,

        //Define se o tempo de expira��o do token ser� validado
        ValidateLifetime = true,

        //Forma de criptografia e a valida��o da chave de autentica��o
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("inlock-chave-autenticacao-webapi-dev_codeFirst")),

        //Valida o tempo de expira��o do token
        ClockSkew = TimeSpan.FromMinutes(5),

        //De onde est� vindo (qual o issure)
        ValidIssuer = "senai.inlock.webApi_codeFirst",

        //Para onde est� indo (qual o audiece)
        ValidAudience = "senai.inlock.webApi_codeFirst"
    };


});






// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Adiciona o gerador do Swagger � cole��o de servi�os
builder.Services.AddSwaggerGen(options =>
{
    //options.SwaggerDoc("v1", new OpenApiInfo
    //{
    //    //Vers�o da API
    //    Version = "v1",

    //    //T�tulo da API
    //    Title = "API Inlock",

    //    //Descri��o da API
    //    Description = "API para gerenciamento de jogos e suas informa��es.",

    //    //Termos de servi�o
    //    TermsOfService = new Uri("https://example.com/terms"),

    //    //Contatos do desenvolvedor
    //    Contact = new OpenApiContact
    //    {
    //        Name = "Filipe G�is",
    //        Url = new Uri("https://github.com/Filipe-Gois")
    //    },

    //    //Lincen�a da aplica��o
    //    License = new OpenApiLicense
    //    {
    //        Name = "Example License",
    //        Url = new Uri("https://example.com/license")
    //    }
    //});

    //Configura o Swagger para usar o arquivo XML
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    //Usando a autoriza��o no Swagger
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Values: Bearer TokenJWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
