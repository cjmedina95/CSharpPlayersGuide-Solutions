/**
* Creator: Christian M.
* Date: September 16, 2023
* Description: FizzBuzz
**/

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{i}: Combined");
        Console.ResetColor();
        Console.Write("\n");
    }
    else if (i % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{i}: Fire");
        Console.ResetColor();
        Console.Write("\n");
    }
    else if (i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($"{i}: Electric");
        Console.ResetColor();
        Console.Write("\n");
    }
    else
    {
        Console.WriteLine($"{i}: Normal");
    }
}