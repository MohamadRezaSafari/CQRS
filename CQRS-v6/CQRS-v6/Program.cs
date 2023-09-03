using System.Reflection;
using CQRS_v6.Data;
using CQRS_v6.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<ApplicationContext>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
