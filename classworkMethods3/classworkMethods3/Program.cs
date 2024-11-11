class NumberToTest
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(NumText(number));
    }
    static string NumText(int number)
    {
        string lastNumber = null;
        number = number % 10;
        switch (number)
        {
            case 0:
                lastNumber = "Zero";
                break;
            case 1:
                lastNumber = "One";
                break;
            case 2:
                lastNumber = "Two";
                break;
            case 3:
                lastNumber = "Three";
                break;
            case 4:
                lastNumber = "Four";
                break;
            case 5:
                lastNumber = "Five";
                break;
            case 6:
                lastNumber = "Six";
                break;
            case 7:
                lastNumber = "Seven";
                break;
            case 8:
                lastNumber = "Eight";
                break;
            case 9:
                lastNumber = "Nine";
                break;
        }
        return lastNumber;
    }
}