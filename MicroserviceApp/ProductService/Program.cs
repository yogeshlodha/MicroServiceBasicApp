using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// setup swagger service for product application.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "product Service API",
        Version = "v1",
        Description = "A simple example of swagger API information",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Yogesh",
            Email = "yogesh@test.com",
            Url = new Uri("https://example.com")
        }
    });

    // Add API comments to swagger UI.
    var fielName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
    var filePath = Path.Combine(AppContext.BaseDirectory, fielName);
    c.IncludeXmlComments(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        c.RoutePrefix = string.Empty; ;
        c.DocumentTitle = "Product API";
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
