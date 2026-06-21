Console.WriteLine("First C# App");
Console.WriteLine("Hello, World!");
Console.WriteLine();

foreach (var i in args)
{
    Console.WriteLine($"Args: {i}");
}

Console.ReadLine();
return 0;