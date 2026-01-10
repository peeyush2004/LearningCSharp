Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());

// IMPORTANT: spacing must match exactly
Console.WriteLine("Choose an operation: +, -, *, /");
string ops = Console.ReadLine();

if (ops == "+")
{
	Console.WriteLine("Result: " + (num1 + num2));
}
else if (ops == "-")
{
	Console.WriteLine("Result: " + (num1 - num2));
}
else if (ops == "*")
{
	Console.WriteLine("Result: " + (num1 * num2));
}
else if (ops == "/")
{
	if (num2 == 0)
	{
		Console.WriteLine("Error: Division by zero is not allowed.");
	}
	else
	{
		Console.WriteLine("Result: " + (num1 / num2));
	}
}
else
{
	Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}