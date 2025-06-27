using Microsoft.EntityFrameworkCore;
using WebApi.XmlImportar.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddDbContext<DbContextXml>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DbContextXml")));

builder.Services.AddControllers();

var app = builder.Build();

// Configuração do pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
