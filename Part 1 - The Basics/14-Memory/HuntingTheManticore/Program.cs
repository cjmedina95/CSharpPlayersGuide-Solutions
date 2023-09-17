int manticoreHealth = 10;
int cityHealth = 15;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int manticoreDistance = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");
int roundCounter = 1;

while (manticoreHealth > 0 && cityHealth > 0)
{
    printStatus(roundCounter, cityHealth, manticoreHealth);

    int damageAmount = primeCannon(roundCounter);

    Console.Write("The cannon is expected to ");

    switch(damageAmount)
    {
        case 3:
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            break;
        case 5:
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            break;
        default:
            Console.ResetColor();
            break;
    }

    Console.Write($"deal {damageAmount} damage");
    Console.ResetColor();
    Console.Write(" this round.\n");

    Console.Write("Enter the desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());

    manticoreHealth -= fireCannon(cannonRange, manticoreDistance, damageAmount);

    if (manticoreHealth > 0) cityHealth -= 1;
    roundCounter++;
}

if (manticoreHealth > 0)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("Game Over! The city of Consolas was destroyed by the Manticore!");
    Console.ResetColor();
    Console.Write("\n");
}
else
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("The Manticore has been destroyed! The city of Consolas has been saved!");
    Console.ResetColor();
    Console.Write("\n");
}

void printStatus(int roundCounter, int cityHealth, int manticoreHealth)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundCounter}\tCity: {cityHealth}/15\tManticore: {manticoreHealth}/10");
}

int primeCannon(int roundCounter)
{
    if (roundCounter % 3 == 0 && roundCounter % 5 == 0) return 5;
    else if (roundCounter % 3 == 0 || roundCounter % 5 == 0) return 3;
    return 1;
}

int fireCannon(int cannonRange, int manticoreDistance, int damageAmount)
{
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;

    if (cannonRange < manticoreDistance) Console.Write("That round FELL SHORT of the target.");
    else if (cannonRange > manticoreDistance) Console.Write("That round OVERSHOT the target.");
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("That round was a DIRECT HIT!");
        Console.ResetColor();
        Console.Write("\n");
        return damageAmount;
    }

    Console.ResetColor();
    Console.Write("\n");
    return 0;
}