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
}