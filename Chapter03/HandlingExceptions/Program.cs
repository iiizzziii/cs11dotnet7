System.Console.WriteLine("before parsing");

System.Console.Write("whats your age?   ");

string? input = System.Console.ReadLine()!;

try
{
    int age = int.Parse(input);
    System.Console.WriteLine($"you are {age} years old.");
}
catch (OverflowException)
{
    System.Console.WriteLine("age is valid but too big/small.");
}
catch (FormatException)
{
    System.Console.WriteLine("age entered is not in valid format.");
}
catch (Exception ex)
{
    System.Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}
System.Console.WriteLine("after parsing");