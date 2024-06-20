using System;

class Program
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
    static void Main(string[] args)
    {
        // Kiểm tra với số nguyên
        int a = 5, b = 10;
        int maxInt = Max(a, b);
        Console.WriteLine($"Max of {a} and {b} is {maxInt}"); // Output: Max of 5 and 10 is 10

        // Kiểm tra với số thực
        double x = 3.14, y = 2.71;
        double maxDouble = Max(x, y);
        Console.WriteLine($"Max of {x} and {y} is {maxDouble}"); // Output: Max of 3.14 and 2.71 is 3.14

        // Kiểm tra với chuỗi
        string str1 = "Apple", str2 = "Banana";
        string maxString = Max(str1, str2);
        Console.WriteLine($"Max of \"{str1}\" and \"{str2}\" is \"{maxString}\""); // Output: Max of "Apple" and "Banana" is "Banana"
    }
}