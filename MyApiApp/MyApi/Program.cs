var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.UseHttpsRedirection();


app.MapGet("/hello", () =>
{
    Console.WriteLine(new { name = "Yo " });
    return new { name = "Fox",};
});


app.MapPost("/hello", () => new { name =  "Pablo", });

app.Run();