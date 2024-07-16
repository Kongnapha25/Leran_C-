// using System;

// class Program 
// {
//     static void Main()
//     {
//         string input = "Kongnapha , Wangta";
        
//         string reversed = ReverseString(input);
//         int vowelCount = CountVowels(input);
//         string upperCase = ConvertToUpper(input);
        
//         Console.WriteLine($"Original: {input}");
//         Console.WriteLine($"Reversed: {reversed}");
//         Console.WriteLine($"Number of vowels: {vowelCount}");
//         Console.WriteLine($"Uppercase: {upperCase}");
//     }

//     public static string ReverseString(string input)
//     {
//         char[] charArray = input.ToCharArray();
//         Array.Reverse(charArray);
//         return new string(charArray);
//     }

//     public static int CountVowels(string input)
//     {
//         string vowels = "aeiouAEIOU";
//         int count = 0;
        
//         foreach (char c in input)
//         {
//             if (vowels.IndexOf(c) >= 0)
//             {
//                 count++;
//             }
//         }
        
//         return count;
//     }

//     public static string ConvertToUpper(string input)
//     {
//         return input.ToUpper();
//     }
// }
