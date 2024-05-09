
using ProductionManager.Api;
using ProductionManager.Application;
using ProductionManager.Domain.Utils;
using ProductionManager.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var constr = GetConnectionstringName.GetConnectionStrName(Environment.MachineName);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAPIServices(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);

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
