/**
* Creator: Christian M.
* Date: September 16, 2023
* Description: Display an inventory and allow user to see an item's price with discount
**/

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
short selection = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter your name: ");
string name = Console.ReadLine();
bool discount = name == "Christian";

int price = selection switch
{
    1 => 10,
    2 => 16,
    3 => 24,
    4 => 2,
    5 => 20,
    6 => 200,
    7 => 2
};

if (discount) price /= 2;

string itemInfo = selection switch
{
    1 => $"Rope costs {price} gold.",
    2 => $"Torches cost {price} gold.",
    3 => $"Climbing Equipment costs {price} gold.",
    4 => $"Clean Water costs {price} gold.",
    5 => $"Machete costs {price} gold.",
    6 => $"Canoe costs {price} gold.",
    7 => $"Food Supplies cost {price} gold."
};

Console.WriteLine(itemInfo);