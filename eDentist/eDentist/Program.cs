using eDentist;
using eDentist.Filters;
using eDentist.Model.Models;
using eDentist.Model.SearchObjects;
using eDentist.Services;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using eDentist.Services.ProizvodiStateMachine;
using eDentist.Services.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<BaseState>();
builder.Services.AddTransient<InitialProductState>();
builder.Services.AddTransient<DraftProductState>();
builder.Services.AddTransient<ActiveProductState>();
builder.Services.AddTransient<IProductTypeService, ProductTypeService>();
builder.Services.AddTransient<IDentalService, DentalServiceService>();
builder.Services.AddTransient<IMedicalCardService, MedicalCardService>();
builder.Services.AddTransient<IAppointmentsService,AppointmentService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IOrderHeaderService, OrderHeaderService>();
builder.Services.AddTransient<IFavoriteService, FavoriteService>();
builder.Services.AddTransient<IRecommendResultService, RecommendResultService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
            },
            new string[]{}
    } });

});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EDentistDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(IUsersService));
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();