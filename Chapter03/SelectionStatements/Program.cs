// string password = "ninja";

// if (password.Length < 8)
// {
//     System.Console.WriteLine("pass too short");
// }
// else
// {
//     System.Console.WriteLine("pass good");
// }

// -----------------------------------------------------------------

// object o = 3; // add/remove "" to change behavior
// int j = 4;

// if (o is int i)
// {
//     System.Console.WriteLine($"{i} x {j} = {i * j}");
// }
// else
// {
//     System.Console.WriteLine(" o is no an int so it cant multiply");
// }

// -----------------------------------------------------------------

// int number = Random.Shared.Next(1, 7);
// System.Console.WriteLine($"my random number is {number}");

// switch (number)
// {
//     case 1:
//     System.Console.WriteLine("one");
//     break; // jumps to end of switch

//     case 2:
//     System.Console.WriteLine("two");
//     goto case 1;

//     case 3: // multiple case section
//     case 4:
//     System.Console.WriteLine("three or four");
//     goto case 1;

//     case 5:
//     goto A_label;

//     default:
//     System.Console.WriteLine("default");
//     break;
// } // switch end

// System.Console.WriteLine("end of switch");

// A_label:
// System.Console.WriteLine($"after A_label");

// -----------------------------------------------------------------

Animal?[] animals = new Animal?[]
{
    new Cat {   Name = "Karen", 
                Born = new(year: 2022, month: 8, day: 23), 
                Legs = 4, 
                IsDomestic = true
            },

    null,

    new Cat {   Name = "Mufasa",
                Born = new(year: 1994, month: 6, day: 12)
            },

    new Spider {    Name = "Sid Vicious", 
                    Born = DateTime.Today,
                    IsPoisonous = true
                },

    new Spider {    Name = "Captain Furry",
                    Born = DateTime.Today
                }
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggerCat when fourLeggerCat.Legs == 4:
        message = $"cat {fourLeggerCat.Name} has 4 legs";
        break;

        case Cat wildcat when wildcat.IsDomestic == false:
        message = $"non-domestic cat is named {wildcat.Name}";
        break;

        case Cat cat:
        message = $"cat is named {cat.Name}";
        break;

        default: // default is always evaluated last
        message = $"animal named {animal.Name} is a {animal.GetType().Name}";
        break;

        case Spider spider when spider.IsPoisonous:
        message = $"{spider.Name} spider is poisonous, run!!!";
        break;

        case null:
        message = "animal is null";
        break;
    }
    System.Console.WriteLine($"switch: {message}");

    message = animal switch // simplified with switch expressions
    {
        Cat fourLeggerCat when fourLeggerCat.Legs == 4 => $"cat {fourLeggerCat.Name} has 4 legs",

        Cat wildcat when wildcat.IsDomestic == false => $"non-domestic cat is named {wildcat.Name}",

        Cat cat => $"cat is named {cat.Name}",

        Spider spider when spider.IsPoisonous => $"{spider.Name} spider is poisonous, run!!!",

        null => "animal is null",

        _ => $"animal named {animal.Name} is a {animal.GetType().Name}"
    };
    System.Console.WriteLine($"switch: {message}");
}