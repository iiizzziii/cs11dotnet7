
int x = 0;

while (x < 10)
{
    System.Console.WriteLine(x);
    x++;
}

// ----------------------------

// string? password;
// int counter = 0;

// do
// {
//     System.Console.WriteLine("enter password: ");
//     password = Console.ReadLine();
// }

// while (password != "password");

// System.Console.WriteLine("correct!!!");

// ----------------------------

// while (counter < 10)
// {
//     System.Console.WriteLine("enter password: ");
//     password = Console.ReadLine();

//     if (password == "password")
//     {
//         System.Console.WriteLine("correct!!!");
//         break;
//     }

//     counter++;
// }

// ----------------------------

for (int y = 1; y < 11; y++)
{
    System.Console.WriteLine(y);
}

// ----------------------------

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    System.Console.WriteLine($"{name} has {name.Length} chars");
}
