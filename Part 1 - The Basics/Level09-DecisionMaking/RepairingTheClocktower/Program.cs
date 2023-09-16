/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Display whether a number is even or odd
**/

Console.Write("Enter a number: ");
short num = Convert.ToInt16(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}