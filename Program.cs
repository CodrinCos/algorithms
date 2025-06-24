Console.WriteLine("");


//Design a stack that supports push, pop, top and retrieving the minimum element in constant time.

public class Stackkk
{
    private static List<int> stackValues = [];
    public List<int> minValues = [];

    public void Push(int x)
    {
        stackValues.Add(x);

        if(x < minValues.Last())
        {
            minValues.Add(x);
        }
    }

    public int Pop()
    {
        var toReturn = stackValues.Last();

        if(stackValues.Last() == minValues.Last())
        {
            minValues.RemoveAt(minValues.Count - 1);
        }

        stackValues.RemoveAt(stackValues.Count - 1);

        return toReturn;
    }

    public int Top()
    {
        return stackValues.Last();
    }

    public int GetMin()
    {
        return minValues.Last();
    }
}