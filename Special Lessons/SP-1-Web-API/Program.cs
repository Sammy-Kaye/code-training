using Microsoft.AspNetCore.Mvc;

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

app.MapPost("/colours", ([FromBody] string colour) =>
{
    colours.Add(colour);
    return $"You added the colour: {colour}";
});

app.MapPut("/colours", ([FromBody] UpdateColourDto request) =>
{
    colours[colours.IndexOf(request.OldColour)] = request.NewColour;
    return $"You changed {request.OldColour} to {request.NewColour}";
});

app.MapDelete("/colours", ([FromBody] string colour) =>
{
    colours.Remove(colour);
    return $"You deleted: {colour}";
});

var Name = "Sam";
var JobTitle = "Developer";

app.MapGet("/greeting", () =>
{
    return $"Hello, my name is {Name} and I am a {JobTitle}.";
});

app.Run();

record UpdateColourDto(string OldColour, string NewColour);