using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.GoodManagement.Interfaces;
using BLL.Services.GoodManagement;
using DAL.Repository;
using DAL.Repository.Interface;
using megamart_api.BuildExtensions;
using megamart_api.Context;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("logs/logDay-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    Log.Information("------------------------------------------------------");
    Log.Information("------------------------------------------------------");
    Log.Information("Starting web application");

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog();


    string connection = builder.Configuration.GetConnectionString("MySql") ?? string.Empty;




    builder.Services.AddDbContext<MegamartContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));
    builder.Services.AddControllers();
    builder.Services.AddSwaggerGen();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSetSwagger();
    builder.Services.AddServices();
    builder.Services.AddSetSecurity(builder.Configuration);
    builder.Services.AddSetCors();
    builder.Services.AddSwaggerGen();
    builder.Services.AddAutoMapper(typeof(Program).Assembly);

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors(CorsInjection.PolicyName);

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}




