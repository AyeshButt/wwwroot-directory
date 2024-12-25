
var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(builder.Environment.EnvironmentName);
Console.WriteLine(builder.Environment.ApplicationName);
Console.WriteLine(builder.Environment.ContentRootPath);
Console.WriteLine(builder.Environment.WebRootPath);

var result = builder.Environment.IsProduction();
Console.WriteLine(result);

var webConfigurations = new WebApplicationOptions()
{
    WebRootPath = "TestRootDirectory"
};

var builder1 = WebApplication.CreateBuilder(webConfigurations);
Console.WriteLine(builder1.Environment.WebRootPath);

var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => "Hello World!!!");

app.Run();
