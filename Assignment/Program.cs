using Assignment;

Console.WriteLine("=== Simple Calculator Demo ===");

try
{
    Console.Write("Enter A: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Enter B: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Enter operation (+, -, *, /): ");
    char op = Console.ReadLine()[0];

    var calc = new Calculator(a, b, op);

    double result = calc.Calculate();

    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}