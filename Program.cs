


Console.WriteLine("Quick sort...");

Console.WriteLine("Add numbers: ");
int[] sortedNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

MergeSort(sortedNumbers);

Console.WriteLine("Sorted numbers: ");
foreach (int number in sortedNumbers)
{
    Console.Write(number + " ");
}

static int[] MergeSort(int[] sortedNumbers)
{
    int n = sortedNumbers.Length;
    if (n < 2)
        return sortedNumbers;

    int mid = n / 2;
    int[] left = new int[mid];
    int[] right = new int[n - mid];

    Array.Copy(sortedNumbers, left, mid);
    Array.Copy(sortedNumbers, mid, right, 0, n - mid);

    MergeSort(left);
    MergeSort(right);

    Merge(sortedNumbers, left, right);

    return sortedNumbers;
}

static void Merge(int[] sortedNumbers, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;
    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
        {
            sortedNumbers[k++] = left[i++];
        }
        else
        {
            sortedNumbers[k++] = right[j++];
        }
    }
    while (i < left.Length)
    {
        sortedNumbers[k++] = left[i++];
    }
    while (j < right.Length)
    {
        sortedNumbers[k++] = right[j++];
    }
}





