using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một Hashtable
        Hashtable myHashtable = new Hashtable();

        // Thêm các cặp key-value vào Hashtable
        myHashtable.Add("name", "John Doe");
        myHashtable.Add("age", 35);
        myHashtable.Add("email", "john.doe@example.com");
        myHashtable.Add(1, 100);
        myHashtable.Add(true, "True value");

        // Kiểm tra sự tồn tại của key và value
        Console.WriteLine("Does 'name' key exist? " + myHashtable.ContainsKey("name")); // Output: True
        Console.WriteLine("Does 'address' key exist? " + myHashtable.ContainsKey("address")); // Output: False
        Console.WriteLine("Does '100' value exist? " + myHashtable.ContainsValue(100)); // Output: True
        Console.WriteLine("Does 'False' value exist? " + myHashtable.ContainsValue("False")); // Output: False

        // Truy xuất giá trị bằng chỉ mục
        Console.WriteLine("Name: " + myHashtable["name"]); // Output: John Doe
        Console.WriteLine("Age: " + myHashtable["age"]); // Output: 35

        // Lặp lại các key và value của Hashtable
        Console.WriteLine("\nKeys and Values:");
        foreach (DictionaryEntry entry in myHashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}