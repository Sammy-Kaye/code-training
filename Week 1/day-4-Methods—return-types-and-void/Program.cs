void PrintDeveloperStatus()
{
    bool isDeveloper = true;
     if (isDeveloper == true)
    {
        Console.WriteLine("Sammy is a developer: True");
    }
}

bool getDeveloperStatus()
{
    bool isDeveloper = true;
    return isDeveloper;
}

PrintDeveloperStatus();

if (getDeveloperStatus() == true)
{
    Console.WriteLine("Developer status: True");
}