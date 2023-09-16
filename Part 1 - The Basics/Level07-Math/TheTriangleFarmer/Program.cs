/**
 * Creator: Christian M.
 * Date: September 16, 2023
 * Description: Compute the area of a triangle
**/

Console.WriteLine("Input the triangle's base: ");
string input = Console.ReadLine();
float baseSize = Convert.ToSingle(input);

Console.WriteLine("Input the triangle's height: ");
input = Console.ReadLine();
float heightSize = Convert.ToSingle(input);

float area = (baseSize * heightSize) / 2;
Console.WriteLine("The area is: " + area);