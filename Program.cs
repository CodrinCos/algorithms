int GetMaxContainerArea(int[] nums)
{
    var indexLeft = 0;
    var indexRight = nums.Length - 1;
    var maxArea = 0;

    while (indexLeft < indexRight)
    {
        var currentArea = int.Min(nums[indexLeft], nums[indexRight]) * (indexRight - indexLeft);
        if (currentArea > maxArea)
        {
            maxArea = currentArea;
        }

        if (nums[indexLeft] == int.Min(nums[indexLeft], nums[indexRight]))
        {
            indexLeft++;
        }
        else
        {
            indexRight--;
        }
    }

    return maxArea;
}

Console.WriteLine("Given an array of positive int, each int is a height of vertical line");
Console.WriteLine("Find 2 lines which together with the x axis forms a container that would hold the greatest amount");
Console.WriteLine("of water.Return the area of water it would hold.");

var maxContainerArea = GetMaxContainerArea([1, 2, 10, 7, 2, 3, 6, 5, 4, 3]);

Console.WriteLine(maxContainerArea.ToString());