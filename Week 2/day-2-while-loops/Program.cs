Console.WriteLine("Please enter Password");

string? userInput = Console.ReadLine();
string? password = "letmein";

while (userInput != password)
{
    Console.WriteLine("Wrong Password, try again");
    userInput = Console.ReadLine();
}

Console.WriteLine("Access Granted");