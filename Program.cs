Console.WriteLine("Bubble sort...");

Console.WriteLine("Add numbers: ");
int[] sortedNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

SelectSort(sortedNumbers);

static void SelectSort(int[] sortedNumbers)
{
    for (int i = 0; i < sortedNumbers.Length - 1; i++)
    {
        for (int j = i + 1; j < sortedNumbers.Length; j++)
        {
            if (sortedNumbers[i] > sortedNumbers[j])
            {
                int temp = sortedNumbers[i];
                sortedNumbers[i] = sortedNumbers[j];
                sortedNumbers[j] = temp;
            }
        }
    }
    Console.WriteLine("Sorted numbers: ");
    foreach (var number in sortedNumbers)
    {
        Console.Write(number + " ");
    }
}

