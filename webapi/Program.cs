using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.Add(new ServiceDescriptor(typeof(RecipeService), ServiceLifetime.Singleton)); // I hope this is how you register the class to be dependency injected at startup

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("Default"));
});
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

app.Run();
