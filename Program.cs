using System.Text.RegularExpressions;

bool isValidPalindrome(string s)
{
    s = Regex.Replace(s, @"/[^A-Za-z0-9]/g", "").ToLower();

    var indexRight = s.Length - 1;
    var indexLeft = 0;

    while (indexLeft <= indexRight)
    {
        if (s[indexLeft] != s[indexRight])
        {
            return false;
        }

        indexLeft++;
        indexRight--;
    }

    return true;
}

bool isValidPalindromeFromMiddle(string s)
{
    s = Regex.Replace(s, @"/[^A-Za-z0-9]/g", "").ToLower();

    int indexLeft;

    int indexRight;
    if (s.Length % 2 == 0)
    {
        indexLeft = s.Length / 2 - 1;
        indexRight = s.Length / 2;
    }
    else
    {
        indexRight = s.Length / 2;
        indexLeft = s.Length / 2;
    }

    while (indexLeft > 0 || indexRight < s.Length)
    {
        if (s[indexLeft] != s[indexRight])
        {
            return false;
        }
        indexLeft--;
        indexRight++;
    }

    return true;
}

bool isValidSubPalindrome(string s, int left, int right)
{
    while (left < right)
    {
        if (s[left] != s[right])
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}

bool isAlmostPalindrome(string s)
{
    var leftIndex = 0;
    var rightIndex = s.Length - 1;

    while (leftIndex < rightIndex)
    {
        if (s[leftIndex] != s[rightIndex])
        {
            return isValidSubPalindrome(s, leftIndex + 1, rightIndex) || isValidSubPalindrome(s, leftIndex, rightIndex - 1);
        }

        leftIndex++;
        rightIndex--;
    }

    return true;
}

string valid = "abccdba";

Console.WriteLine(isAlmostPalindrome(valid));