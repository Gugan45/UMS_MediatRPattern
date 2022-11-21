using Autofac;
using Autofac.Extensions.DependencyInjection;
using Domain.Repositories;
using Infrastructure.Context;
using Infrastructure.Domain;
using Infrastructure.Repositories;
using MediatR;
using MongoDBConfiguration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new DomainModule()));

builder.Services.Configure<UserDBSettings>(builder.Configuration.GetSection("UserDBSettings"));

builder.Services.AddTransient<IUMSContext,UMSContext>();
builder.Services.AddTransient<IUnitofWork,UnitofWork>();

builder.Services.AddMediatR(typeof(Program).Assembly);

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (options) =>
    {
        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

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
