// using System;

// namespace ConsoleApp1
// {
//     class Myproject
//     {
//         static void Main(string[] args)
//         {
//             CheckDayoff();
//         }

//         static void CheckDayoff()
//         {
//             Console.WriteLine("Enter the weekdays of the week Monday-Sunday. : ");
//             string Dayofweek = Console.ReadLine();
//             Console.WriteLine("Is it a public holiday? (true/false):");
//             bool ispublicholiday = bool.Parse(Console.ReadLine());
//             Console.WriteLine("Is it a holiday announced by the company? (true/false):");
//             bool isspecialcompanyholiday = bool.Parse(Console.ReadLine());

//             // เช็ควันที่เข้ามาเป็นวันหยุดไหม
//             bool isholiday = IsHoliday(Dayofweek, ispublicholiday, isspecialcompanyholiday);

//             // แสดงผลลัพธ์
//             if (isholiday)
//             {
//                 Console.WriteLine("The day received is a holiday.");
//             }
//             else
//             {
//                 Console.WriteLine("The day of receipt is not a holiday.");
//             }
//         }

//         static bool IsHoliday(string DayOfWeek, bool ispublicholiday, bool isspecialcompanyholiday)
//         {
//             // เช็ควันหยุดเสาร์อาทิตย์
//             bool isWeekend = DayOfWeek.Equals("Saturday", StringComparison.OrdinalIgnoreCase) || 
//                              DayOfWeek.Equals("Sunday", StringComparison.OrdinalIgnoreCase);

//             // เช็คว่าตรงกับเงื่อนไขวันหยุดใดๆ
//             return isWeekend || ispublicholiday || isspecialcompanyholiday;
//         }
//     }
// }
