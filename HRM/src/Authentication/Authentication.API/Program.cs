<<<<<<< Updated upstream
using Authentication.API.Data;
using Authentication.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
=======
﻿var builder = WebApplication.CreateBuilder(args);
>>>>>>> Stashed changes

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

<<<<<<< Updated upstream

builder.Services.AddDbContext<AuthenticationDbContext>
(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("AuthenticationDbConnection"))
);

// Specific to Identity Database
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<AuthenticationDbContext>()
    .AddDefaultTokenProviders();

=======
>>>>>>> Stashed changes
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
