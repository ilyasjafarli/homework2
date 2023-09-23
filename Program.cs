// See https://aka.ms/new-console-template for more information

// A
using System.Globalization;

Console.WriteLine("Tapsiriq A");

int score = -1;

if (score <= 100 && score >= 88)
{
    Console.WriteLine("Success - AA");
}
else if (score <= 88 && score >= 81)
{
    Console.WriteLine("Success - BA");
}

else if (score <= 81 && score >= 74)
{
    Console.WriteLine("Success - BB");
}

else if (score <= 74 && score >= 67)
{
    Console.WriteLine("Success - CB");
}

else if (score <= 67 && score >= 60)
{
    Console.WriteLine("Success - CC");
}

else if (score <= 60 && score >= 0)
{
    Console.WriteLine("Fail - FF");
}
else
{
    Console.WriteLine("Invalid");
}

// B

Console.WriteLine("Tapsiriq B");

string command = "emi";

switch (command)
{
    case "start":
        Console.WriteLine("Game is starting");
        break;
    case "stop":
        Console.WriteLine("Game stopped");
        break;
    case "wait":
        Console.WriteLine("Game paused");
        break;
    default:
        Console.WriteLine("Command not found");
        break;
}

// C

Console.WriteLine("Tapsiriq C");

int value = 1;
int limit = 15;
int sum = 0;

while (value <= limit)
{
    sum += value;
    value += 1;
}
Console.WriteLine(sum);

Console.WriteLine("Tapsiriq D");
// D

int eded = 3;

while (eded <= 100)
{ 
    if (eded % 3 == 0)
    { 
        Console.WriteLine(eded);
    }

    if (eded % 5 == 0)
    {
        Console.WriteLine(eded);
    }
    eded += 1;
}

