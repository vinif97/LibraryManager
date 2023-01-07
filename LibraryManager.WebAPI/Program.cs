using LibraryManager.Infrastructure.IoC;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
#region CustomDependencyInjection
builder.Services.AddSqlInfrastructure(builder.Configuration);
builder.Services.AddIdentity();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddMappers();
#endregion CustomDependencyInjection
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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
