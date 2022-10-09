using Datos.Auditoria.Modelo;
using Microsoft.Extensions.DependencyInjection;
using Negocio.Auditoria;
using Negocio.Auditoria.Contratos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOracle<ContextoDbAuditoria>(builder.Configuration.GetConnectionString("DbAuditoria"));
//IoC
builder.Services.AddTransient<IAuditoriaBL, AuditoriaBL>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
