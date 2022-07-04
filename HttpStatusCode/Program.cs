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
var constr = builder.Configuration.GetConnectionString("WebApiDb");
builder.Services.AddDbContext<SqlDbcontext>(options =>
{
    options.UseSqlServer(constr);
});
//category Servisini Container icerisine register ediyoruz
builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();
builder.Services.AddScoped<ISehirDAL, SehirDAL>();
builder.Services.AddScoped<IilceDAL, IlceDAL>();

//builder.Services.AddSwaggerGen(opt =>
//{
//    opt.SwaggerDoc("RestFulApiDoc", new OpenApiInfo()
//    {
//        Title = "Restfull API Örnek Dökümani",
//        Version = "v1",
//        Description = "Restfull örnekleri",
//        Contact = new OpenApiContact()
//        {
//            Name = "Ali Yilmaz",
//            Email = "ali@yilmaz.com",
//            Url = new Uri("https://github.com/")
//        }
//    });
//    var xmlCommentFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    var xmlCommentFullName = Path.Combine(AppContext.BaseDirectory, xmlCommentFile);
//    opt.IncludeXmlComments(xmlCommentFullName);
//});

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