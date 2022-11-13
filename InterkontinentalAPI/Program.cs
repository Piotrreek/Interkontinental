using InterkontinentalAPI.Entities;
using InterkontinentalAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<InterkontinentalContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("InterkontinentalDb")));
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Front",
        builder =>
        {
            builder.WithOrigins("http://127.0.0.1:5500");
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("Front");

app.UseAuthorization();

app.MapControllers();

app.Run();
