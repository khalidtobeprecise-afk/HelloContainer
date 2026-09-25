var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World from .NET 10 - Version 3, get te image from the git hub ");

app.Run();
