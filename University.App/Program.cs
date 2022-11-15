using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using University.Infrastructure;
using University.Infrastructure.Extensions;
using University.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationContext>(options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("UniversityDb")),
    contextLifetime: ServiceLifetime.Transient, 
    optionsLifetime: ServiceLifetime.Singleton
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddUniversityInfrastructure();
builder.Services.AddUniversityServices();

builder.Services.AddHostedService<CreateDbHostService>();



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