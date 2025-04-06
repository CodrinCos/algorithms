Console.WriteLine("Bubble sort...");

Console.WriteLine("Add numbers: ");
int[] sortedNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

InsertSort(sortedNumbers);

static void InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }

    Console.WriteLine("Sorted numbers: ");
    foreach (int number in arr)
    {
        Console.Write(number + " ");
    }
}

