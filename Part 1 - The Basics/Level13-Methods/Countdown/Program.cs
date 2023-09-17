/**
* Creator: Christian M.
* Date: September 17, 2023
* Description: Recursion example
**/

int recursiveTest(int val)
{
    if (val == 0) return 0;
    Console.WriteLine(val);
    return recursiveTest(val - 1);
}

recursiveTest(10);