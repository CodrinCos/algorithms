int getMaxSubstring(string s)
{
    if (s.Length <= 1)
    {
        return s.Length;
    }

    var seenChar = new Dictionary<char, int>();
    var left = 0;
    var longest = 0;

    for (var right = 0; right < s.Length; right++)
    {
        var currentChar = s[right];
        int prevSeenChar = -1;
        if (seenChar.TryGetValue(currentChar, out prevSeenChar) && prevSeenChar >= left)
        {
            left = prevSeenChar + 1;
        }

        if (!seenChar.TryAdd(currentChar, right))
        {
            seenChar.Remove(currentChar);
            seenChar.Add(currentChar, right);
        }

        longest = Math.Max(longest, right - left + 1);
    }

    return longest;
}

Console.WriteLine("Longest substring");

Console.WriteLine(getMaxSubstring("asdfgadsa"));