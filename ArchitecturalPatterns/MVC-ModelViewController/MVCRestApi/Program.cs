using MVCRestApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ProductStore>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();