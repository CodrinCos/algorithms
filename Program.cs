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

string valid = "abba";
string invalid = "aac";

Console.WriteLine(isValidPalindrome(valid));

Console.WriteLine(isValidPalindrome(invalid));

Console.WriteLine(isValidPalindromeFromMiddle(valid));

Console.WriteLine(isValidPalindromeFromMiddle(invalid));
