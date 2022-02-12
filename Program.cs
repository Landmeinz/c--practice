// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! C# Practice");

var name = "My name";
Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

// tuple example with key and value pair;
var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
var date = DateTime.Now;
Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");

// we can add modifies to the end of interpolated string variables;
// Try modifying the format strings in the example to see how they affect the formatting of the date and time and the numeric value. 
// Change the "d" in {date:d} to "t" (to display the short time format), "y" (to display the year and month), and "yyyy" (to display the year as a four-digit number). 
// Change the "C2" in {price:C2} to "e" (for exponential notation) and "F3" (for a numeric value with three digits after the decimal point).
Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
Console.WriteLine($"On {date:t}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
Console.WriteLine($"On {date:y}, the price of {item.Name} was {item.Price:e} per {item.perPackage} items.");



var inventory = new Dictionary<string, int>()
{
    ["hammer, ball pein"] = 18,
    ["hammer, cross pein"] = 5,
    ["screwdriver, Phillips #2"] = 14
};

Console.WriteLine($"  -- Inventory on {DateTime.Now:d} --");
Console.WriteLine($"| {"Item",-30} | {"Quantity",10} |");
foreach (var i in inventory)
    Console.WriteLine($"| {i.Key,-30} | {i.Value,10} |");

// You can combine an alignment specifier and a format string for a single interpolation expression. 
// To do that, specify the alignment first, followed by a colon and the format string. 
// Try the following code that displays three formatted strings with defined field widths:
Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");

Console.WriteLine("");

// You can embed any valid C# expression that returns a value in an interpolated string. 
// In the following example, as soon as an expression is evaluated, its result is converted into a string and included in a result string:

double a = 3;
double b = 4;
Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2));

// get access to pi or e;
Console.WriteLine($"{Math.PI:F3}");


var xs = new int[] { 1, 2, 7, 9 };
var ys = new int[] { 7, 9, 12 };
Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

var userName = "Jane";
var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
Console.WriteLine(stringWithEscapes);
Console.WriteLine(verbatimInterpolated);

// Expected output:
// Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
// C:\Users\Jane\Documents
// C:\Users\Jane\Documents