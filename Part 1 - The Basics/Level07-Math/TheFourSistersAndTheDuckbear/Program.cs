/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Displays the quotient and remainder of 4 by any number
**/

Console.WriteLine("Enter the number of eggs gathered today: ");
short eggs = Convert.ToInt16(Console.ReadLine());

int sisterEggs = eggs / 4;
int duckbearEggs = eggs % 4;

Console.WriteLine("The number of eggs per sister is: " + sisterEggs);
Console.WriteLine("And what's left for the duckbear: " + duckbearEggs);
