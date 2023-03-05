int x = int.MaxValue - 1;
System.Console.WriteLine($"initial value: {x}");

try
{
    checked
    {
    x++;
    System.Console.WriteLine($"after incrementing: {x}");
    x++;
    System.Console.WriteLine($"after incrementing: {x}");
    x++;
    System.Console.WriteLine($"after incrementing: {x}");
    }
}
catch (OverflowException)
{
    System.Console.WriteLine("code overflowed...exception caught");
}

