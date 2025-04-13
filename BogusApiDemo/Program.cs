using BogusApiDemo.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register Bogus fake user service
builder.Services.AddSingleton<FakeUserService>();

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer(); // enables minimal APIs & Swagger docs
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Bogus API Demo",
        Version = "v1"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();            // generate Swagger JSON
    app.UseSwaggerUI();          // show Swagger UI in browser
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
