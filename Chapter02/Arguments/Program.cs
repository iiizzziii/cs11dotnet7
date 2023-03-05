WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("you must specify 2 colors & cursor size");
    WriteLine("dotnet run red yellow 50");
    return; // stop run
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);

CursorSize = int.Parse(args[2]);
