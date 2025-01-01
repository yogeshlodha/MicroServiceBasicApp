using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json",optional:false,reloadOnChange:true);
builder.Services.AddOcelot(builder.Configuration);
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
//    {
//        Title = "My Test API",
//        Version = "v1"
//    });
//});

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//    app.UseSwagger();
//    app.UseSwaggerUI(c=>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//        c.RoutePrefix = string.Empty; ;
//        c.DocumentTitle = "My API";
//    });
//}

app.MapGet("/", () => "Hello World!");

await app.UseOcelot();
app.Run();
