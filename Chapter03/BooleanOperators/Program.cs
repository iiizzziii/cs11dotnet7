bool a = true;
bool b = false;

static bool DoStuff()
{
    System.Console.WriteLine("i am doing stuff");
    return true;
}

System.Console.WriteLine($"a & dostuff() = {a & DoStuff()}");
System.Console.WriteLine($"b & dostuff() = {b & DoStuff()}");

System.Console.WriteLine($"a && dostuff() = {a && DoStuff()}");
System.Console.WriteLine($"b && dostuff() = {b && DoStuff()}");
