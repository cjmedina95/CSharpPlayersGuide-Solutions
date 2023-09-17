/**
* Creator: Christian M.
* Date: September 16, 2023
* Description: Array duplicator
**/

int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int[] numbersClone = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbersClone[i] = numbers[i];
}

for(int i = 0; i < numbersClone.Length; i++)
{
    Console.WriteLine($"Original number: {numbers[i]}");
    Console.WriteLine($"Cloned number: {numbersClone[i]}");
}