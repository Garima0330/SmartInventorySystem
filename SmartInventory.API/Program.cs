using Microsoft.EntityFrameworkCore;
using SmartInventory.Data;
using SmartInventory.Data.Interfaces;
using SmartInventory.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Register services *before* building
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
         options.JsonSerializerOptions.WriteIndented = true;
     });

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DI for Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// 2️⃣ Then build the app
var app = builder.Build();

// 3️⃣ Middleware configuration
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
