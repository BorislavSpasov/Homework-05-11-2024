class Sorting
{
    static void Main(string[] args)
    {
        int[] array = { 9, 5, 3, 1, 2, 6, 3, 4, 6 };
        Console.WriteLine(SortedDecendingArray(array));
    }
    static string SortedDecendingArray(int[] array)
    {
        string newArray = null;
        int nextMin;
        int reOrderHolder;
        for (int i = 0; i < array.Length; i++)
        {
            //remembering next index of the smallest number
            nextMin = GetMinNumIndex(array, i);
            //storing the current number in the location
            reOrderHolder = array[i];
            //setting new number in the current location
            array[i] = array[nextMin];
            //putting the number we stored in the place for the next smallest number
            array[nextMin] = reOrderHolder;
            newArray += array[i];
        }
        return newArray;
    }
    static int GetMinNumIndex(int[] array, int currentLocation)
    {
        int maxIndex = currentLocation;
        for (int i = currentLocation; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex]) maxIndex = i;
        }
        return maxIndex;
    }
}