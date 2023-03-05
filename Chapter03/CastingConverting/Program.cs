using static System.Convert;

// int a = 10;
// double b = a;
// System.Console.WriteLine(b);

// double c = 9.8;
// int d = (int)c;
// System.Console.WriteLine(d);

// long e = 10;
// int f = (int)e;
// System.Console.WriteLine($"e is {e:N0} and f is {f:N0}");

// e = long.MaxValue;
// f = (int)e;
// System.Console.WriteLine($"e is {e:N0} and f is {f:N0}");

// double g = 9.8;
// int h = ToInt32(g);
// System.Console.WriteLine($"g is {g} & h is {h}");

// double[] doubles = new[] {9.49, 9.51, 10.49, 10.5, 10.51};

// foreach (double n in doubles)
// {
//     System.Console.WriteLine($"ToInt32({n}) is {ToInt32(n)}");
// }

System.Console.Write("how many eggs are there?");

string? input = System.Console.ReadLine();

if (int.TryParse(input, out int count))
{
    System.Console.WriteLine($"there are {count} eggs.");
}
else
{
    System.Console.WriteLine("cannot parse input.");
}