using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeApplication;
using FinancialLifeApplication.Interfaces.Nucleo.Localizacao;
using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeApplication.Services.Nucleo.Localizacao;
using FinancialLifeApplication.Services.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Factories.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.Repository.Nucleo.Localizacao;
using FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IPessoaFisicaAppService, PessoaFisicaAppService>();
builder.Services.AddScoped<IPessoaFisicaRepository, PessoaFisicaRepository>();

builder.Services.AddScoped<IPaisAppService, PaisAppService>();
builder.Services.AddScoped<IPaisRepository, PaisRepository>();

builder.Services.AddScoped<IFactory<PessoaFisica, PessoaFisicaDto>, PessoaFisicaFactory>();
builder.Services.AddScoped<IFactory<TelefonePessoa, TelefonePessoaDto>, TelefonePessoaFactory>();
builder.Services.AddScoped<IFactory<EmailPessoa, EmailPessoaDto>, EmailPessoaFactory>();
builder.Services.AddScoped<IFactory<EnderecoPessoa, EnderecoPessoaDto>, EnderecoPessoaFactory>();


builder.Services.AddControllers()
    .AddApplicationPart(typeof(FinancialLifeApplicationAssemblyReference).Assembly);

//Contexts
builder.Services.AddDbContext<FinancialLifeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
    options.EnableSensitiveDataLogging(); 
});


//SwaggerConfig
builder.Services.AddSwaggerGen(x => x.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" }));

var app = builder.Build();

app.UseCors(builder => builder
    .WithOrigins("https://localhost:5173")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
    c.RoutePrefix = "swagger";
}
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
