
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();

Console.WriteLine("How old are you?");
string? input = Console.ReadLine();
int age = int.Parse(input ?? "0");

string GetGreeting(string? name, int age)
{
   string result = age >= 18  ? $"Hello, {name}! You are an adult." : $"Hello, {name}! You are a minor.";
   return result;
   
}

string output = GetGreeting(name, age);
Console.WriteLine(output);
