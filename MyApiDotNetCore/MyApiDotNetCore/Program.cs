var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();



app.UseHttpsRedirection();


app.MapGet("/fox", () =>

{
    return new { name = "Fox", };
});


app.Run();
