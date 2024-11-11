class AutoChecking
{
    static void Main(string[] args)
    {
        int[] array = { 4, 1, 2, 2, 2, 1, 4, 6, 1, 4, 1, 3, 9, 1 };
        Console.WriteLine($"First Index thats greater than both its neighbours is index number: {IndexLocation(array)}");
    }
    static int IndexLocation(int[] array)
    {
        int indexOfNumber = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if(LoopCheckIndex(i, array))
            {
                indexOfNumber = i;
                break;
            }
        }
        return indexOfNumber;
    }
    static bool LoopCheckIndex(int i, int[] array)
    {
        int j = i - 1;
        
        if (array[j] < array[i] && array[j + 2] < array[i]) return true;   
        else return false;

    }
}