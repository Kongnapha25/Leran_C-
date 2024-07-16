// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write(" ใส่ตัวเลขในรูปแบบของ array (คั่นด้วยช่องว่าง): ");
//         string input = Console.ReadLine();

//         int[] numbers = input.Split(' ').Select(int.Parse).ToArray(); // แปลงค่าที่ผู้ใช้ป้อนให้เป็น array ของ integers

//         int sumOfPrimes = 0;        // คำนวณผลรวมของตัวเลขที่เป็นจำนวนเฉพาะ
//         foreach (int number in numbers)
//         {
//             if (IsPrime(number))
//             {
//                 sumOfPrimes += number;
//             }
//         }
//         Console.WriteLine("ผลรวมของตัวเลขที่เป็นจำนวนเฉพาะใน array คือ: " + sumOfPrimes);     // แสดงผลรวมของตัวเลขที่เป็นจำนวนเฉพาะ2 3 4 5 6 7
//     }

//     // ฟังก์ชันตรวจสอบจำนวนเฉพาะ
//     static bool IsPrime(int number)
//     {
//         if (number <= 1) return false;
//         if (number == 2) return true;
//         if (number % 2 == 0) return false;

//         for (int i = 3; i <= Math.Sqrt(number); i += 2)
//         {
//             if (number % i == 0) return false;
//         }
//         return true;
//     }
// }
