class NumInArray
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 2, 1, 2 };
        int yourNum = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your number is encountered in the array {CountNumArray(array, yourNum)} times!");
    }
    static int CountNumArray(int[] array, int yourNum)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == yourNum) counter++;
        }
        return counter;
    }
}