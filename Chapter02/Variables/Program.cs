using System.Xml;

// object
object height = 1.88;
object name = "Amir";

// int len1 = name.Length;
int len2 = ((string)name).Length;

System.Console.WriteLine($"{name} has {len2} characters.");

// dynamic
dynamic something = "Ahmed";

something = new[] { 3, 5, 7};

System.Console.WriteLine($"length is {something.Length}.");

// --------------------------------------------------------

// int population = 67_000_000;
// double weight = 1.88;
// decimal price = 4.99M;
// string fruit = "Apples";
// char letter = 'Z';
// bool happy = true;

// var population = 67_000_000;
// var weight = 1.88;
// var price = 4.99M;
// var fruit = "Apples";
// var letter = 'Z';
// var happy = true;