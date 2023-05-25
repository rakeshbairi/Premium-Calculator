using PremiumCalculator.Infrastructure.Common;
using PremiumCalculator.Infrastructure.Services;
using PremiumCalculator.Infrastructure.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDeathPremiumCalculate, DeathPremiumService>();
builder.Services.AddScoped<ITPDPremiumCalculate, TPDPremiumService>();

var services = builder.Services;
services.AddCors();
//services.AddTransient<ServiceResolver>(serviceProvider => serviceTypeName =>
//{
//    switch (serviceTypeName)
//    {
//        case PremiumType.Death:
//            return serviceProvider.GetService<DeathPremiumService>();
//        case PremiumType.TPD:
//            return serviceProvider.GetService<TPDPremiumService>();

//        default:
//            return null;
//    }
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
