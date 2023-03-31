<<<<<<< Updated upstream
var builder = WebApplication.CreateBuilder(args);
=======
﻿var builder = WebApplication.CreateBuilder(args);
>>>>>>> Stashed changes

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

<<<<<<< Updated upstream
app.Run();
=======
app.Run();

>>>>>>> Stashed changes
