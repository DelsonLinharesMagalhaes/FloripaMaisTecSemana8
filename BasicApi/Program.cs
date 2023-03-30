using BasicApi.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.MapGet("/Clientes/{id}", ([FromQuery]string nome, [FromRoute]int id) => "Olá " + nome + " seu Id é " + id);

var carros = new List<string>();
carros.Add("Gol");
carros.Add("Fusca");
carros.Add("Uno");

app.MapGet("/veiculos/", ([FromQuery]string carro) => 
    {   if (string.IsNullOrEmpty(carro)){
            return Results.Ok(carros);}
        if (carros.Exists(x => x == carro)){
            return Results.Ok("Carro cadastrado");
        } else {
            return Results.NoContent();
        }

    });

app.MapPost("/veiculos/", ([FromQuery]string carro) => {carros.Add(carro); Results.Ok();});

app.MapDelete("/veiculos/", ([FromQuery]string carro) => {carros.Remove(carro); Results.Ok();});

app.Run();
