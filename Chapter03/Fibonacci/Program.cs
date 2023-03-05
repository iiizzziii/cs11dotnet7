
int[] fibArray = new int[] {0, 1};

for (int i = 0; i < 10; i++)
{
    int lastElement = fibArray[^2] + fibArray[^1];

    fibArray = fibArray.Append(lastElement).ToArray();
}

foreach (int i in fibArray)
{
    System.Console.WriteLine(i);
}
