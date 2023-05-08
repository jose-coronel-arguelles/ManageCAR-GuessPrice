using KForce.Service.API;
using KForce.Service.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.ConfigureSwagger();
builder.Services.ConfigureEmbeddedServices();
builder.Services.ConfigureDatabase();
builder.Services.ConfigureCustomServices();
var app = builder.Build();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin  
    .AllowCredentials());               // allow credentials 


// Configure the HTTP request pipeline.
//app.UseCors(appBuilder => appBuilder.AllowAnyOrigin());
app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();