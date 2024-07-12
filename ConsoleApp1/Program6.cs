// using System;
// class Program
// {
//     static void Main()
//     {
//         //คำนวณภาษี
//         Console.WriteLine("ใส่รายได้ต่อปี (บาท): ");
//         double income = Convert.ToDouble(Console.ReadLine());
//         double tax = CalculatIncomeTax(income);
//         Console.WriteLine($"ภาษีที่ต้องจ่ายสำหรับบรายได้ {income} บาท คือ {tax} บาท");
        
//     }

//     static double CalculatIncomeTax(double income)
//      {
//         double tax = 0;

//         if (income <= 150000)
//         {
//             tax = 0;
//         }
//         else if (income <= 300000)
//         {
//             tax = (income - 150000) * 0.05;
//         }
//         else if (income <= 500000)
//         {
//             tax = (150000 * 0) + (150000 * 0.05) + (income - 300000) * 0.10;
//         }
//         else
//         {
//             tax = (150000 * 0) + (150000 * 0.05) + (200000 * 0.10) + (income - 500000) * 0.15;
//         }

//         return tax;
//     }
// }
