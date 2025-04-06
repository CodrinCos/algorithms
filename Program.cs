Console.WriteLine("Binary search with recursion...");

Console.WriteLine("Add numbers: ");
int[] sortedNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

Console.WriteLine("I want to find: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

bool isPresent = BinarySearch(sortedNumbers, 0, sortedNumbers.Length - 1, numberToFind);
if (isPresent)
{
    Console.WriteLine($"{numberToFind} is present in the array.");
}
else
{
    Console.WriteLine($"{numberToFind} is not present in the array.");
}

static bool BinarySearch(int[] arr, int left, int right, int x)
{
    if (right >= left)
    {
        int mid = left + (right - left) / 2;
        // If the element is present at the middle itself
        if (arr[mid] == x)
            return true;
        // If the element is smaller than mid, then it can only be present in left subarray
        if (arr[mid] > x)
            return BinarySearch(arr, left, mid - 1, x);
        // Else the element can only be present in right subarray
        return BinarySearch(arr, mid + 1, right, x);
    }
    // Element is not present in array
    return false;
}