// uint naturalNumber = 23; // unsigned int >= 0

// int integerNumber = -23; // whole number

// float realNumber = 2.3F; // single-precision float (F - float literal)

// double anotherRealNumber = 2.3; // double-precision float (default for decimal numbers)

// int bigInt = 1_000_000;

// 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

System.Console.WriteLine($"{decimalNotation == binaryNotation}");
System.Console.WriteLine($"{decimalNotation == hexadecimalNotation}");