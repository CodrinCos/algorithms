static int[] FindTwoSum(int[] nums, int target)
{
    var numsMap = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (numsMap.TryGetValue(nums[i], out int previousValue))
        {
            return [previousValue, i];
        }
        else
        {
            var numberToFind = target - nums[i];
            numsMap[numberToFind] = i;
        }
    }

    return [];
}

Console.WriteLine("This solves Two sum: given an array of int and a value, find the 2 indexes from array that their values summed returns the value");

var toReturn = FindTwoSum([1, 3, 7, 9, 10], 11);

if (toReturn.Length == 0) Console.WriteLine("Not found");

if (toReturn.Length == 2) Console.WriteLine($"{toReturn[0]}, {toReturn[1]}");


