Console.WriteLine("Quick sort...");

Console.WriteLine("Add numbers: ");
int[] sortedNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

QuickSort(sortedNumbers);


static void QuickSort(int[] arr)
{
    QuickSortRecursion(arr, 0, arr.Length - 1);

    Console.WriteLine(string.Join(" ", arr));
}

static void QuickSortRecursion(int[] array, int start, int end)
{
    if(start >= end)
    {
        return;
    }

    int pivot = start;
    int left = start + 1;
    int right = end;

    while (right >= left)
    {
        if (array[pivot] < array[left] && array[pivot] > array[right])
        {
            Swap(array, left, right);
        }

        if (array[left] <= array[pivot])
        {
            left++;
        }

        if (array[right] >= array[pivot])
        {
            right--;
        }

    }

    Swap(array, pivot, right);
    QuickSortRecursion(array, start, right - 1);
    QuickSortRecursion(array, right + 1, end);

}

static void Swap(int[] array, int left, int right)
{
    int temp = array[left];
    array[left] = array[right];
    array[right] = temp;
}   
