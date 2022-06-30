using HttpStatusCode.Infrastructure.Context;
using HttpStatusCode.Infrastructure.Repository.Abstract;
using HttpStatusCode.Infrastructure.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlDbcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDb"));
});
//category servisini container icerisine register ediyoruz.
builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
