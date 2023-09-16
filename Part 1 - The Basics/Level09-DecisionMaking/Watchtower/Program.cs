/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Displays the relative position of (x, y) to (0, 0)
**/

Console.Write("Enter an x-coordinate: ");
short x = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter a y-coordinate: ");
short y = Convert.ToInt16(Console.ReadLine());

if (x < 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the southwest!");
    }
    else
    {
        Console.WriteLine("The enemy is to the west!");
    }
}
else if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
    else
    {
        Console.WriteLine("The enemy is to the east!");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is to the north!");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is to the south!");
    }
    else
    {
        Console.WriteLine("The enemy is here!");
    }
}