// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("ใส่ปี ค.ศ. : ");
//         int year = int.Parse(Console.ReadLine());

//         //เช็คปีที่รับมา
//         bool isLepYear = IsLeapYear(year);

//         //แสดงผล
//         if(isLepYear)
//         {
//             Console.WriteLine($"{year} เป็นปีอธิกสุรทิน");
//         }
//         else
//         {
//             Console.WriteLine($"{year} ไม่เป็นปีอธิกสุรทิน");
//         }
//     }
//     static bool IsLeapYear(int year)
//     {
//         if (year % 4 == 0)
//         {
//             if (year % 100 == 0)
//             {
//                 if (year % 400 == 0)
//                 {
//                     return true;
//                 }
//                 else
//                 {
//                     return false;
//                 }
//             }
//             else
//             {
//                 return true;
//             }
//         }
//         else
//         {
//             return false;
//         }
//     }
// }