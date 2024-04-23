// var elevationArray = [0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2];

/*
1. Identify the pointer with the lesser value
2. Is this pointer value greater than or equal to max on that side
  yes -> update max on that side
  no -> get water for pointer, add to total
3. move pointer inwards
4. repeat for other pointer
 */
int GetTrappedRainwater(List<int> heights)
{
    var left = 0;
    var right = heights.Count - 1;
    var totalWater = 0;
    var maxLeft = 0;
    var maxRight = 0;

    while (left < right)
    {
        if (heights[left] <= heights[right])
        {
            if (heights[left] > maxLeft)
            {
                maxLeft = heights[left];
            }
            else
            {
                totalWater += maxLeft - heights[left];
            }

            left++;
        }
        else
        {
            if (heights[right] >= maxRight)
            {
                maxRight = heights[right];
            }
            else
            {
                totalWater += maxRight - heights[right];
            }

            right--;
        }
    }

    return totalWater;
}

Console.WriteLine("Trapped water");

var amount = GetTrappedRainwater([0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2]);

Console.WriteLine(amount);
