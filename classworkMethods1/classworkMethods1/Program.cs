class PrintName()
{
    public static void Main()
    {
        string name = Console.ReadLine();;
        HelloPerson(name);
    }
    public static void HelloPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}