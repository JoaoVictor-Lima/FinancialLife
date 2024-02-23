using FinancialLifeApplication;
using FinancialLifeApplication.Intrefaces.Nucleo.Localizacao;
using FinancialLifeApplication.Intrefaces.Nucleo.Pessoas;
using FinancialLifeApplication.Services.Nucleo.Localizacao;
using FinancialLifeApplication.Services.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.Repository.Nucleo.Localizacao;
using FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IPessoaFisicaAppService, PessoaFisicaAppService>();
builder.Services.AddScoped<IPessoaFisicaRepository, PessoaFisicaRepository>();

builder.Services.AddScoped<IPaisAppService, PaisAppService>();
builder.Services.AddScoped<IPaisRepository, PaisRepository>();


builder.Services.AddControllers()
    .AddApplicationPart(typeof(FinancialLifeApplicationAssemblyReference).Assembly);

//Contexts
builder.Services.AddDbContext<FinancialLifeDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

app.UseCors(builder => builder
    .WithOrigins("https://localhost:5173")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
