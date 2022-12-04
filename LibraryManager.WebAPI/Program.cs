using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(
    builder.Configuration.GetConnectionString("LibraryConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddIdentity<User, IdentityRole<int>>()
   .AddEntityFrameworkStores<LibraryContext>()
   .AddDefaultTokenProviders();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
