// using System;

// class Program
// {
//     static void Main()
//     {
//         int height;
//         while (true)
//         {
//             Console.Write("ใส่จำนวนที่เป็นเลขคี่ที่มากกว่า 5: ");
//             if (int.TryParse(Console.ReadLine(), out height) && height > 5 && height % 2 != 0)
//             {
//                 break;
//             }
//             Console.WriteLine("ใส่จำนวนเลขคี่ที่มากกว่า 5 อีกครั้ง");
//         }

//         DrawEight(height);
//     }

//     static void DrawEight(int height)
//     {
//         int mid = height / 2;

//         for (int i = 0; i < height; i++)
//         {
//             for (int j = 0; j < height; j++)
//             {
//                 if (i == 0 || i == mid || i == height - 1 || j == 0 || j == height - 1)
//                 {
//                     Console.Write("*");
//                 }
//                 else
//                 {
//                     Console.Write(" ");
//                 }
//             }
//             Console.WriteLine();
//         }
//     }
// }
