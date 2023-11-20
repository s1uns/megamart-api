using BLL.Services.CategoryManager;
using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.GenericService;
using BLL.Services.GenericService.Interfaces;
using BLL.Services.GoodManagement.Interfaces;
using BLL.Services.GoodManagement;
using DAL.Repository;
using DAL.Repository.Interface;
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


    //Repository
    builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

    //Services
    builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
    builder.Services.AddScoped<ICategoryService, CategoryService>();
    builder.Services.AddScoped<IGoodService, GoodService>();


    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}




