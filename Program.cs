// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World");

Console.Write("Zahl 1: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Zahl 2: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraktion: " + (a - b));
Console.WriteLine("Multiplikation: " + (a * b));
Console.WriteLine("Division: " + (a / b));

Console.ReadLine();
