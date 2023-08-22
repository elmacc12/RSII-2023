using eDentist.Model.Models;
using eDentist.Model.SearchObjects;
using eDentist.Services;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using eDentist.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICountryService, CountryService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EDentistDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(IUsersService));

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
