string [] names = {"Kate", "Jack", "Rebecca", "Tom"}; // 1 dimension

// for (int i = 0; i < names.Length; i++)
// {
//     System.Console.WriteLine(names[i]);
// }

// foreach (string n in names)
// {
//     System.Console.WriteLine(n);
// }

string[,] grid1 = new[,] // 2 dimensions
{
    {"alpha", "beta", "gamma", "delta"},
    {"anne", "ben", "charlie", "doug"},
    {"aardvark", "bear", "cat", "dog"}
};

// System.Console.WriteLine(grid1.GetLowerBound(0));
// System.Console.WriteLine(grid1.GetUpperBound(0));

// System.Console.WriteLine(grid1.GetLowerBound(1));
// System.Console.WriteLine(grid1.GetUpperBound(1));

// for (int row = 0; row <= grid1.GetUpperBound(0); row++)
// {
//     for (int col = 0; col <= grid1.GetUpperBound(1); col++)
//     {
//         System.Console.WriteLine($"row {row}, col {col}: {grid1[row, col]}");
//     }
// }

string[][] jagged = new[] // array of arrays (JAGGED = diff num of items in each dimension)
{
    new[] {"alpha", "beta", "gamma"},
    new[] {"anne", "ben", "charlie", "doug"},
    new[] {"aadvark", "bear"}
};

// System.Console.WriteLine($"upper bound of array of arrays: {jagged.GetUpperBound(0)}");

// for (int array = 0; array <= jagged.GetUpperBound(0); array++)
// {
//     System.Console.WriteLine($"upper bound of array {array} is {jagged[array].GetUpperBound(0)}");
// }

// for (int row = 0; row <= jagged.GetUpperBound(0); row++)
// {
//     for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
//     {
//         System.Console.WriteLine($"row {row}, col {col}: {jagged[row][col]}");
//     }
// }

// list pattern matching with arrays
int[] sequentialNumbers = new int[] {1,2,3,4,5,6,7,8,9,10};
int[] oneTwoNumbers = new int[] {1,2};
int[] oneTwoTenNumbers = new int[] {1,2,10};
int[] oneTwoThreeTenNumbers = new int[] {1,2,3,10};
int[] primeNumbers = new int[] {2,3,5,7,11,13,17,19,23,29};
int[] fibonacciNumbers = new int[] {0,1,1,2,3,5,8,13,21,34,55,89};
int[] emptyNumbers = new int[] {};
int[] threeNumbers = new int[] {9,7,5};
int[] sixNumbers = new int[] {9,7,5,4,2,10};

System.Console.WriteLine($"{nameof(sequentialNumbers)}:{CheckSwitch(sequentialNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoNumbers)}:{CheckSwitch(oneTwoNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoTenNumbers)}:{CheckSwitch(oneTwoTenNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}:{CheckSwitch(oneTwoThreeTenNumbers)}");
System.Console.WriteLine($"{nameof(primeNumbers)}:{CheckSwitch(primeNumbers)}");
System.Console.WriteLine($"{nameof(fibonacciNumbers)}:{CheckSwitch(fibonacciNumbers)}");
System.Console.WriteLine($"{nameof(emptyNumbers)}:{CheckSwitch(emptyNumbers)}");
System.Console.WriteLine($"{nameof(threeNumbers)}:{CheckSwitch(threeNumbers)}");
System.Console.WriteLine($"{nameof(sixNumbers)}:{CheckSwitch(sixNumbers)}");


static string CheckSwitch(int[] values) => values switch
{
    [] => "empty array",
    [1,2,_,10] => "contains 1, 2, any single number, 10.",
    [1,2,..,10] => "contains 1, 2, any range including empty, 10.",
    [1,2] => "contains 1 then 2.",
    [int item1, int item2, int item3] => $"contains {item1} then {item2} then {item3}.",
    [0, _] => "starts with 0 then one other number.",
    [0, ..] => "starts with 0 the any range of numbers.",
    [2, .. int[] others] => $"starts with 2 then {others.Length} more numbers.",
    [..] => "any items in any order",
};
