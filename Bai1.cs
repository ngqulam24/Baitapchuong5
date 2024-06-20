using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    public double TotalScore { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Chương trình quản lý danh sách sinh viên");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
                case 3:
                    CalculateTotalScore();
                    break;
                case 4:
                    Console.WriteLine("Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        } while (choice != 4);
    }

    static void AddStudent()
    {
        Student student = new Student();
        Console.Write("\nNhập tên sinh viên: ");
        student.Name = Console.ReadLine();
        Console.Write("Nhập lớp của sinh viên: ");
        student.Class = Console.ReadLine();
        Console.Write("Nhập tổng điểm của sinh viên: ");
        student.TotalScore = double.Parse(Console.ReadLine());
        students.Add(student);
        Console.WriteLine("Đã thêm sinh viên mới.");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("\nKhông có sinh viên nào trong danh sách.");
            return;
        }

        Console.WriteLine("\nDanh sách sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Tên: {student.Name}, Lớp: {student.Class}, Tổng điểm: {student.TotalScore}");
        }
    }

    static void CalculateTotalScore()
    {
        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.TotalScore;
        }
        Console.WriteLine($"\nTổng điểm của tất cả sinh viên: {totalScore}");
    }
}