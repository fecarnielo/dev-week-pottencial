using Microsoft.EntityFrameworkCore;
using src.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddDbContext<DatabaseContext>(o => o.UseInMemoryDatabase
    ("dbContracts"));
builder.Services.AddScoped<DatabaseContext, DatabaseContext>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
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
