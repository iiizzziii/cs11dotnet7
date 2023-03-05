
class Animal // base class
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}

class Cat : Animal // animal sub-type
{
    public bool IsDomestic;
}

class Spider : Animal // animal sub-type
{
    public bool IsPoisonous;
}
