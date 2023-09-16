/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Counts the point total for provinces (6), duchies (3), and estates (1)
**/

int points = 0;

Console.WriteLine("Enter your number of provinces: ");
short provinces = Convert.ToInt16(Console.ReadLine());

points += provinces * 6;

Console.WriteLine("Enter your number of duchies: ");
short duchies = Convert.ToInt16(Console.ReadLine());

points += duchies * 3;

Console.WriteLine("Enter your number of estates: ");
short estates = Convert.ToInt16(Console.ReadLine());

points += estates;

Console.WriteLine("Your point total is: " + points);
