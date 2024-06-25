using FinacialLifeDtos.Core.People;
using FinancialLifeApplication;
using FinancialLifeApplication.Interfaces.Core.Location;
using FinancialLifeApplication.Interfaces.Core.People;
using FinancialLifeApplication.Services.Core.Location;
using FinancialLifeApplication.Services.Core.Person;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Factories.Core.People;
using FinancialLifeDomain.Interfaces.Repository.Core.Location;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.Repository.Core.Location;
using FinancialLifeInfrastructureData.Repository.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<INaturalPersonAppService, NaturalPersonAppService>();
builder.Services.AddScoped<INaturalPersonRepository, NaturalPersonRepository>();

builder.Services.AddScoped<ICountryAppService, CountryAppService>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();

builder.Services.AddScoped<IFactory<NaturalPerson, NaturalPersonDto>, NaturalPersonFactory>();
builder.Services.AddScoped<IFactory<PhonePerson, PhonePersonDto>, PhonePersonFactory>();
builder.Services.AddScoped<IFactory<EmailPerson, EmailPersonDto>, EmailPersonFactory>();
builder.Services.AddScoped<IFactory<PersonAddress, PersonAddressDto>, PersonAddressFactory>();


builder.Services.AddControllers()
    .AddApplicationPart(typeof(FinancialLifeApplicationAssemblyReference).Assembly)
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.NumberHandling =
            JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString;

        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

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
