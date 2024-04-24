bool areEqual(string s, string t)
{
    var p1 = s.ToArray().Length - 1;
    var p2 = t.ToArray().Length - 1;
    while (p1 >= 0 || p2 >= 0)
    {
        if (s.ToArray()[p1] == '#' || t.ToArray()[p2] == '#')
        {
            if (s.ToArray()[p1] == '#')
            {
                var backCount = 2;
                while (backCount > 0)
                {
                    p1--;
                    backCount--;
                    if (s.ToArray()[p1] == '#')
                    {
                        backCount += 2;
                    }
                }
            }

            if (t.ToArray()[p2] == '#')
            {
                var backCount = 2;
                while (backCount > 0)
                {
                    p2--;
                    backCount--;
                    if (s.ToArray()[p2] == '#')
                    {
                        backCount += 2;
                    }
                }
            }
        }
        else
        {
            if (s.ToArray()[p1] != t.ToArray()[p2])
            {
                return false;
            }
            else
            {
                p1--;
                p2--;
            }
        }
    }

    return true;
}

Console.WriteLine("Typed out strings - easy");

Console.WriteLine(areEqual("aasdf#a", "asdx#a"));