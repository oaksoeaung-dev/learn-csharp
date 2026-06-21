Console.WriteLine("Hello!");
Console.Write("Input the first number: ");
var num1 = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
var num2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dds numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ulti numbers");

var choice = Console.ReadLine()?.ToLower();

switch (choice)
{
    case "a":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "s":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case "m":
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    default:
        Console.WriteLine("Invalid command");
        break;
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();