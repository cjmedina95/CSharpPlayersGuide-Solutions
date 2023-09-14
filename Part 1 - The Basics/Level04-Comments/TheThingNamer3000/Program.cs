// Objectives:
/**
 * Add comments near each of the four variables that describe what they store. 
   You must use at leastone of each comment type
 * Find the bug in the text displayed and fix it.
 * Answer this question: Aside from comments, 
   what else could you do to make this code more understandable?
**/

/**
 * Creator: Christian M.
 * Date: September 14, 2023
 * Description: Get a name and an adjective to describe a thing
**/
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // Noun
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // Adjective
string c = "of Doom"; // String literal
string d = "3000"; // String literal
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

// Things to improve the program:
/**
 * Remove the string literals c and d
 * Rename the remaining two strings to be more descriptive
**/