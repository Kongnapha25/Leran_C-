// using System;

// class Program
// {
//     static void Main()
//     {
//         // รับ
//         Console.WriteLine("กรอกน้ำหนักสินค้า (Kg) :");
//         double weight = double.Parse(Console.ReadLine());
        
//         //คำนวณค่าจัดส่ง
//         double shippingCost = CalculateShippingCost(weight);

//         //แสดงงผลลัพธ์
//         Console.WriteLine($"ค่าจัดส่งสินค้าน้ำหนัก {weight} kg คือ {shippingCost} บาท") ;

//     }

//     static double CalculateShippingCost(double weight) 
//     {
//         if (weight <= 1)
//         {
//             return 50;
//         }
//         else if (weight > 1 && weight <= 5)
//         {
//             return 100;
//         }
//         else if (weight > 5 && weight <= 10)
//         {
//             return 200;
//         }
//         else  
//         {
//             return 250;
//         }
//     }
// }