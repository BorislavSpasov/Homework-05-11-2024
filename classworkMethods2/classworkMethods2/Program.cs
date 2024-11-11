using System.Diagnostics;

class MaxNumber()
{
    static void Main(string[] args)
    {
        int[] ints = {8, 3, 9};
        int maxNum = GetMax(ints, ints[0]);
        Console.WriteLine(maxNum);
    }
    static int GetMax(int[] ints, int tempNum)
    {
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] > tempNum) tempNum = ints[i];
        }
        return tempNum;
    }
}