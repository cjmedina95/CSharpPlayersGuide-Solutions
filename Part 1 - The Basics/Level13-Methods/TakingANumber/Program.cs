int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine(text);
    int val = Convert.ToInt32(Console.ReadLine());
    while (val < min || val > max)
    {
        Console.WriteLine(text);
        val = Convert.ToInt32(Console.ReadLine());
    }

    return Convert.ToInt32(Console.ReadLine());
}

int arraySize = AskForNumberInRange("How many numbers do you want to duplicate (1 - 10)?", 1, 10);
int[] numbers = new int[arraySize];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = AskForNumber("Enter a number: ");
}

int[] numbersClone = new int[arraySize];

for (int i = 0; i < numbers.Length; i++)
{
    numbersClone[i] = numbers[i];
}

for (int i = 0; i < numbersClone.Length; i++)
{
    Console.WriteLine($"Original number: {numbers[i]}");
    Console.WriteLine($"Cloned number: {numbersClone[i]}");
}