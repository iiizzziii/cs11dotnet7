
for (int i = 0; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}
