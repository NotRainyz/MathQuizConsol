// Console Settings
Console.Title = "Math Quiz!";
Console.ForegroundColor = ConsoleColor.Magenta;

// Welcome Message
Console.WriteLine("Hello! Welcome to the math quiz! Are you ready?");

string? response = Console.ReadLine();

if (response == "yes")
{
    Console.WriteLine("Good Luck!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Out of here bozo!");
    Environment.Exit(0);
}

// Math Problems
Console.ForegroundColor = ConsoleColor.DarkRed;

// 1)
Console.WriteLine("What is, 2 + 2 * 17 + 38?");

string? answer1 = Console.ReadLine();

if (answer1 == "74")
{
    Console.WriteLine("Correct! On to the next question.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Out of here bozo!");
    Environment.Exit(0);
}
// 2)
Console.WriteLine("What is, 32^2 + 17 * 13?");

string? answer2 = Console.ReadLine();

if (answer2 == "1245")
{
    Console.WriteLine("Correct! On to the next question.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Out of here bozo!");
    Environment.Exit(0);
}

// 3)
Console.WriteLine("What is, the square root of 1245? Simplify to a whole number if needed.");

string? answer3 = Console.ReadLine();

if (answer3 == "35")
{
    Console.WriteLine("Correct! On to the next question.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Out of here bozo!");
    Environment.Exit(0);
}

// 4)
Console.WriteLine("What is, 17^4 + 13 * 9 * 0 + 535?");

string? answer4 = Console.ReadLine();

if (answer4 == "535")
{
    Console.WriteLine("Correct! On to the next question.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Out of here bozo!");
    Environment.Exit(0);
}

// 5)
Console.WriteLine("Final Question! What is, 11^2 + 13");

string? answer5 = Console.ReadLine();

if (answer5 == "134")
{
    Console.WriteLine("Ding Ding Ding! Winner Winner Chicken Dinner!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("So Close! Cya Bozo");
    Environment.Exit(0);
}

// Congrats Message
Console.WriteLine("Congrats! You get....... Nothing!");
Thread.Sleep(500);
// End
Console.ReadLine();