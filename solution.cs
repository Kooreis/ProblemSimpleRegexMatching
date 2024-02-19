Here is a simple console application in C# that implements a basic version of regular expression matching with `.` and `*`.

```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsMatch("aa", "a"));  // false
        Console.WriteLine(IsMatch("aa", "a*"));  // true
        Console.WriteLine(IsMatch("ab", ".*"));  // true
        Console.WriteLine(IsMatch("aab", "c*a*b"));  // true
        Console.WriteLine(IsMatch("mississippi", "mis*is*p*."));  // false
    }

    static bool IsMatch(string text, string pattern)
    {
        if (string.IsNullOrEmpty(pattern)) return string.IsNullOrEmpty(text);

        bool firstMatch = (!string.IsNullOrEmpty(text) &&
                           (pattern[0] == text[0] || pattern[0] == '.'));

        if (pattern.Length >= 2 && pattern[1] == '*')
        {
            return (IsMatch(text, pattern.Substring(2)) ||
                    (firstMatch && IsMatch(text.Substring(1), pattern)));
        }
        else
        {
            return firstMatch && IsMatch(text.Substring(1), pattern.Substring(1));
        }
    }
}
```

This program includes a `IsMatch` function that checks if the text matches the pattern. The `.` character matches any single character, and the `*` character matches zero or more of the preceding element. The function uses recursion to check each character of the text against the pattern.