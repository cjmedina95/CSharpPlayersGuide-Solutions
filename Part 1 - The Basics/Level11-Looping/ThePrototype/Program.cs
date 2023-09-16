/**
* Creator: Christian M.
* Date: September 16, 2023
* Description: High/low guessing game
**/

Console.Write("User 1, enter a number between 0 and 100: ");
short target = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine("User 2, guess the number.");
short guess = -1;
while (guess != target)
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt16(Console.ReadLine());

    if (guess > target)
    {
        Console.WriteLine($"{guess} is too high.");
    }
    else if (guess < target)
    {
        Console.WriteLine($"{guess} is too low.");
    }
}

Console.WriteLine("You guessed the number!");