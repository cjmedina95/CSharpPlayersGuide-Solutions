/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Provide the x+1, x-1, y+1, y-1 of a given coordinate
**/

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
short row = Convert.ToInt16(Console.ReadLine());

Console.Write("Target Column? ");
short col = Convert.ToInt16(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({row}, {col - 1})");
Console.WriteLine($"({row - 1}, {col})");
Console.WriteLine($"({row}, {col + 1})");
Console.WriteLine($"({row + 1}, {col})");
Console.Beep();

Console.ResetColor();