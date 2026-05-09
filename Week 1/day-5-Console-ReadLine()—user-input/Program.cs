Console.WriteLine("What is your name?");
string? name = Console.ReadLine();

Console.WriteLine("How old are you?");
string? input = Console.ReadLine();
int age = int.Parse(input ?? "0");


string GetGreeting(string? name, int age)
{
    return $"Hello, {name}! You are {age} years old.";
}


Console.WriteLine(GetGreeting(name, age));