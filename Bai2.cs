using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Từ điển Anh - Việt");
            Console.WriteLine("1. Thêm từ mới vào từ điển");
            Console.WriteLine("2. Tra từ");
            Console.WriteLine("3. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddWord();
                    break;
                case 2:
                    LookupWord();
                    break;
                case 3:
                    Console.WriteLine("\nTạm biệt!");
                    break;
                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        } while (choice != 3);
    }

    static void AddWord()
    {
        Console.Write("\nNhập từ tiếng Anh: ");
        string englishWord = Console.ReadLine();
        Console.Write("Nhập nghĩa tiếng Việt: ");
        string vietnameseTranslation = Console.ReadLine();

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine("Từ đã tồn tại trong từ điển.");
        }
        else
        {
            dictionary.Add(englishWord, vietnameseTranslation);
            Console.WriteLine("Đã thêm từ mới vào từ điển.");
        }
    }

    static void LookupWord()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("\nNhập từ tiếng Anh cần tra: ");
        string englishWord = Console.ReadLine();

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine($"Nghĩa của '{englishWord}' là: {dictionary[englishWord]}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy từ này trong từ điển.");
        }
    }
}