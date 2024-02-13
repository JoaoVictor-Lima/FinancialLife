using FinancialLifeAppService.Nucleo.Pessoas;
using FinancialLifeAppService.Nucleo.Pessoas.Interfaces;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;
using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPessoaAppService, PessoaAppService>();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();


builder.Services.AddControllers();

//Contexts
builder.Services.AddDbContext<PessoaDbContext>
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
