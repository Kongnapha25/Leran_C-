using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

class InventoryManagementSystem
{
    private List<Product> products = new List<Product>();

    public void AddProduct(int id, string name, double price, int quantity)
    {
        products.Add(new Product(id, name, price, quantity));
        Console.WriteLine("เพิ่มสินค้าเรียบร้อยแล้ว");
    }

    public void RemoveProduct(int id)
    {
        products.RemoveAll(p => p.Id == id);
        Console.WriteLine("ลบสินค้าเรียบร้อยแล้ว");
    }

    public void SearchProductByName(string name)
    {
        var product = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            Console.WriteLine($"พบสินค้า: รหัส {product.Id}, ชื่อ {product.Name}, ราคา {product.Price}, จำนวน {product.Quantity}");
        }
        else
        {
            Console.WriteLine("ไม่พบสินค้าที่ค้นหา");
        }
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("สินค้าในคลัง:");
        foreach (var product in products)
        {
            Console.WriteLine($"รหัส {product.Id}, ชื่อ {product.Name}, ราคา {product.Price}, จำนวน {product.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagementSystem ims = new InventoryManagementSystem();

        ims.AddProduct(1, "โน้ตบุ๊ก", 25000, 10);
        ims.AddProduct(2, "โทรศัพท์", 15000, 20);

        ims.DisplayAllProducts();

        ims.SearchProductByName("โน้ตบุ๊ก");

        ims.RemoveProduct(1);

        ims.DisplayAllProducts();
    }
}
