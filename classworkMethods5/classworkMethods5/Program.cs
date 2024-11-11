class CheckGreater
{
    static void Main(string[] args)
    {
        int[] array = { 4, 2, 3, 5, 8, 2, 1, 4, 6 };
        int positionArray = int.Parse(Console.ReadLine());
        Console.WriteLine(IsItGreater(array, positionArray));
    }
    static string IsItGreater(int[] array, int positionArray)
    {
        bool isItGreater = true;
        for(int i = positionArray-1; i <= positionArray+1; i+=2)
        {
            if (!(array[i] < array[positionArray]))
            {
                isItGreater = false;
                break;
            }
        }
        if (isItGreater) return "Its greater than its neighbour indexes!";
        else return "Its NOT greater than its neighbour indexes!";
    }
}
