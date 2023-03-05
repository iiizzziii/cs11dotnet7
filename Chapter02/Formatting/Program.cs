// int numberOfApples = 12;
// decimal pricePerApple = 0.35M;

// WriteLine(
//     format: "{0} apples cost {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples
// );

// string formatted = string.Format(
//     format: "{0} apples cost {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples
// );

// WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

Write("press any kay combination: ");

ConsoleKeyInfo key = ReadKey();

WriteLine();

WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
