using static System.Convert;

System.Console.Write("enter number 0 - 255:   ");
string first = System.Console.ReadLine()!;

System.Console.Write("enter another number 0 - 255:   ");
string second = System.Console.ReadLine()!;

try
{
    int one = ToInt32(first);
    int two = ToInt32(second);
    int result = one / two;
    System.Console.WriteLine($"{one.ToString()} / {two.ToString()} = {result.ToString()}");
}
catch (FormatException)
{
    System.Console.WriteLine("wrong format");
}