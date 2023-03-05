partial class Program
{


    static void TimesTable(byte number, byte size = 12)
    {
        System.Console.WriteLine($"{number} times table with {size} rows");

        for (int row = 1; row <= size; row++)
        {
            System.Console.WriteLine($"{row} x {number} = {row * number}");
        }
        System.Console.WriteLine();
    }


    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";

            default:
                int lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }


    static void RunCardinalToOriginal()
    {
        for (int number = 1; number <= 150; number++)
        {
            System.Console.Write($"{CardinalToOrdinal(number)} ");
        }
        System.Console.WriteLine();
    }


    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new System.ArgumentException(message:
            $"factorial is for non-negative ints only. input: {number}, parameter: nameof(number)");
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        checked
        {
            return number * Factorial(number - 1);
        }
    }


    static void RunFactorial()
    {
        for (int i = 1; i <= 15; i++)
        {
            System.Console.WriteLine($"{i}! = {Factorial(i):N0}");
        }
    }


    static int FibImperative(int term)
    {
        if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }


    static void RunFibImperative()
    {
        for (int i = 1; i <= 30; i++)
        {
            System.Console.WriteLine($"{CardinalToOrdinal(i)} term of the fib. seq. is {FibImperative(term: i)}");
        }
    }


    static int FibFunctional(int term) => term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term -2)
    };


    static void RunFibFunctional()
    {
        for (int i = 1; i <= 30; i++)
        {
            System.Console.WriteLine($"{CardinalToOrdinal(i)} term of the fib. seq. is {FibFunctional(term: i)}");
        }
    }

}
