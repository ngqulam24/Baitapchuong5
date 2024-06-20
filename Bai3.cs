using System;
using System.Collections;
using System.Text;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static ArrayList productList = new ArrayList();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Quản lý danh sách sản phẩm");
            Console.WriteLine("1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProducts();
                    break;
                case 3:
                    SearchProduct();
                    break;
                case 4:
                    Console.WriteLine("\nTạm biệt!");
                    break;
                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        } while (choice != 4);
    }

    static void AddProduct()
    {
        Product newProduct = new Product();
        Console.Write("\nNhập tên sản phẩm: ");
        newProduct.Name = Console.ReadLine();
        Console.Write("Nhập mô tả sản phẩm: ");
        newProduct.Description = Console.ReadLine();
        Console.Write("Nhập giá sản phẩm: ");
        newProduct.Price = decimal.Parse(Console.ReadLine());

        productList.Add(newProduct);
        Console.WriteLine("Đã thêm sản phẩm mới vào danh sách.");
    }

    static void DisplayProducts()
    {
        Console.OutputEncoding = Encoding.UTF8;
        if (productList.Count == 0)
        {
            Console.WriteLine("\nDanh sách sản phẩm hiện đang trống.");
            return;
        }

        Console.WriteLine("Danh sách sản phẩm:");
        foreach (Product product in productList)
        {
            Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price:C}");
        }
    }

    static void SearchProduct()
    {
        Console.OutputEncoding= Encoding.UTF8;
        Console.Write("\nNhập tên sản phẩm cần tìm: ");
        string searchName = Console.ReadLine();

        bool found = false;
        foreach (Product product in productList)
        {
            if (product.Name.Contains(searchName))
            {
                Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price:C}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy sản phẩm này trong danh sách.");
        }
    }
}