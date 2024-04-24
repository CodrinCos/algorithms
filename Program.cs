// C# implementation to Check if 
// two strings after processing 
// backspace character are equal or not

using System;
using System.Text;

public class BackspaceStringCompare
{

    // function to remove backspaces and return refined string
    static string RemoveBackspace(string str)
    {
        StringBuilder res = new StringBuilder();
        foreach (char c in str)
        {
            if (c != '#')
            {
                res.Append(c);
            }
            else if (res.Length > 0)
            {
                res.Remove(res.Length - 1, 1);
            }
        }
        return res.ToString();
    }

    // function to compare the two strings
    static bool Compare(string s, string t)
    {
        s = RemoveBackspace(s);
        t = RemoveBackspace(t);
        return s.Equals(t);
    }

    // Driver code
    public static void Main(string[] args)
    {
        string s = "asdf#e#ks";
        string t = "aasdf#e#ks";
        if (Compare(s, t))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

// This code is contributed by codebraxnzt
