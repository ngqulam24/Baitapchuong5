using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một Dictionary<TKey, TValue>
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm một số cặp key-value vào Dictionary
        myDictionary.Add("apple", 5);
        myDictionary.Add("banana", 3);
        myDictionary.Add("orange", 7);

        // Kiểm tra xem một key có tồn tại trong Dictionary hay không
        string keyToCheck = "banana";
        if (myDictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"The key '{keyToCheck}' exists in the dictionary.");
        }
        else
        {
            Console.WriteLine($"The key '{keyToCheck}' does not exist in the dictionary.");
        }

        // Truy xuất giá trị an toàn bằng cách sử dụng TryGetValue
        int value;
        if (myDictionary.TryGetValue("orange", out value))
        {
            Console.WriteLine($"The value for the key 'orange' is: {value}");
        }
        else
        {
            Console.WriteLine("The key 'orange' does not exist in the dictionary.");
        }

        // Lặp qua các mục trong Dictionary
        Console.WriteLine("All key-value pairs in the dictionary:");
        foreach (KeyValuePair<string, int> item in myDictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}