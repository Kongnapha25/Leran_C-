// using System;

// class Progarm
// {
//     static void Main()
//     {
//         Console.Write("ใส่จำนวนสถานีที่เดินทาง: ");
//         int stations = Convert.ToInt32(Console.ReadLine());

//         int fare = CalculateFare(stations);

//         Console.WriteLine($"ค่าโดยสารสำหรับ {stations} สถานี คือ {fare} บาท");
//     }

//     static int CalculateFare(int stations)
//     {
//         if (stations >= 1 && stations <= 3)
//         {
//             return 16;
//         }
//         else if (stations >= 4 && stations <= 8)
//         {
//             return 23;
//         }
//         else if (stations >= 9)
//         {
//             return 31;
//         }
//         else
//         {
//             Console.WriteLine("จำนวนสถานีที่ใส่ไม่ถูกต้อง");
//             return 0;
//         }
//     }
// }
