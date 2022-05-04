class Program
{

    static void Main(string[] args)
    {
        SelectionSort(new int[] { 2, 7, 5,8,3,9,1 });
        Console.ReadLine();
    }

    static void SelectionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < numbers.Length; j++)
                if (numbers[j] < numbers[min_idx])
                    min_idx = j;

            // Swap the found minimum element with the first
            // element
            int temp = numbers[min_idx];
            numbers[min_idx] = numbers[i];
            numbers[i] = temp;
        }
    }
}