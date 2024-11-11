class Reversal
{
    static void Main(string[] args)
    {
        double yourNum = double.Parse(Console.ReadLine());
        char[] arrayYourNum = yourNum.ToString().ToCharArray();
        Console.WriteLine(ReverseDecimalNum(arrayYourNum));
    }
    static string ReverseDecimalNum(char[] arrayYourNum)
    {
        string reverse = null;
        for (int i = arrayYourNum.Length - 1; i > -1; i--)
        {
            reverse += arrayYourNum[i];
        }
        return reverse;
    }
}