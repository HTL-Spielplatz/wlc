Console.WriteLine("Grias Eich");

public class BinarySearch
{
    public static int Search(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Target not found
    }
}

// Example usage
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 5;
        int result = BinarySearch.Search(array, target);
        Console.WriteLine(result != -1 ? $"Element found at index {result}" : "Element not found");
    }
}
