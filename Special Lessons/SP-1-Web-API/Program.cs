var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var colours = new List<string>
{
    "Red", "Green", "Blue", "Yellow", "Purple"
};

app.MapGet("/colours", () =>
{
    return colours;
});

var Name = "Sam";
var JobTitle = "Developer";

app.MapGet("/greeting", () =>
{
    return $"Hello, my name is {Name} and I am a {JobTitle}.";
});

app.Run();