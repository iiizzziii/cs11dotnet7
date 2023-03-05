
System.Console.WriteLine($"default(int) = {default(int)}");
System.Console.WriteLine($"default(bool) = {default(bool)}");
System.Console.WriteLine($"default(DateTime) = {default(DateTime)}");
System.Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
System.Console.WriteLine($"number has been set to: {number}.");

number = default;
System.Console.WriteLine($"number has been reset back to default: {number}.");

Person kim = new();
kim.birthDate = new(1987, 2, 7);

System.Console.WriteLine(kim.birthDate);
System.Console.WriteLine(kim);

class Person
{
    public DateTime birthDate;
}