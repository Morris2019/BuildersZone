using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer(); // Only call once
builder.Services.AddSwaggerGen(c =>        // Configure here BEFORE building
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "BuilderZone API",
        Version = "v1",
        Description = "API for BuilderZone platform",
        Contact = new OpenApiContact { Name = "Your Name", Email = "neo2morris@live.com" }
    });
    
    // Include XML comments
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath)) 
        c.IncludeXmlComments(xmlPath);
});

var app = builder.Build(); // THIS MUST COME AFTER ALL SERVICE REGISTRATIONS

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BuilderZone API v1");
    });
}

app.UseHttpsRedirection();

// ... your weather forecast endpoint ...

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}