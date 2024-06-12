using Business;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TurContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-N1QFE9C\\SQLEXPRESS;Database=TurContext;Trusted_Connection=True;TrustServerCertificate=True;");
});
builder.Services.AddScoped<TurService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

