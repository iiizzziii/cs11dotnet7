double heightInMetres = 1.88;

Console.WriteLine($"var {nameof(heightInMetres)} has value {heightInMetres}.");

// -----------------------------------------------------

string horizontalLine = new('-', count: 74);
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

string fullNameSep = "Bob\tSmith";
string filePath = @"C:\Users\moo\Documents\00";

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(horizontalLine);
Console.WriteLine(grinningEmoji);
System.Console.WriteLine( fullNameSep );
System.Console.WriteLine(filePath);

// -----------------------------------------------------

string xml = """
            <person age="50">
                <first_name>Mark</first_name>
            </person>
            """;

System.Console.WriteLine(xml);

// -----------------------------------------------------

var person = new { FirstName = "Alice", Age = 56};

string json = $$"""
            {
                "first_name": "{{person.FirstName}}",
                "age": "{{person.Age}}",
                "calculation": "{{ 1 + 2 }}"
            }
            """;

System.Console.WriteLine(json);